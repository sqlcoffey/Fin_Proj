using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChkRegisters_Click(object sender, EventArgs e)
        {
            Process exec_Search = new Process();
            exec_Search.StartInfo.FileName = @"D:\Documents\Visual Studio 2017\Projects\Financial Projects\Check Registers\Check Registers\bin\Debug\Check Registers.exe";
            exec_Search.Start();
        }

        private void btnRegisterSearch_Click(object sender, EventArgs e)
        {
            Process exec_Search = new Process();
            exec_Search.StartInfo.FileName = @"D:\Documents\Visual Studio 2017\Projects\Financial Projects\RegisterSearch_V3\RegisterSearch_V3\bin\Debug\RegisterSearch_V3.exe";
            exec_Search.Start();
        }

        private void btnReconciliation_Click(object sender, EventArgs e)
        {
            Process exec_Search = new Process();
            exec_Search.StartInfo.FileName = @"D:\Documents\Visual Studio 2017\Projects\Financial Projects\RegReconSQL\RegReconSQL\bin\Debug\RegReconSQL.exe";
            exec_Search.Start();
        }

        private void btnMonthlySummary_Click(object sender, EventArgs e)    {
            Process exec_Search = new Process();
            exec_Search.StartInfo.FileName = @"D:\Documents\Visual Studio 2017\Projects\Financial Projects\DGV3_MonthlySummary\DGV3_MonthlySummary\bin\Debug\DGV3_MonthlySummary.exe";
            exec_Search.Start();
        }

        //private void btnTransfer_Click(object sender, EventArgs e)
        //{
        //    Process exec_Search = new Process();
        //    exec_Search.StartInfo.FileName = @"D:\Documents\visual studio 2017\Projects\Financial Projects\Register _Transfer\Register _Transfer\bin\Debug\Register _Transfer.exe";
        //    exec_Search.Start();
        //}

        private void btnYearlySummary_Click(object sender, EventArgs e)
        {
            Process exec_Search = new Process();
            exec_Search.StartInfo.FileName = @"D:\Documents\visual studio 2017\Projects\Financial Projects\Yearly_Summary\Yearly_Summary\bin\Debug\Yearly_Summary.exe";
            exec_Search.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBudgetCodeMaint_Click(object sender, EventArgs e)
        {
            Process exec_Search = new Process();
            exec_Search.StartInfo.FileName = @"D:\Documents\visual studio 2017\Projects\Financial Projects\BudgetCodeMaint\bin\Debug\BudgetCodeMaint.exe";
            exec_Search.Start();
        }
    }
}