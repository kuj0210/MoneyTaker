namespace MoneyTakerUI
{
    partial class MainStartForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.DdayPanel = new System.Windows.Forms.Panel();
            this.PatchLogPanel = new System.Windows.Forms.Panel();
            this.MyRatingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DdayList = new System.Windows.Forms.Panel();
            this.ChartPanel.SuspendLayout();
            this.DdayPanel.SuspendLayout();
            this.PatchLogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyRatingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.MyRatingChart);
            this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChartPanel.Location = new System.Drawing.Point(0, 0);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(926, 290);
            this.ChartPanel.TabIndex = 0;
            // 
            // DdayPanel
            // 
            this.DdayPanel.Controls.Add(this.DdayList);
            this.DdayPanel.Controls.Add(this.label3);
            this.DdayPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DdayPanel.Location = new System.Drawing.Point(0, 290);
            this.DdayPanel.Name = "DdayPanel";
            this.DdayPanel.Size = new System.Drawing.Size(410, 295);
            this.DdayPanel.TabIndex = 1;
            // 
            // PatchLogPanel
            // 
            this.PatchLogPanel.Controls.Add(this.label2);
            this.PatchLogPanel.Controls.Add(this.label1);
            this.PatchLogPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PatchLogPanel.Location = new System.Drawing.Point(410, 290);
            this.PatchLogPanel.Name = "PatchLogPanel";
            this.PatchLogPanel.Size = new System.Drawing.Size(452, 295);
            this.PatchLogPanel.TabIndex = 2;
            // 
            // MyRatingChart
            // 
            this.MyRatingChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.MyRatingChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyRatingChart.BorderlineWidth = 0;
            this.MyRatingChart.BorderSkin.BorderWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.MyRatingChart.ChartAreas.Add(chartArea1);
            this.MyRatingChart.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.MyRatingChart.Legends.Add(legend1);
            this.MyRatingChart.Location = new System.Drawing.Point(0, 0);
            this.MyRatingChart.Name = "MyRatingChart";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.Color.Maroon;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerBorderWidth = 3;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "rating";
            series1.ShadowColor = System.Drawing.Color.White;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValuesPerPoint = 4;
            this.MyRatingChart.Series.Add(series1);
            this.MyRatingChart.Size = new System.Drawing.Size(862, 290);
            this.MyRatingChart.TabIndex = 0;
            title1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            title1.Name = "name";
            title1.Text = "A month of credit change";
            this.MyRatingChart.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(47, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"가장 적은 것으로도 만족하는 사람이 \r\n\r\n가장 부유한 사람이다.\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(135, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "오늘의 명언";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "얼마 남지않은 받아야 할 / 갚아야 할 목록";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DdayList
            // 
            this.DdayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.DdayList.Location = new System.Drawing.Point(42, 70);
            this.DdayList.Name = "DdayList";
            this.DdayList.Size = new System.Drawing.Size(315, 197);
            this.DdayList.TabIndex = 1;
            // 
            // MainStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(926, 585);
            this.Controls.Add(this.PatchLogPanel);
            this.Controls.Add(this.DdayPanel);
            this.Controls.Add(this.ChartPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainStartForm";
            this.Text = "MainStartForm";
            this.Load += new System.EventHandler(this.MainStartForm_Load);
            this.ChartPanel.ResumeLayout(false);
            this.DdayPanel.ResumeLayout(false);
            this.DdayPanel.PerformLayout();
            this.PatchLogPanel.ResumeLayout(false);
            this.PatchLogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyRatingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MyRatingChart;
        private System.Windows.Forms.Panel DdayPanel;
        private System.Windows.Forms.Panel PatchLogPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DdayList;
    }
}