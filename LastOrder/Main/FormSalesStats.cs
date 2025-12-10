using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Windows.Forms.DataVisualization.Charting;

namespace Main
{
    public partial class FormSalesStats : Form
    {
        private string connectionString =
            "User Id=pos; Password=1111;" +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        public FormSalesStats()
        {
            InitializeComponent();
        }

        private void FormSalesStats_Load(object sender, EventArgs e)
        {
            LoadDailySalesChart();
            LoadMonthlySalesChart();
            LoadCategorySalesChart();
            LoadTop5Chart();
        }

        private void LoadDailySalesChart()
        {
            chartDaily.Series.Clear();
            chartDaily.ChartAreas.Clear();

            ChartArea area = new ChartArea("DailyArea");
            chartDaily.ChartAreas.Add(area);

            Series series = new Series("일별 매출");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT TO_CHAR(sdate, 'YYYY-MM-DD') AS day,
                           SUM(total) AS sum_total
                    FROM pos_sales
                    WHERE NVL(status, '정상') <> '환불'
                    GROUP BY TO_CHAR(sdate, 'YYYY-MM-DD')
                    ORDER BY day
                ";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string day = dr["day"].ToString();
                    int total = Convert.ToInt32(dr["sum_total"]);

                    series.Points.AddXY(day, total);
                }
            }

            chartDaily.Series.Add(series);
        }

        private void LoadMonthlySalesChart()
        {
            chartMonthly.Series.Clear();
            chartMonthly.ChartAreas.Clear();

            ChartArea area = new ChartArea("MonthlyArea");
            chartMonthly.ChartAreas.Add(area);

            Series series = new Series("월별 매출");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT TO_CHAR(sdate, 'YYYY-MM') AS month,
                           SUM(total) AS sum_total
                    FROM pos_sales
                    WHERE NVL(status, '정상') <> '환불'
                    GROUP BY TO_CHAR(sdate, 'YYYY-MM')
                    ORDER BY month
                ";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string month = dr["month"].ToString();
                    int total = Convert.ToInt32(dr["sum_total"]);

                    series.Points.AddXY(month, total);
                }
            }

            chartMonthly.Series.Add(series);
        }

        private void LoadCategorySalesChart()
        {
            chartCategory.Series.Clear();
            chartCategory.ChartAreas.Clear();

            ChartArea area = new ChartArea("CategoryArea");
            chartCategory.ChartAreas.Add(area);

            Series series = new Series("카테고리별 매출");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT p.category AS category,
                           SUM(d.amount) AS total_amount
                    FROM pos_sales_detail d
                    JOIN product p ON d.pid = p.pid
                    JOIN pos_sales s ON s.sid = d.sid
                    WHERE NVL(s.status, '정상') <> '환불'
                    GROUP BY p.category
                    ORDER BY p.category
                ";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string category = dr["category"].ToString();
                    int total = Convert.ToInt32(dr["total_amount"]);

                    series.Points.AddXY(category, total);
                }
            }

            chartCategory.Series.Add(series);
        }

        private void LoadTop5Chart()
        {
            chartTop5.Series.Clear();
            chartTop5.ChartAreas.Clear();

            ChartArea area = new ChartArea("TopArea");
            chartTop5.ChartAreas.Add(area);

            Series series = new Series("TOP5");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            SELECT *
            FROM (
                SELECT p.pname AS name,
                       SUM(d.qty) AS qty
                FROM pos_sales_detail d
                JOIN pos_sales s ON s.sid = d.sid
                JOIN product p ON p.pid = d.pid
                WHERE NVL(s.status,'정상') <> '환불'
                GROUP BY p.pname
                ORDER BY qty DESC
            ) 
            WHERE ROWNUM <= 5
        ";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string name = dr["name"].ToString();
                    int qty = Convert.ToInt32(dr["qty"]);

                    series.Points.AddXY(name, qty);
                }
            }

            chartTop5.Series.Add(series);
        }


        private void lblTodaySales_Click(object sender, EventArgs e)
        {

        }

        private void LoadSummary()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                // 오늘 매출 합계
                OracleCommand cmdToday = new OracleCommand(
                    "SELECT NVL(SUM(total),0) FROM pos_sales WHERE TRUNC(sdate)=TRUNC(SYSDATE) AND NVL(status,'정상')<>'환불'",
                    conn);
                decimal todaySale = Convert.ToDecimal(cmdToday.ExecuteScalar());
                lblTodaySales.Text = $"오늘 매출: {todaySale:N0}원";

                // 오늘 판매 건수
                OracleCommand cmdTodayCnt = new OracleCommand(
                    "SELECT COUNT(*) FROM pos_sales WHERE TRUNC(sdate)=TRUNC(SYSDATE) AND NVL(status,'정상')<>'환불'",
                    conn);
                int todayCnt = Convert.ToInt32(cmdTodayCnt.ExecuteScalar());
                lblTodayCnt.Text = $"오늘 판매건수: {todayCnt}건";

                // 이번달 매출
                OracleCommand cmdMonth = new OracleCommand(
                    "SELECT NVL(SUM(total),0) FROM pos_sales WHERE TO_CHAR(sdate,'YYYY-MM') = TO_CHAR(SYSDATE,'YYYY-MM') AND NVL(status,'정상')<>'환불'",
                    conn);
                decimal monthSale = Convert.ToDecimal(cmdMonth.ExecuteScalar());
                lblMonthSales.Text = $"이번달 매출: {monthSale:N0}원";

                // 이번달 판매 건수
                OracleCommand cmdMonthCnt = new OracleCommand(
                    "SELECT COUNT(*) FROM pos_sales WHERE TO_CHAR(sdate,'YYYY-MM') = TO_CHAR(SYSDATE,'YYYY-MM') AND NVL(status,'정상')<>'환불'",
                    conn);
                int monthCnt = Convert.ToInt32(cmdMonthCnt.ExecuteScalar());
                lblMonthCnt.Text = $"이번달 판매건수: {monthCnt}건";

                // 총 매출
                OracleCommand cmdTotal = new OracleCommand(
                    "SELECT NVL(SUM(total),0) FROM pos_sales WHERE NVL(status,'정상')<>'환불'",
                    conn);
                decimal totalSale = Convert.ToDecimal(cmdTotal.ExecuteScalar());
                lblTotalSales.Text = $"총 매출: {totalSale:N0}원";
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSalesByPeriod(); 
            LoadDailySalesChart();
            LoadMonthlySalesChart();
            LoadCategorySalesChart();
            LoadTop5Chart();
            LoadSummary();
        }

        private void LoadSalesByPeriod()
        {
            lvStats.Items.Clear();

            DateTime startDate = dtStart.Value.Date;
            DateTime endDate = dtEnd.Value.Date.AddDays(1).AddSeconds(-1); // 날짜 포함 검색

            int totalCount = 0;
            int totalAmount = 0;

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                SELECT sid,
                       sdate,
                       total,
                       payment_method
                FROM pos_sales
                WHERE NVL(status, '정상') <> '환불'
                AND sdate BETWEEN :startDate AND :endDate
                ORDER BY sid DESC
            ";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":startDate", startDate);
                    cmd.Parameters.Add(":endDate", endDate);

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string sid = dr["sid"].ToString();
                        string day = Convert.ToDateTime(dr["sdate"]).ToString("yyyy-MM-dd HH:mm");
                        string total = dr["total"].ToString();
                        string method = dr["payment_method"].ToString();

                        ListViewItem item = new ListViewItem(sid);
                        item.SubItems.Add(day);
                        item.SubItems.Add(total);
                        item.SubItems.Add(method);

                        lvStats.Items.Add(item);

                        totalCount++;
                        totalAmount += int.Parse(total);
                    }
                }

                lblPeriodResult.Text = $"총 {totalCount}건, 매출 {totalAmount:N0}원";
            }
            catch (Exception ex)
            {
                MessageBox.Show("조회 오류: " + ex.Message);
            }
        }

    }
}
