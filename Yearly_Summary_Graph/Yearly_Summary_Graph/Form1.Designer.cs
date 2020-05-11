namespace Yearly_Summary_Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSelectYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 70);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLineColor=Blue, PieLabelStyle=Outside";
            series1.Label = "#VALX\\n#PERCENT{P}";
            series1.Legend = "Legend1";
            series1.LegendText = "#AXISLABEL";
            series1.Name = "Series1";
            dataPoint1.IsVisibleInLegend = true;
            dataPoint1.Label = "#PERCENT";
            dataPoint1.LegendText = "#AXISLABEL";
            series1.Points.Add(dataPoint1);
            series1.XValueMember = "DebitToDate";
            series1.YValueMembers = "Description";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1027, 628);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(21, 23);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(80, 15);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Select Year";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbYear.Location = new System.Drawing.Point(119, 23);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(90, 21);
            this.cmbYear.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(383, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(501, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYear.Location = new System.Drawing.Point(664, 30);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(0, 15);
            this.lblSelectYear.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 741);
            this.Controls.Add(this.lblSelectYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Yearly Summary Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSelectYear;
    }
}

