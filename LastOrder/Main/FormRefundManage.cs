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
    public partial class FormRefundManage : Form
    {
        private string connectionString = "User Id=pos; Password=1111;" + "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
        public FormRefundManage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadSalesList();
        }
        private void LoadSalesList()
        {
            listViewSales.Items.Clear();

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
                        ORDER BY sid DESC";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string sid = dr["sid"].ToString();
                        string sdate = Convert.ToDateTime(dr["sdate"]).ToString("yyyy-MM-dd HH:mm");
                        string total = dr["total"].ToString();
                        string method = dr["payment_method"].ToString(); 

                        ListViewItem item = new ListViewItem(sid);
                        item.SubItems.Add(sdate);
                        item.SubItems.Add(total);
                        item.SubItems.Add(method);

                        listViewSales.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("매출 조회 오류: " + ex.Message);
            }
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
                        "SELECT p.pname AS pname, d.qty AS qty, d.amount AS amount " +
                        "FROM pos_sales_detail d " +
                        "JOIN product p ON d.pid = p.pid " +
                        "WHERE d.sid = :sid";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":sid", sid);

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string name = dr["PNAME"].ToString();
                        string qty = dr["QTY"].ToString();
                        string amount = dr["AMOUNT"].ToString();

                        ListViewItem item = new ListViewItem(name);
                        item.SubItems.Add(qty);
                        item.SubItems.Add(amount);

                        listViewDetail.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("상세 조회 오류: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewSales.SelectedItems.Count == 0)
            {
                MessageBox.Show("환불할 매출을 선택하세요.");
                return;
            }

            int sid = int.Parse(listViewSales.SelectedItems[0].SubItems[0].Text);

            DialogResult dr = MessageBox.Show(
                $"매출번호 {sid}를 환불 처리하시겠습니까?",
                "환불 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // 1) 상세 읽기 (재고 복구)
                    string getDetails =
                        "SELECT pid, qty FROM pos_sales_detail WHERE sid = :sid";

                    OracleCommand cmd = new OracleCommand(getDetails, conn);
                    cmd.Parameters.Add(":sid", sid);
                    OracleDataReader reader = cmd.ExecuteReader();

                    List<(int pid, int qty)> items = new List<(int, int)>();

                    while (reader.Read())
                    {
                        items.Add((
                            Convert.ToInt32(reader["pid"]),
                            Convert.ToInt32(reader["qty"])
                        ));
                    }
                    reader.Close();

                    // 2) 재고 복구
                    foreach (var item in items)
                    {
                        string updateStock =
                            "UPDATE product SET stock = stock + :qty WHERE pid = :pid";

                        OracleCommand cmd2 = new OracleCommand(updateStock, conn);
                        cmd2.Parameters.Add(":qty", item.qty);
                        cmd2.Parameters.Add(":pid", item.pid);
                        cmd2.ExecuteNonQuery();
                    }

                    // 3) 환불 상태 업데이트
                    string updateStatus =
                        "UPDATE pos_sales SET status = '환불' WHERE sid = :sid";

                    OracleCommand cmd3 = new OracleCommand(updateStatus, conn);
                    cmd3.Parameters.Add(":sid", sid);
                    cmd3.ExecuteNonQuery();
                }

                MessageBox.Show($"매출번호 {sid} 환불 완료!");

                LoadSalesList();   // 전체 새로고침
                listViewDetail.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("환불 처리 오류: " + ex.Message);
            }
        }
    }
}
