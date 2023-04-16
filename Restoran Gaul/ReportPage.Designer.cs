namespace Restoran_Gaul
{
    partial class ReportPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.from_month = new System.Windows.Forms.ComboBox();
            this.to_month = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart_smk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_smk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 24F);
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label2.Location = new System.Drawing.Point(258, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.label3.Location = new System.Drawing.Point(258, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "To";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // from_month
            // 
            this.from_month.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.from_month.FormattingEnabled = true;
            this.from_month.Location = new System.Drawing.Point(326, 93);
            this.from_month.Name = "from_month";
            this.from_month.Size = new System.Drawing.Size(194, 31);
            this.from_month.TabIndex = 1;
            this.from_month.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // to_month
            // 
            this.to_month.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.to_month.FormattingEnabled = true;
            this.to_month.Location = new System.Drawing.Point(326, 139);
            this.to_month.Name = "to_month";
            this.to_month.Size = new System.Drawing.Size(194, 31);
            this.to_month.TabIndex = 1;
            this.to_month.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.button1.Location = new System.Drawing.Point(543, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart_smk
            // 
            this.chart_smk.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_smk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_smk.Legends.Add(legend1);
            this.chart_smk.Location = new System.Drawing.Point(12, 230);
            this.chart_smk.Name = "chart_smk";
            this.chart_smk.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chart_smk.Series.Add(series1);
            this.chart_smk.Size = new System.Drawing.Size(954, 415);
            this.chart_smk.TabIndex = 3;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(978, 657);
            this.Controls.Add(this.chart_smk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.to_month);
            this.Controls.Add(this.from_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportPage";
            this.Text = "ReportPage";
            this.Load += new System.EventHandler(this.ReportPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_smk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox from_month;
        private System.Windows.Forms.ComboBox to_month;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_smk;
    }
}