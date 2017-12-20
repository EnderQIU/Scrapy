namespace Scrapy
{
    partial class DisplayForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin1;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Azure;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DeepSkyBlue;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.MediumTurquoise;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.MediumTurquoise;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Turquoise;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.MediumTurquoise;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Turquoise;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.MediumTurquoise;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.LineColor = System.Drawing.Color.MediumAquamarine;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-10, -4);
            this.chart1.Name = "chart1";
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Transparent;
            series1.CustomProperties = "DrawingStyle=Cylinder, \"DrawingStyle=Cylinder\"";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Label = "#VAL";
            series1.LabelForeColor = System.Drawing.Color.CornflowerBlue;
            series1.Legend = "Legend1";
            series1.LegendText = "岗位数量";
            series1.LegendToolTip = "公司岗位数量";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1247, 518);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "公司岗位数量分析";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart2.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart2.BorderSkin.PageColor = System.Drawing.Color.Gray;
            this.chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin1;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 68.10396F;
            chartArea2.Position.Width = 77.56649F;
            chartArea2.Position.X = 10.07377F;
            chartArea2.Position.Y = 21.57501F;
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(-10, 507);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieDrawingStyle=Concave, PieLabelStyle=Outside";
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Label = "#PERCENT";
            series2.LabelForeColor = System.Drawing.Color.DeepSkyBlue;
            series2.Legend = "Legend1";
            series2.LegendText = "#VALX";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1235, 488);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "编程语言比例分析";
            this.chart2.Titles.Add(title2);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1247, 716);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}