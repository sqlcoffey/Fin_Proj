namespace RegReconSQL
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
            this.cklstBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtBegBal = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblBegBal = new System.Windows.Forms.Label();
            this.cklstBox2 = new System.Windows.Forms.CheckedListBox();
            this.lblDebits = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txbDeposits = new System.Windows.Forms.TextBox();
            this.txbCredits = new System.Windows.Forms.TextBox();
            this.txbEndBal = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.lslCrds = new System.Windows.Forms.Label();
            this.lblEndBal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeginningBal = new System.Windows.Forms.TextBox();
            this.txbDifference = new System.Windows.Forms.TextBox();
            this.lblDiff = new System.Windows.Forms.Label();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.dTP_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cklstBox1
            // 
            this.cklstBox1.CheckOnClick = true;
            this.cklstBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklstBox1.FormattingEnabled = true;
            this.cklstBox1.Location = new System.Drawing.Point(64, 194);
            this.cklstBox1.Name = "cklstBox1";
            this.cklstBox1.Size = new System.Drawing.Size(325, 293);
            this.cklstBox1.TabIndex = 0;
            this.cklstBox1.SelectedIndexChanged += new System.EventHandler(this.cklstBox1_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(64, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 33);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Trans";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.cmbAccount.Location = new System.Drawing.Point(441, 29);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(130, 21);
            this.cmbAccount.TabIndex = 3;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(348, 27);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(75, 20);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "Account";
            // 
            // txtBegBal
            // 
            this.txtBegBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBegBal.Location = new System.Drawing.Point(995, 32);
            this.txtBegBal.Name = "txtBegBal";
            this.txtBegBal.Size = new System.Drawing.Size(130, 21);
            this.txtBegBal.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(306, 56);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(117, 20);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Starting Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(314, 82);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(109, 20);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "Ending Date";
            // 
            // lblBegBal
            // 
            this.lblBegBal.AutoSize = true;
            this.lblBegBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegBal.Location = new System.Drawing.Point(817, 30);
            this.lblBegBal.Name = "lblBegBal";
            this.lblBegBal.Size = new System.Drawing.Size(159, 20);
            this.lblBegBal.TabIndex = 10;
            this.lblBegBal.Text = "Beginning Balance";
            // 
            // cklstBox2
            // 
            this.cklstBox2.CheckOnClick = true;
            this.cklstBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklstBox2.FormattingEnabled = true;
            this.cklstBox2.Location = new System.Drawing.Point(441, 194);
            this.cklstBox2.Name = "cklstBox2";
            this.cklstBox2.Size = new System.Drawing.Size(325, 293);
            this.cklstBox2.TabIndex = 11;
            this.cklstBox2.SelectedIndexChanged += new System.EventHandler(this.cklstBox2_SelectedIndexChanged);
            // 
            // lblDebits
            // 
            this.lblDebits.AutoSize = true;
            this.lblDebits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebits.Location = new System.Drawing.Point(185, 162);
            this.lblDebits.Name = "lblDebits";
            this.lblDebits.Size = new System.Drawing.Size(61, 20);
            this.lblDebits.TabIndex = 12;
            this.lblDebits.Text = "Debits";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(574, 162);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(66, 20);
            this.lblCredits.TabIndex = 13;
            this.lblCredits.Text = "Credits";
            // 
            // txbDeposits
            // 
            this.txbDeposits.Location = new System.Drawing.Point(995, 71);
            this.txbDeposits.Name = "txbDeposits";
            this.txbDeposits.Size = new System.Drawing.Size(130, 20);
            this.txbDeposits.TabIndex = 14;
            // 
            // txbCredits
            // 
            this.txbCredits.Location = new System.Drawing.Point(995, 110);
            this.txbCredits.Name = "txbCredits";
            this.txbCredits.Size = new System.Drawing.Size(130, 20);
            this.txbCredits.TabIndex = 15;
            // 
            // txbEndBal
            // 
            this.txbEndBal.Location = new System.Drawing.Point(995, 149);
            this.txbEndBal.Name = "txbEndBal";
            this.txbEndBal.Size = new System.Drawing.Size(130, 20);
            this.txbEndBal.TabIndex = 16;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(817, 71);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(61, 20);
            this.lblDep.TabIndex = 17;
            this.lblDep.Text = "Debits";
            // 
            // lslCrds
            // 
            this.lslCrds.AutoSize = true;
            this.lslCrds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lslCrds.Location = new System.Drawing.Point(817, 110);
            this.lslCrds.Name = "lslCrds";
            this.lslCrds.Size = new System.Drawing.Size(66, 20);
            this.lslCrds.TabIndex = 18;
            this.lslCrds.Text = "Credits";
            // 
            // lblEndBal
            // 
            this.lblEndBal.AutoSize = true;
            this.lblEndBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndBal.Location = new System.Drawing.Point(817, 149);
            this.lblEndBal.Name = "lblEndBal";
            this.lblEndBal.Size = new System.Drawing.Size(135, 20);
            this.lblEndBal.TabIndex = 19;
            this.lblEndBal.Text = "Ending Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Beginning Balance";
            // 
            // txtBeginningBal
            // 
            this.txtBeginningBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeginningBal.Location = new System.Drawing.Point(441, 110);
            this.txtBeginningBal.Name = "txtBeginningBal";
            this.txtBeginningBal.Size = new System.Drawing.Size(130, 21);
            this.txtBeginningBal.TabIndex = 7;
            // 
            // txbDifference
            // 
            this.txbDifference.Location = new System.Drawing.Point(995, 194);
            this.txbDifference.Name = "txbDifference";
            this.txbDifference.Size = new System.Drawing.Size(130, 20);
            this.txbDifference.TabIndex = 22;
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.Location = new System.Drawing.Point(817, 192);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(93, 20);
            this.lblDiff.TabIndex = 23;
            this.lblDiff.Text = "Difference";
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Location = new System.Drawing.Point(440, 56);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(200, 20);
            this.dTPStartDate.TabIndex = 24;
            // 
            // dTP_EndDate
            // 
            this.dTP_EndDate.Location = new System.Drawing.Point(441, 82);
            this.dTP_EndDate.Name = "dTP_EndDate";
            this.dTP_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dTP_EndDate.TabIndex = 25;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(64, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 541);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dTP_EndDate);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.txbDifference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBeginningBal);
            this.Controls.Add(this.lblEndBal);
            this.Controls.Add(this.lslCrds);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.txbEndBal);
            this.Controls.Add(this.txbCredits);
            this.Controls.Add(this.txbDeposits);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblDebits);
            this.Controls.Add(this.cklstBox2);
            this.Controls.Add(this.lblBegBal);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtBegBal);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cklstBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Reconciliation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklstBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtBegBal;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblBegBal;
        private System.Windows.Forms.CheckedListBox cklstBox2;
        private System.Windows.Forms.Label lblDebits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txbDeposits;
        private System.Windows.Forms.TextBox txbCredits;
        private System.Windows.Forms.TextBox txbEndBal;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lslCrds;
        private System.Windows.Forms.Label lblEndBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBeginningBal;
        private System.Windows.Forms.TextBox txbDifference;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.DateTimePicker dTP_EndDate;
        private System.Windows.Forms.Button btnExit;
    }
}

