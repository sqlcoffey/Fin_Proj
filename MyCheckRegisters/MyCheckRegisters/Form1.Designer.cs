namespace MyCheckRegisters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chasePremierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registersDataSet = new MyCheckRegisters.RegistersDataSet();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.chase_PremierTableAdapter = new MyCheckRegisters.RegistersDataSetTableAdapters.Chase_PremierTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCodes = new System.Windows.Forms.ComboBox();
            this.registersDataSet1 = new MyCheckRegisters.RegistersDataSet1();
            this.budgetCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetCodesTableAdapter = new MyCheckRegisters.RegistersDataSet1TableAdapters.BudgetCodesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chasePremierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetCodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rIDDataGridViewTextBoxColumn,
            this.rDateDataGridViewTextBoxColumn,
            this.rDescriptionDataGridViewTextBoxColumn,
            this.rCodeDataGridViewTextBoxColumn,
            this.rDebitDataGridViewTextBoxColumn,
            this.rCreditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chasePremierBindingSource;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.NullValue = null;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(261, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.Size = new System.Drawing.Size(793, 700);
            this.dataGridView1.TabIndex = 0;
            // 
            // rIDDataGridViewTextBoxColumn
            // 
            this.rIDDataGridViewTextBoxColumn.DataPropertyName = "rID";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.rIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.rIDDataGridViewTextBoxColumn.Name = "rIDDataGridViewTextBoxColumn";
            this.rIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // rDateDataGridViewTextBoxColumn
            // 
            this.rDateDataGridViewTextBoxColumn.DataPropertyName = "rDate";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.rDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.rDateDataGridViewTextBoxColumn.Name = "rDateDataGridViewTextBoxColumn";
            this.rDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rDescriptionDataGridViewTextBoxColumn
            // 
            this.rDescriptionDataGridViewTextBoxColumn.DataPropertyName = "rDescription";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.rDescriptionDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.rDescriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.rDescriptionDataGridViewTextBoxColumn.Name = "rDescriptionDataGridViewTextBoxColumn";
            this.rDescriptionDataGridViewTextBoxColumn.Width = 315;
            // 
            // rCodeDataGridViewTextBoxColumn
            // 
            this.rCodeDataGridViewTextBoxColumn.DataPropertyName = "rCode";
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rCodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.rCodeDataGridViewTextBoxColumn.HeaderText = "CODE";
            this.rCodeDataGridViewTextBoxColumn.Name = "rCodeDataGridViewTextBoxColumn";
            this.rCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rDebitDataGridViewTextBoxColumn
            // 
            this.rDebitDataGridViewTextBoxColumn.DataPropertyName = "rDebit";
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDebitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.rDebitDataGridViewTextBoxColumn.HeaderText = "DEBIT";
            this.rDebitDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.rDebitDataGridViewTextBoxColumn.Name = "rDebitDataGridViewTextBoxColumn";
            this.rDebitDataGridViewTextBoxColumn.Width = 85;
            // 
            // rCreditDataGridViewTextBoxColumn
            // 
            this.rCreditDataGridViewTextBoxColumn.DataPropertyName = "rCredit";
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rCreditDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.rCreditDataGridViewTextBoxColumn.HeaderText = "CREDIT";
            this.rCreditDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.rCreditDataGridViewTextBoxColumn.Name = "rCreditDataGridViewTextBoxColumn";
            this.rCreditDataGridViewTextBoxColumn.Width = 85;
            // 
            // chasePremierBindingSource
            // 
            this.chasePremierBindingSource.DataMember = "Chase Premier";
            this.chasePremierBindingSource.DataSource = this.registersDataSet;
            // 
            // registersDataSet
            // 
            this.registersDataSet.DataSetName = "RegistersDataSet";
            this.registersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxBalance
            // 
            this.tbxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBalance.Location = new System.Drawing.Point(686, 731);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.Size = new System.Drawing.Size(131, 24);
            this.tbxBalance.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(606, 731);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(74, 20);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance";
            // 
            // chase_PremierTableAdapter
            // 
            this.chase_PremierTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(24, 731);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxAccount
            // 
            this.cbxAccount.FormattingEnabled = true;
            this.cbxAccount.Items.AddRange(new object[] {
            "[Chase Premier]",
            "[Chase Joint]",
            "[Amazon CC]",
            "[Capital One]",
            "[CitiBank]"});
            this.cbxAccount.Location = new System.Drawing.Point(24, 102);
            this.cbxAccount.Name = "cbxAccount";
            this.cbxAccount.Size = new System.Drawing.Size(172, 21);
            this.cbxAccount.TabIndex = 4;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(55, 66);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(117, 13);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "SELECT ACCOUNT";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(48, 155);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(124, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "LOAD ACCOUNT";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 732);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCodes
            // 
            this.cmbCodes.DataSource = this.budgetCodesBindingSource;
            this.cmbCodes.DisplayMember = "Code";
            this.cmbCodes.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodes.FormattingEnabled = true;
            this.cmbCodes.Location = new System.Drawing.Point(48, 244);
            this.cmbCodes.Name = "cmbCodes";
            this.cmbCodes.Size = new System.Drawing.Size(121, 19);
            this.cmbCodes.TabIndex = 8;
            // 
            // registersDataSet1
            // 
            this.registersDataSet1.DataSetName = "RegistersDataSet1";
            this.registersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetCodesBindingSource
            // 
            this.budgetCodesBindingSource.DataMember = "BudgetCodes";
            this.budgetCodesBindingSource.DataSource = this.registersDataSet1;
            // 
            // budgetCodesTableAdapter
            // 
            this.budgetCodesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 775);
            this.Controls.Add(this.cmbCodes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.cbxAccount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Check Register ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chasePremierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetCodesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RegistersDataSet registersDataSet;
        private System.Windows.Forms.BindingSource chasePremierBindingSource;
        private RegistersDataSetTableAdapters.Chase_PremierTableAdapter chase_PremierTableAdapter;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCodes;
        private RegistersDataSet1 registersDataSet1;
        private System.Windows.Forms.BindingSource budgetCodesBindingSource;
        private RegistersDataSet1TableAdapters.BudgetCodesTableAdapter budgetCodesTableAdapter;
    }
}

