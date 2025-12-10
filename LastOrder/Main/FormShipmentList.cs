using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Main
{
    public partial class FormShipmentList : Form
    {
        private string connectionString =
            "User Id=pos; Password=1111;" +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        public FormShipmentList()
        {
            InitializeComponent();
        }

        private void FormShipmentList_Load(object sender, EventArgs e)
        {
            cbFilter.Items.AddRange(new string[] { "전체", "미환불", "환불" });
            cbFilter.SelectedIndex = 0;

            LoadSalesList();
        }
        private void LoadSalesList()
        {
            listViewSales.Items.Clear();

            string filter = cbFilter.SelectedItem.ToString();
            string where = "";

            if (filter == "미환불")
                where = "WHERE status = '정상'";
            else if (filter == "환불")
                where = "WHERE status = '환불'";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string sql = $@"
                SELECT sid,
                       sdate,
                       total,
                       payment_method,
                       NVL(status, '미환불') AS status
                FROM pos_sales
                {where}
                ORDER BY sid DESC";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["sid"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(dr["sdate"]).ToString("yyyy-MM-dd HH:mm"));
                        item.SubItems.Add(dr["total"].ToString());
                        item.SubItems.Add(dr["payment_method"].ToString());
                        item.SubItems.Add(dr["status"].ToString());

                        listViewSales.Items.Add(item);
                    }
                }

                CalcSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("매출 조회 오류: " + ex.Message);
            }
        }

        private void CalcSummary()
        {
            int total = 0;
            int refund = 0;

            foreach (ListViewItem item in listViewSales.Items)
            {
                int money = int.Parse(item.SubItems[2].Text);
                string status = item.SubItems[4].Text;

                total += money;

                if (status == "환불")
                    refund += money;
            }

            int net = total - refund;

            lblTotal.Text = $"총 금액 : {total:#,##0}원";
            lblRefund.Text = $"환불 금액 : {refund:#,##0}원";
            lblNet.Text = $"순매출 : {net:#,##0}원";
        }

        private void listViewSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSales.SelectedItems.Count == 0)
                return;

            int sid = int.Parse(listViewSales.SelectedItems[0].Text);
            LoadSaleDetail(sid);
        }
        private void LoadSaleDetail(int sid)
        {
            listViewDetail.Items.Clear();

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "SELECT p.pname, d.qty, d.amount " +
                        "FROM pos_sales_detail d " +
                        "JOIN product p ON d.pid = p.pid " +
                        "WHERE d.sid = :sid";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":sid", sid);

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["pname"].ToString());
                        item.SubItems.Add(dr["qty"].ToString());
                        item.SubItems.Add(dr["amount"].ToString());

                        listViewDetail.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("상세 조회 오류: " + ex.Message);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSalesList();
        }
    }
}
