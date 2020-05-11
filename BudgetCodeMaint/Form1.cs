using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetCodeMaint
{
    public partial class Form1 : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        int ID = 0;
        

       

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(GetConnectionString());
            con.Open();
            displayBudgets();
        }

        // Set up the connection string to the SQL Server
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

        //Display Data in DataGridView
        private void displayBudgets()
        {
            dataGridView1.DataSource = null;
            cmd = new SqlCommand("BudgetCodeSelect", con);
            cmd.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            getHeaders(dt);

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridView1.Font = new Font("Tahoma", 9F, FontStyle.Bold);

            // Build the data rows
            try
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = reader.GetValue(0).ToString();
                        dr[1] = reader.GetValue(1).ToString();
                        dr[2] = reader.GetValue(2).ToString();
                        dr[3] = reader.GetValue(3).ToString();
                        dr[4] = reader.GetValue(4).ToString();
                        dr[5] = reader.GetValue(5).ToString();

                        decimal value = Convert.ToDecimal(dr[5]);
                        dr[5] = value.ToString("C", new CultureInfo("en-US"));
                        dt.Rows.Add(dr);
                        dataGridView1.DataSource = dt;

                        //****************************************************************************
                        //set autosize mode
                        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    
                        //datagrid has calculated it's widths so we can store them
                        for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                        {
                            //store autosized widths
                            int colw = dataGridView1.Columns[i].Width;
                            //remove autosizing
                            dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                            //set width to calculated by autosize
                            dataGridView1.Columns[i].Width = colw;
                        }
                        //****************************************************************************
                        
                        dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                       
                    }
                    txbCategory.Text = "";
                    txbSubCategory.Text = "";
                    txbBudgetCode.Text = "";
                    txbDesc.Text = "";
                    txbMonthBudget.Text = "";

                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error, \n \n\n" + ex.Message);
                con.Close();
            }
    }
            
             //Create the header records
            private void getHeaders(DataTable theDT)
            {
                theDT.Columns.Add("ID");
                theDT.Columns.Add("Category");
                theDT.Columns.Add("SubCategory");
                theDT.Columns.Add("Code");
                theDT.Columns.Add("Description");
                theDT.Columns.Add("BudgetAmt");
            }

      
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            // INSERT demo
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("INSERT BudgetTable (Category, SubCategory, Code, Description, BudgetAmt) ");
            sb.Append("VALUES (@category, @subcategory, @code, @desc, @budgetamt );");
           String  sql = sb.ToString();
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@category", txbCategory.Text);
                command.Parameters.AddWithValue("@subcategory", txbSubCategory.Text);
                command.Parameters.AddWithValue("@code", txbBudgetCode.Text);
                command.Parameters.AddWithValue("@desc", txbDesc.Text);
                command.Parameters.AddWithValue("@budgetamt", txbMonthBudget.Text);
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " row(s) inserted");
                displayBudgets();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("UPDATE BudgetTable SET Category = @category, SubCategory = @subcategory, Code = @code, Description =  @desc, BudgetAmt = @budgetamt WHERE bID = " + ID );
            String sql = sb.ToString();
            using (SqlCommand command = new SqlCommand(sql, con))
            {

                command.Parameters.AddWithValue("@ID",ID);
                command.Parameters.AddWithValue("@category", txbCategory.Text);
                command.Parameters.AddWithValue("@subcategory", txbSubCategory.Text);
                command.Parameters.AddWithValue("@code", txbBudgetCode.Text);
                command.Parameters.AddWithValue("@desc", txbDesc.Text);
                command.Parameters.AddWithValue("@budgetamt", txbMonthBudget.Text);
                int rowsAffected = command.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
                displayBudgets();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                
                cmd = new SqlCommand("delete from BudgetTable  where  bID = " + ID, con);
                cmd.Parameters.AddWithValue("@bID", ID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully!");
                displayBudgets();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
           txbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           txbSubCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           txbBudgetCode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           txbDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           txbMonthBudget.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
    }
}



