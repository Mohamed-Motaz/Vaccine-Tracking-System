﻿
namespace VaccineTrackingSystem.Forms
{
    partial class DataVisualizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataVisualizationForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VaccinatedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GovernoratesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VaccinatedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovernoratesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // VaccinatedChart
            // 
            chartArea1.Name = "ChartArea1";
            this.VaccinatedChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.VaccinatedChart.Legends.Add(legend1);
            this.VaccinatedChart.Location = new System.Drawing.Point(7, 74);
            this.VaccinatedChart.Name = "VaccinatedChart";
            this.VaccinatedChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "#.##%";
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.VaccinatedChart.Series.Add(series1);
            this.VaccinatedChart.Size = new System.Drawing.Size(451, 270);
            this.VaccinatedChart.TabIndex = 0;
            this.VaccinatedChart.Text = "chart1";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.Location = new System.Drawing.Point(789, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 36);
            this.BackBtn.TabIndex = 45;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(473, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Distribution Of Vaccinated People By Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "Distribution Of Doses Of Vaccinated People";
            // 
            // GenderChart
            // 
            chartArea2.Name = "ChartArea1";
            this.GenderChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GenderChart.Legends.Add(legend2);
            this.GenderChart.Location = new System.Drawing.Point(478, 74);
            this.GenderChart.Name = "GenderChart";
            this.GenderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "#.##%";
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.GenderChart.Series.Add(series2);
            this.GenderChart.Size = new System.Drawing.Size(446, 270);
            this.GenderChart.TabIndex = 48;
            this.GenderChart.Text = "chart2";
            // 
            // GovernoratesChart
            // 
            chartArea3.Name = "ChartArea1";
            this.GovernoratesChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GovernoratesChart.Legends.Add(legend3);
            this.GovernoratesChart.Location = new System.Drawing.Point(232, 380);
            this.GovernoratesChart.Name = "GovernoratesChart";
            this.GovernoratesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "#.##%";
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.GovernoratesChart.Series.Add(series3);
            this.GovernoratesChart.Size = new System.Drawing.Size(506, 259);
            this.GovernoratesChart.TabIndex = 49;
            this.GovernoratesChart.Text = "chart3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(227, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 30);
            this.label3.TabIndex = 50;
            this.label3.Text = "Distribution Of Vaccinated People By Governorates";
            // 
            // DataVisualizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GovernoratesChart);
            this.Controls.Add(this.GenderChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.VaccinatedChart);
            this.Name = "DataVisualizationForm";
            this.Text = "DataVisualizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.VaccinatedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GovernoratesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart VaccinatedChart;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenderChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GovernoratesChart;
        private System.Windows.Forms.Label label3;
    }
}