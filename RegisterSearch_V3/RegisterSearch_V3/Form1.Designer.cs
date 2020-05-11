namespace RegisterSearch_V3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.brnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblDebits = new System.Windows.Forms.Label();
            this.txbDebits = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txbCredits = new System.Windows.Forms.TextBox();
            this.lblDiff = new System.Windows.Forms.Label();
            this.txbDiff = new System.Windows.Forms.TextBox();
            this.lblNbrRecords = new System.Windows.Forms.Label();
            this.txbNbrRecs = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.registersDataSet = new RegisterSearch_V3.RegistersDataSet();
            this.budgetCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetCodesTableAdapter = new RegisterSearch_V3.RegistersDataSetTableAdapters.BudgetCodesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetCodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Budget Code";
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Items.AddRange(new object[] {
            "Chase Premier",
            "Chase Joint",
            "Amazon CC",
            "Capital One",
            "CitiBank"});
            this.cmbAccount.Location = new System.Drawing.Point(166, 30);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(121, 21);
            this.cmbAccount.TabIndex = 2;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
            "ALL"});
            this.cmbMonth.Location = new System.Drawing.Point(355, 31);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 2;
            // 
            // cmbCode
            // 
            this.cmbCode.DataSource = this.budgetCodesBindingSource;
            this.cmbCode.DisplayMember = "Code";
            this.cmbCode.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(579, 30);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(268, 20);
            this.cmbCode.TabIndex = 2;
            // 
            // brnStart
            // 
            this.brnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnStart.Location = new System.Drawing.Point(873, 26);
            this.brnStart.Name = "brnStart";
            this.brnStart.Size = new System.Drawing.Size(75, 23);
            this.brnStart.TabIndex = 3;
            this.brnStart.Text = "Load";
            this.brnStart.UseVisualStyleBackColor = true;
            this.brnStart.Click += new System.EventHandler(this.brnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(873, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(166, 73);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(0, 16);
            this.lblAccount.TabIndex = 5;
            // 
            // lblDebits
            // 
            this.lblDebits.AutoSize = true;
            this.lblDebits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebits.Location = new System.Drawing.Point(875, 182);
            this.lblDebits.Name = "lblDebits";
            this.lblDebits.Size = new System.Drawing.Size(84, 15);
            this.lblDebits.TabIndex = 6;
            this.lblDebits.Text = "Total Debits";
            // 
            // txbDebits
            // 
            this.txbDebits.Location = new System.Drawing.Point(975, 182);
            this.txbDebits.Name = "txbDebits";
            this.txbDebits.Size = new System.Drawing.Size(100, 20);
            this.txbDebits.TabIndex = 7;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(875, 147);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(88, 15);
            this.lblCredits.TabIndex = 6;
            this.lblCredits.Text = "Total Credits";
            // 
            // txbCredits
            // 
            this.txbCredits.Location = new System.Drawing.Point(975, 147);
            this.txbCredits.Name = "txbCredits";
            this.txbCredits.Size = new System.Drawing.Size(100, 20);
            this.txbCredits.TabIndex = 7;
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.Location = new System.Drawing.Point(875, 217);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(73, 15);
            this.lblDiff.TabIndex = 6;
            this.lblDiff.Text = "Difference";
            // 
            // txbDiff
            // 
            this.txbDiff.Location = new System.Drawing.Point(975, 217);
            this.txbDiff.Name = "txbDiff";
            this.txbDiff.Size = new System.Drawing.Size(100, 20);
            this.txbDiff.TabIndex = 7;
            // 
            // lblNbrRecords
            // 
            this.lblNbrRecords.AutoSize = true;
            this.lblNbrRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrRecords.Location = new System.Drawing.Point(64, 480);
            this.lblNbrRecords.Name = "lblNbrRecords";
            this.lblNbrRecords.Size = new System.Drawing.Size(198, 15);
            this.lblNbrRecords.TabIndex = 8;
            this.lblNbrRecords.Text = "Number of Records Displayed";
            // 
            // txbNbrRecs
            // 
            this.txbNbrRecs.Location = new System.Drawing.Point(285, 480);
            this.txbNbrRecs.Name = "txbNbrRecs";
            this.txbNbrRecs.Size = new System.Drawing.Size(59, 20);
            this.txbNbrRecs.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(960, 27);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 15);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbYear.Location = new System.Drawing.Point(1012, 26);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(63, 23);
            this.cmbYear.TabIndex = 11;
            // 
            // registersDataSet
            // 
            this.registersDataSet.DataSetName = "RegistersDataSet";
            this.registersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetCodesBindingSource
            // 
            this.budgetCodesBindingSource.DataMember = "BudgetCodes";
            this.budgetCodesBindingSource.DataSource = this.registersDataSet;
            // 
            // budgetCodesTableAdapter
            // 
            this.budgetCodesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 524);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txbNbrRecs);
            this.Controls.Add(this.lblNbrRecords);
            this.Controls.Add(this.txbDiff);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.txbCredits);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.txbDebits);
            this.Controls.Add(this.lblDebits);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.brnStart);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterSearch V3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetCodesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.Button brnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblDebits;
        private System.Windows.Forms.TextBox txbDebits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txbCredits;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.TextBox txbDiff;
        private System.Windows.Forms.Label lblNbrRecords;
        private System.Windows.Forms.TextBox txbNbrRecs;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private RegistersDataSet registersDataSet;
        private System.Windows.Forms.BindingSource budgetCodesBindingSource;
        private RegistersDataSetTableAdapters.BudgetCodesTableAdapter budgetCodesTableAdapter;
    }
}

