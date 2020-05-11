/**
 * REGISTER SEARCH
 * This application allows the user to search different register accounts for dates and budget codes.
 * This datagridview is UNBOUND.
 * Created by Joe Coffman on 6/11/2019
 * 
 **/

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

namespace RegisterSearch_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbYear.Text = "2019";
        }

       // DataTable dt = new DataTable("RegSearch");

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

        private void brnStart_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            DataTable dt = new DataTable("RegSearch");
            SqlCommand cmd;
            string theAccount = null;
            int theMonth = 0;
            string theCode = null;
            decimal totalDebits = 0;
            decimal totalCredits = 0;
            decimal totalDiff = 0;
            int NbrOfRecs = -1;
            txbDebits.Text = "";
            txbCredits.Text = "";
            txbDiff.Text = "";

            //Check to see if an account has been selected
            if (string.IsNullOrWhiteSpace(cmbAccount.Text))
            {
                lblAccount.Text = " No Account Selected";
            }
            else
            {
                theAccount = "[" + cmbAccount.Text + "]";
                lblAccount.Text = cmbAccount.Text + " Selected";
            }
            //Check to see if 'ALL' has been selected for month
            if (cmbMonth.Text == "ALL")
            {
                cmbMonth.Text = null;
            }
            //Convert the month name to a number
            if (!string.IsNullOrEmpty(cmbMonth.Text))
            {

                theMonth = convert_Month_to_digit(cmbMonth.Text);
            }
            //If a code has been selected truncate it to four positoins
            if (!string.IsNullOrEmpty(cmbCode.Text))
            {
                theCode = cmbCode.Text.Substring(0, 4);
            }
            //check to see if 'ALL' has been selected for code
            if (theCode == "ALL ")
            {
                theCode = null;
            }

            SqlConnection con = new SqlConnection(GetConnectionString());

            //Select the proper SQLcommand parameters based on month and code selections

            if (theMonth > 0 && !string.IsNullOrEmpty(theCode))                   //Month & code selected
            {
                cmd = new SqlCommand("RegisterSearch_V2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@account", theAccount));
                cmd.Parameters.Add(new SqlParameter("@month", theMonth));
                cmd.Parameters.Add(new SqlParameter("@code", theCode));
                cmd.Parameters.Add(new SqlParameter("@year", cmbYear.Text));
            }
            else
            {
                if (string.IsNullOrEmpty(theCode) & theMonth > 0)                  //Month selected but no code
                {
                    cmd = new SqlCommand("RegisterSearch_NoCode_V2", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@account", theAccount));
                    cmd.Parameters.Add(new SqlParameter("@month", theMonth));
                    cmd.Parameters.Add(new SqlParameter("@year", cmbYear.Text));
                }
                else
                {
                    if (theMonth <= 0 && !string.IsNullOrEmpty(theCode))            //Code selected but no month
                    {
                        cmd = new SqlCommand("RegisterSearch_NoMonth_V2", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@account", theAccount));
                        cmd.Parameters.Add(new SqlParameter("@code", theCode));
                        cmd.Parameters.Add(new SqlParameter("@year", cmbYear.Text));
                    }
                    else                                                             //No code or month selected
                    {
                        cmd = new SqlCommand("RegisterSearch_NoMonth_NoCode_V2", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@account", theAccount));
                        cmd.Parameters.Add(new SqlParameter("@year", cmbYear.Text));
                    }
                }
            }

            con.Open();

            // Load the datatable
            //DataTable dt = new DataTable("RegSearch");

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

                        if (!String.IsNullOrEmpty(dr[4].ToString()))
                        {
                            totalDebits = totalDebits + Convert.ToDecimal(dr[4]);
                            decimal value = Convert.ToDecimal(dr[4]);
                            dr[4] = value.ToString("C", new CultureInfo("en-US"));
                        }

                        if (!String.IsNullOrEmpty(dr[5].ToString()))
                        {
                            totalCredits = totalCredits + Convert.ToDecimal(dr[5]);
                            decimal value = Convert.ToDecimal(dr[5]);
                            dr[5] = value.ToString("C", new CultureInfo("en-US"));
                        }


                        dt.Rows.Add(dr);

                        dataGridView1.DataSource = dt;

                        //****************************************************************************
                        //set autosize mode
                        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

                        dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy'/'MM'/'dd";
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Bold);
                        dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                        // How to insert into the last row --don't delete
                        //int index = dataGridView1.Rows.Count - 1;
                        //dataGridView1.Rows[index].Cells[2].Value = "Total";
                        //dataGridView1.Rows[index].Cells[3].Style.Format = "$";
                        //dataGridView1.Rows[index].Cells[3].Value = 123;
                        //dataGridView1.Rows[index].Cells[4].Value = 456;

                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        NbrOfRecs = NbrOfRecs + 1;
                        row.Cells[4].Style.ForeColor = Color.Red;
                        row.Cells[5].Style.ForeColor = Color.Green;
                        txbDebits.ForeColor = Color.Red;
                        txbDebits.Text = totalDebits.ToString("C", new CultureInfo("en-US"));
                        txbCredits.ForeColor = Color.Green;
                        txbCredits.Text = totalCredits.ToString("C", new CultureInfo("en-US"));
                        totalDiff = totalCredits - totalDebits;
                        if(totalDiff < 0)
                        {
                            txbDiff.ForeColor = Color.Red;
                        }
                        else
                        {
                            txbDiff.ForeColor = Color.Green;
                        }
                        txbDiff.Text = totalDiff.ToString("C", new CultureInfo("en-US"));




                    }
                    txbNbrRecs.Text = NbrOfRecs.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, \n" + ex.Message);
            }

        }

        //Convert the month name to a digit.
        private int convert_Month_to_digit(string month)
        {
            int month_num = 0;
            List <string> theMonths = new List<string>() { "January", "February", "March", "April", "May", "June", "July",
                                                  "August", "September", "October", "November", "December"};

            for (int i = 0; i < theMonths.Count; i++)
            {
                //MessageBox.Show(i.ToString());
                if (month == theMonths[i])
                {
                    month_num = i + 1;
                    break;
                }
            }
            if (month_num == 0)
            {
                MessageBox.Show("Invalid Month");
            }
            return month_num;
        }

        //Create the header records
        private void getHeaders(DataTable theDT)
        {
            theDT.Columns.Add("ID");
            theDT.Columns.Add("Date", typeof(DateTime));
            theDT.Columns.Add("Description");
            theDT.Columns.Add("Code");
            theDT.Columns.Add("Debit");
            theDT.Columns.Add("Credit");
           

        }

        //Exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //DataAdapter.Update(dt);
            ////in your code this would be:
            //da.Update(dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registersDataSet.BudgetCodes' table. You can move, or remove it, as needed.
            this.budgetCodesTableAdapter.Fill(this.registersDataSet.BudgetCodes);

        }
    }
}
