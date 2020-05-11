using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// This program is used to select and transfer Excel register data to SQL
/// </summary>

namespace Transfer_Excel_To_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string account = cmbAccount.Text;
            int found = (account.IndexOf("$"));             //Take off the 's' for the sql insert
            string Sqlaccount = account.Substring(0, found) + ']';
            int rCount = 0;

            //Test
            //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jcoff\OneDrive\My Excel Documents\VBA\Check registers_Test.xlsm;" +
            //                                            "Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");

            //Production
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jcoff\OneDrive\My Excel Documents\Check Registers.xlsm;" +
                                                      "Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
            con.Open();

            OleDbCommand cmd = new OleDbCommand
            {
                Connection = con,
                CommandType = CommandType.Text,
                //cmd.CommandText = "SELECT * FROM [Chase Premier$]";// + account;
                CommandText = "SELECT * FROM" + account
            };

            DataSet rs = new DataSet();
            OleDbDataAdapter oleda = new OleDbDataAdapter(cmd);
            //con.Close();
            oleda.Fill(rs);
            DataTable Exceldt = rs.Tables[0];

            //Write to Database

            SqlConnection conSQL = new SqlConnection(@"server = DESKTOP-362T7CB\SQLEXPRESS;Database = Registers;integrated security = sspi");
            conSQL.Open();

            SqlCommand cmdSQL = new SqlCommand((@"Truncate Table [dbo]." + Sqlaccount ), conSQL)
            {
                Connection = conSQL
            };
            cmdSQL.ExecuteNonQuery();

            try
            {


                for (int x = 1; x < Exceldt.Rows.Count - 1; x++)
                {

                     cmdSQL = new SqlCommand((@"INSERT INTO [dbo]." + Sqlaccount + " VALUES(@pDate, @pDesc, @pCode, @pDebit, @pCredit)"), conSQL)
                    {
                        Connection = conSQL
                    };


                    if (Exceldt.Rows[x][1].ToString() != "")
                    {
                        DateTime rDate = DateTime.FromOADate(Convert.ToDouble(Exceldt.Rows[x][1]));

                        cmdSQL.Parameters.AddWithValue("pDate", rDate);
                        cmdSQL.Parameters.AddWithValue("pDesc", Exceldt.Rows[x][2]);
                        cmdSQL.Parameters.AddWithValue("pCode", Exceldt.Rows[x][3]);
                        cmdSQL.Parameters.AddWithValue("pDebit", Exceldt.Rows[x][4]);
                        cmdSQL.Parameters.AddWithValue("pCredit", Exceldt.Rows[x][5]);


                        cmdSQL.ExecuteNonQuery();
                        rCount ++;

                        lblCount.Text = rCount.ToString() + " Records Transfered Successfully";
                    }
                }
                conSQL.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred loading records: " + ex.Message);
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
