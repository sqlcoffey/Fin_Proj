using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yearly_Summary_Graph
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cmbYear.Text = "2019";
            btnLoad.PerformClick();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           string theYear = cmbYear.Text;

            if (string.IsNullOrEmpty(theYear))
            {
                lblSelectYear.Text = " No Year Selected";
            }
            else
            {
               
            }

            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand cmd = new SqlCommand("Yearly_Graph", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@year", cmbYear.Text));
            con.Open();

            // populate data reader with return data result set 
            // and close connection after populating data set
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // assign data source to Chart
            chart1.DataSource = reader;

            // Set series data source to stored procedures returned data set's columns
            chart1.Series[0].XValueMember = "Description";
            chart1.Series[0].YValueMembers = "DebitToDate";
            // chart1.Series[0]["PieLabelStyle"] = "Disabled";

            // data bind chart
            chart1.DataBind();
            reader.Close();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
      
    }
}
