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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.OleDb;

/// <summary>
/// This program was written 4/26/2019 by Joe Coffman
/// It's purpose is to reconcile bank accounts and credit card accounts
/// It's input is a series of Excel spreadsheets.
/// </summary>


namespace RegReconSQL
{
    public partial class Form1 : Form
    {
        decimal endBal = 0;
        decimal begBal = 0;
        decimal decAmount = 0;
        decimal calcDiff = 0;
        decimal credits = 0;
        decimal debits = 0;
        decimal entBegBal = 0;
        List<int> checks1 = new List<int>();
        List<int> checks2 = new List<int>();
        DataTable dt = new DataTable();
        SqlConnection linkToDB;
        SqlCommand unitCommand;
        private SqlDataAdapter RegisterAdapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cklstBox1.Items.Clear();
            cklstBox2.Items.Clear();
            endBal = 0;
            begBal = 0;
            decAmount = 0;
            calcDiff = 0;
            credits = 0;
            debits = 0;
            entBegBal = 0;

            begBal = Convert.ToDecimal(txtBeginningBal.Text);
            txtBegBal.Text = String.Format("{0:C2}", begBal);
            entBegBal = Convert.ToDecimal(txtBeginningBal.Text);

            dt.Clear();



            //for production
            using (linkToDB = new SqlConnection(GetConnectionString()))
            {
                linkToDB.Open();

                    unitCommand = linkToDB.CreateCommand();
                    unitCommand.CommandType = CommandType.Text;
                    unitCommand.CommandText = "SELECT * FROM [" + cmbAccount.Text + "] ORDER BY rDate";


                    using (SqlDataAdapter sleda = new SqlDataAdapter(unitCommand))
                    {
                        sleda.Fill(dt);
                    }

                linkToDB.Close();

                foreach (DataRow row in dt.Rows)
                {
                    if ((row[1].ToString() != "Date") && (row[1].ToString() != ""))
                    {
                        try
                        {
                            string theDate = row[1].ToString();
                            string lDate = theDate.Substring(0, 10);

                              if ((DateTime.Parse(lDate) >= DateTime.Parse(dTPStartDate.Text)) && (DateTime.Parse(lDate) <= DateTime.Parse(dTP_EndDate.Text)))
                                {
                                //Fix the length of the description so it's not too long
                                if (row[2].ToString().Length > 16)
                                    row[2] = row[2].ToString().Substring(0, 16);

                                if (row[4].ToString() != "" && Convert.ToInt32(row[4]) != 0.00)
                                {
                                    decAmount = Convert.ToDecimal(row[4]);
                                    debits = debits + decAmount;
                                    string formAmount = String.Format("{0:C}", decAmount);
                                    cklstBox1.Items.Add(String.Format("{0,-10} {1,-17} {2,10}", lDate.ToString(), row[2].ToString(), formAmount.ToString()));
                                }
                                if (row[5].ToString() != "" && row[5].ToString() != "0.0000")
                                    {
                                    decAmount = Convert.ToDecimal(row[5]);
                                    credits = credits + decAmount;
                                    string formAmount = String.Format("{0:C}", decAmount);
                                    cklstBox2.Items.Add(String.Format("{0,-10} {1,-17} {2,10}", lDate.ToString(), row[2].ToString(), formAmount.ToString()));
                                }

                            }
                        }
                        catch (FormatException )
                        {
                            // Console.WriteLine("Input error " + f.Message);
                            MessageBox.Show("Is the spreadsheet open? Is the date format good?");
                            Console.Read();
                            Environment.Exit(0);
                        }
                    }
                }
                txbCredits.Text = String.Format("{0:C}", credits);
                txbDeposits.Text = String.Format("{0:C}", debits);

                calcDiff = debits;
                txbDifference.Text = String.Format("{0:C}", calcDiff);

                if (cmbAccount.Text == "Chase Premier" || cmbAccount.Text == "Chase Joint")
                {
                    //For Bank Accounts
                    endBal = (begBal + credits) - debits;
                    txbEndBal.Text = String.Format("{0:C}", endBal);
                }
                else
                {
                    //For Credit Card Accounts
                    endBal = (begBal + debits) - credits;
                    txbEndBal.Text = String.Format("{0:C}", endBal);
                }
               

            }
        }

        private void cklstBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Process for debits
            foreach (int indexChecked in cklstBox1.CheckedIndices)
            {
                //// The indexChecked variable contains the index of the item.
                ////MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                ////        cklstBox1.GetItemCheckState(indexChecked).ToString() + ".");
                int index = checks1.IndexOf(indexChecked);
                if (index == -1)
                {
                    checks1.Add(indexChecked);

                    string theAmt = cklstBox1.SelectedItem.ToString().Substring(28, 11);
                    theAmt = theAmt.Replace("$", String.Empty).Replace(",", String.Empty);

                    calcDiff = calcDiff - Convert.ToDecimal(theAmt);
                    txbDifference.Text = String.Format("{0:C}", calcDiff);
                }
            }
        }

        private void cklstBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Process for credits
            foreach (int indexChecked in cklstBox2.CheckedIndices)
            {
                //    // The indexChecked variable contains the index of the item.
                //    //MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                //    //        cklstBox2.GetItemCheckState(indexChecked).ToString() + ".");
                int index = checks2.IndexOf(indexChecked);
                if (index == -1)
                {
                    checks2.Add(indexChecked);

                    string theAmt = cklstBox2.SelectedItem.ToString().Substring(28, 11);
                    theAmt = theAmt.Replace("$", String.Empty).Replace(",", String.Empty);


                }
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
