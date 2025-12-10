namespace Main
{
    partial class FormSalesStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.lblTodayCnt = new System.Windows.Forms.Label();
            this.lblMonthSales = new System.Windows.Forms.Label();
            this.lblMonthCnt = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPeriodResult = new System.Windows.Forms.Label();
            this.lvStats = new System.Windows.Forms.ListView();
            this.colSid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chartDaily = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.lblTotalSales);
            this.panelSummary.Controls.Add(this.lblMonthCnt);
            this.panelSummary.Controls.Add(this.lblMonthSales);
            this.panelSummary.Controls.Add(this.lblTodayCnt);
            this.panelSummary.Controls.Add(this.lblTodaySales);
            this.panelSummary.Location = new System.Drawing.Point(12, 12);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1115, 131);
            this.panelSummary.TabIndex = 0;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTodaySales.Location = new System.Drawing.Point(16, 18);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(150, 20);
            this.lblTodaySales.TabIndex = 0;
            this.lblTodaySales.Text = "오늘 매출: 0원";
            this.lblTodaySales.Click += new System.EventHandler(this.lblTodaySales_Click);
            // 
            // lblTodayCnt
            // 
            this.lblTodayCnt.AutoSize = true;
            this.lblTodayCnt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTodayCnt.Location = new System.Drawing.Point(410, 18);
            this.lblTodayCnt.Name = "lblTodayCnt";
            this.lblTodayCnt.Size = new System.Drawing.Size(192, 20);
            this.lblTodayCnt.TabIndex = 1;
            this.lblTodayCnt.Text = "오늘 판매건수: 0건";
            // 
            // lblMonthSales
            // 
            this.lblMonthSales.AutoSize = true;
            this.lblMonthSales.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMonthSales.Location = new System.Drawing.Point(16, 62);
            this.lblMonthSales.Name = "lblMonthSales";
            this.lblMonthSales.Size = new System.Drawing.Size(171, 20);
            this.lblMonthSales.TabIndex = 2;
            this.lblMonthSales.Text = "이번달 매출: 0원";
            // 
            // lblMonthCnt
            // 
            this.lblMonthCnt.AutoSize = true;
            this.lblMonthCnt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMonthCnt.Location = new System.Drawing.Point(410, 62);
            this.lblMonthCnt.Name = "lblMonthCnt";
            this.lblMonthCnt.Size = new System.Drawing.Size(213, 20);
            this.lblMonthCnt.TabIndex = 3;
            this.lblMonthCnt.Text = "이번달 판매건수: 0건";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalSales.Location = new System.Drawing.Point(16, 101);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(129, 20);
            this.lblTotalSales.TabIndex = 4;
            this.lblTotalSales.Text = "총 매출: 0원";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(12, 163);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(221, 25);
            this.dtStart.TabIndex = 1;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(272, 163);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(221, 25);
            this.dtEnd.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(514, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPeriodResult
            // 
            this.lblPeriodResult.AutoSize = true;
            this.lblPeriodResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPeriodResult.Location = new System.Drawing.Point(15, 201);
            this.lblPeriodResult.Name = "lblPeriodResult";
            this.lblPeriodResult.Size = new System.Drawing.Size(250, 20);
            this.lblPeriodResult.TabIndex = 4;
            this.lblPeriodResult.Text = "총 52건, 매출 312,000원";
            // 
            // lvStats
            // 
            this.lvStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSid,
            this.colDate,
            this.colTotal,
            this.colMethod});
            this.lvStats.FullRowSelect = true;
            this.lvStats.GridLines = true;
            this.lvStats.HideSelection = false;
            this.lvStats.Location = new System.Drawing.Point(12, 238);
            this.lvStats.MultiSelect = false;
            this.lvStats.Name = "lvStats";
            this.lvStats.Size = new System.Drawing.Size(445, 200);
            this.lvStats.TabIndex = 5;
            this.lvStats.UseCompatibleStateImageBehavior = false;
            this.lvStats.View = System.Windows.Forms.View.Details;
            // 
            // colSid
            // 
            this.colSid.Text = "매출번호";
            this.colSid.Width = 80;
            // 
            // colDate
            // 
            this.colDate.Text = "날짜";
            this.colDate.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.Text = "총금액";
            this.colTotal.Width = 90;
            // 
            // colMethod
            // 
            this.colMethod.Text = "결제방식";
            this.colMethod.Width = 120;
            // 
            // chartDaily
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDaily.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDaily.Legends.Add(legend1);
            this.chartDaily.Location = new System.Drawing.Point(700, 209);
            this.chartDaily.Name = "chartDaily";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDaily.Series.Add(series1);
            this.chartDaily.Size = new System.Drawing.Size(427, 229);
            this.chartDaily.TabIndex = 6;
            this.chartDaily.Text = "일별 매출 그래프";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "~";
            // 
            // chartCategory
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCategory.Legends.Add(legend2);
            this.chartCategory.Location = new System.Drawing.Point(890, 520);
            this.chartCategory.Name = "chartCategory";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCategory.Series.Add(series2);
            this.chartCategory.Size = new System.Drawing.Size(348, 229);
            this.chartCategory.TabIndex = 8;
            this.chartCategory.Text = "카테고리별 판매 비율";
            // 
            // chartMonthly
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMonthly.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMonthly.Legends.Add(legend3);
            this.chartMonthly.Location = new System.Drawing.Point(12, 520);
            this.chartMonthly.Name = "chartMonthly";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartMonthly.Series.Add(series3);
            this.chartMonthly.Size = new System.Drawing.Size(427, 229);
            this.chartMonthly.TabIndex = 9;
            this.chartMonthly.Text = "월별 매출 그래프";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(696, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "일별 매출 그래프";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(15, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "월별 매출 그래프";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(889, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "카테고리별 판매 비율";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(450, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "TOP 5 상품 그래프";
            // 
            // chartTop5
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTop5.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTop5.Legends.Add(legend4);
            this.chartTop5.Location = new System.Drawing.Point(454, 520);
            this.chartTop5.Name = "chartTop5";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTop5.Series.Add(series4);
            this.chartTop5.Size = new System.Drawing.Size(351, 229);
            this.chartTop5.TabIndex = 13;
            this.chartTop5.Text = "TOP 5 상품 그래프";
            // 
            // FormSalesStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 783);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chartTop5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartMonthly);
            this.Controls.Add(this.chartCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDaily);
            this.Controls.Add(this.lvStats);
            this.Controls.Add(this.lblPeriodResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.panelSummary);
            this.Name = "FormSalesStats";
            this.Text = "FormSalesStats";
            this.Load += new System.EventHandler(this.FormSalesStats_Load);
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblMonthCnt;
        private System.Windows.Forms.Label lblMonthSales;
        private System.Windows.Forms.Label lblTodayCnt;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPeriodResult;
        private System.Windows.Forms.ListView lvStats;
        private System.Windows.Forms.ColumnHeader colSid;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colMethod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDaily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5;
    }
}