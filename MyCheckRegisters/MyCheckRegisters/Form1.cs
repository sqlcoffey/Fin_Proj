using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCheckRegisters
{
    public partial class Form1 : Form
    {

        // ----Fields used to monitor the active database content.
        private SqlDataAdapter RegisterAdapter = new SqlDataAdapter();
        private DataTable RegisterTable = new DataTable();
        SqlCommand unitCommand;
        SqlConnection linkToDB;
        public event System.Windows.Forms.DataGridViewRowEventHandler DefaultValuesNeeded;
        string account = "";
        

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registersDataSet1.BudgetCodes' table. You can move, or remove it, as needed.
            this.budgetCodesTableAdapter.Fill(this.registersDataSet1.BudgetCodes);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            account = cbxAccount.Text;
            // TODO: This line of code loads data into the 'registersDataSet.Chase_Premier' table. You can move, or remove it, as needed.
            this.chase_PremierTableAdapter.Fill(this.registersDataSet.Chase_Premier);

            // ----Open the database
            linkToDB = new SqlConnection(GetConnectionString());

            // ---- Build the selection query

            unitCommand = new SqlCommand("SELECT * FROM " + account + " ORDER BY rDate;", linkToDB);
            RegisterAdapter.SelectCommand = unitCommand;

            // ----Build the insertion query  row.Cells[1].Value = (DateTime.Now);
            unitCommand = new SqlCommand(@"INSERT INTO " + account +  "(rDate, rDescription, rCode, rDebit, rCredit) VALUES(@rDate, @rDescription, @rCode, @rDebit, @rCredit); SET @rID = @@IDENTITY;", linkToDB);
            unitCommand.Parameters.Add("@rDate", SqlDbType.DateTime, 10, "rDate");
            unitCommand.Parameters.Add("@rDescription", SqlDbType.NVarChar, 50, "rDescription");
            unitCommand.Parameters.Add("@rCode", SqlDbType.Char, 10, "rCode");
            unitCommand.Parameters.Add("@rDebit", SqlDbType.Float, 10, "rDebit");
            unitCommand.Parameters.Add("@rCredit", SqlDbType.Float, 10, "rCredit");
            SqlParameter param = unitCommand.Parameters.Add("@rID", SqlDbType.BigInt, 0, "rID");
            param.Direction = ParameterDirection.Output;
            RegisterAdapter.InsertCommand = unitCommand;

            // ----Build the revision query
            unitCommand = new SqlCommand(@"UPDATE " + account + " SET rDate = @rDate, rDescription = @rDescription, rCode = @rCode, rDebit = @rDebit, rCredit = @rCredit", linkToDB);

            unitCommand.Parameters.Add("@rDate", SqlDbType.DateTime, 10, "rDate");
            unitCommand.Parameters.Add("@rDescription", SqlDbType.NVarChar, 50, "rDescription");
            unitCommand.Parameters.Add("@rCode", SqlDbType.Char, 10, "rCode");
            unitCommand.Parameters.Add("@rDebit", SqlDbType.Float, 10, "rDebit");
            unitCommand.Parameters.Add("@rCredit", SqlDbType.Float, 10, "rCredit");
            param = unitCommand.Parameters.Add("@rID", SqlDbType.BigInt, 0, "rID");
            param.SourceVersion = DataRowVersion.Original; ;
            RegisterAdapter.UpdateCommand = unitCommand;

            // ----Build the deletion query
            unitCommand = new SqlCommand("DELETE FROM " + account + " WHERE rID = @rID", linkToDB);
            param = unitCommand.Parameters.Add("@rID", SqlDbType.BigInt, 0, "rID");
            param.SourceVersion = DataRowVersion.Original;
            RegisterAdapter.DeleteCommand = unitCommand;

            
            // -----Load the data from the database into the local editor.
            try
            {
                //clear the datatable
                RegisterTable.Clear();
                //Load the datatable
                RegisterAdapter.Fill(RegisterTable);

                dataGridView1.DataSource = RegisterTable;
                this.dataGridView1.CurrentCell = this.dataGridView1[0, this.dataGridView1.Rows.Count - 1];
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    row.Cells[4].Style.ForeColor = Color.Red;
                    row.Cells[5].Style.ForeColor = Color.Green;
                    row.Cells[4].Style.Format = "c";
                    row.Cells[5].Style.Format = "c";

                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Bold);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred loading records: " + ex.Message);
            }

            // -- Process the current balance
            ProcessCurrentBalance();

        }

        public string GetConnectionString()
        {
            // ----Build a connection string for the active database.
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"DESKTOP-362T7CB\SQLEXPRESS",
                InitialCatalog = "Registers",
                IntegratedSecurity = true
            };
            return builder.ConnectionString;
        }

        public void ProcessCurrentBalance()
        {
           
            unitCommand = linkToDB.CreateCommand();
            linkToDB.Open();
            unitCommand = new SqlCommand("SELECT (SUM(rCredit)-SUM(rDebit)) FROM " + account, linkToDB);
            decimal value = Convert.ToDecimal(unitCommand.ExecuteScalar());
            tbxBalance.Text = value.ToString("C", new CultureInfo("en-US"));
            bool ok = value > 0;
            tbxBalance.ForeColor = ok ? Color.Green : Color.Red;

            linkToDB.Close();
        }

        //Save the data back to the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterAdapter.Update(RegisterTable);
                // -- Process the current balance
                ProcessCurrentBalance();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error ocurred during database update: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
