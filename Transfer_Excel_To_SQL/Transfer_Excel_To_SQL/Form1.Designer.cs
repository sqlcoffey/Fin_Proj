namespace Transfer_Excel_To_SQL
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
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Items.AddRange(new object[] {
            "[Chase Premier$]",
            "[Chase Joint$]",
            "[Amazon CC$]",
            "[Capital One$]",
            "[CitiBank$]"});
            this.cmbAccount.Location = new System.Drawing.Point(168, 35);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(121, 21);
            this.cmbAccount.TabIndex = 0;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(63, 38);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(80, 13);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "Select Account";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(168, 75);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(121, 23);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer Account";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(63, 155);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(7, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "\r\n";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 202);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.cmbAccount);
            this.Name = "Form1";
            this.Text = "Excel to SQL Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnExit;
    }
}

