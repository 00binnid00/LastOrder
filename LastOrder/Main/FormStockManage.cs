using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;

namespace Main
{
    public partial class FormStockManage : Form
    {
        private string connectionString =
            "User Id=pos; Password=1111;" +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        public FormStockManage()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadProductList();
            LoadCategoryList();
        }

        private void LoadCategoryList()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("DRINK");
            cmbCategory.Items.Add("SNACK");
            cmbCategory.Items.Add("BREAD");
            cmbCategory.Items.Add("RAMEN");
            cmbCategory.Items.Add("LUNCHBOX");
            cmbCategory.Items.Add("COLD");
            cmbCategory.Items.Add("FROZEN");
            cmbCategory.Items.Add("ICECREAM");
            cmbCategory.Items.Add("ETC");

            cmbCategory.SelectedIndex = 0;
        }



        private void LoadProductList()
        {
            listViewProduct.Items.Clear();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT pid, pname, price, stock, category FROM product ORDER BY pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["pid"].ToString());
                    item.SubItems.Add(dr["pname"].ToString());
                    item.SubItems.Add(dr["price"].ToString());
                    item.SubItems.Add(dr["stock"].ToString());
                    item.SubItems.Add(dr["category"].ToString());

                    listViewProduct.Items.Add(item);
                }
            }
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
                return;

            var item = listViewProduct.SelectedItems[0];

            txtName.Text = item.SubItems[1].Text;
            txtPrice.Text = item.SubItems[2].Text;
            txtStock.Text = item.SubItems[3].Text;
            cmbCategory.Text = item.SubItems[4].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pname = txtName.Text.Trim();
            string category = cmbCategory.Text;
            int price, stock;

            if (pname == "" || !int.TryParse(txtPrice.Text, out price) || !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("상품명 / 가격 / 재고를 정확히 입력하세요.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string checkSql = "SELECT pid, stock FROM product WHERE pname = :pname";
                OracleCommand checkCmd = new OracleCommand(checkSql, conn);
                checkCmd.Parameters.Add(":pname", pname);

                OracleDataReader dr = checkCmd.ExecuteReader();

                if (dr.Read())
                {
                    int existingPid = Convert.ToInt32(dr["pid"]);
                    int existingStock = Convert.ToInt32(dr["stock"]);
                    dr.Close();

                    string updateSql = "UPDATE product SET stock = stock + :addStock WHERE pid = :pid";
                    OracleCommand updateCmd = new OracleCommand(updateSql, conn);
                    updateCmd.Parameters.Add(":addStock", stock);
                    updateCmd.Parameters.Add(":pid", existingPid);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show($"이미 존재하는 상품입니다.\n재고가 {existingStock} → {existingStock + stock} 으로 변경되었습니다.");
                }
                else
                {
                    dr.Close();

                    string getPidSql = "SELECT NVL(MAX(pid), 1000) + 1 FROM product";
                    OracleCommand getPidCmd = new OracleCommand(getPidSql, conn);
                    int newPid = Convert.ToInt32(getPidCmd.ExecuteScalar());

                    string insertSql =
                        "INSERT INTO product (pid, pname, price, stock, category) VALUES (:pid, :pname, :price, :stock, :category)";
                    OracleCommand insertCmd = new OracleCommand(insertSql, conn);
                    insertCmd.Parameters.Add(":pid", newPid);
                    insertCmd.Parameters.Add(":pname", pname);
                    insertCmd.Parameters.Add(":price", price);
                    insertCmd.Parameters.Add(":stock", stock);
                    insertCmd.Parameters.Add(":category", category);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("새 상품이 추가되었습니다!");
                }
            }

            LoadProductList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 상품을 선택하세요.");
                return;
            }

            int pid = int.Parse(listViewProduct.SelectedItems[0].SubItems[0].Text);

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql =
                    "UPDATE product SET pname=:name, price=:price, stock=:stock, category=:cat WHERE pid=:pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", txtName.Text);
                cmd.Parameters.Add(":price", int.Parse(txtPrice.Text));
                cmd.Parameters.Add(":stock", int.Parse(txtStock.Text));
                cmd.Parameters.Add(":cat", cmbCategory.Text);
                cmd.Parameters.Add(":pid", pid);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("상품이 수정되었습니다.");
            LoadProductList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 상품을 선택하세요.");
                return;
            }

            int pid = int.Parse(listViewProduct.SelectedItems[0].SubItems[0].Text);

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM product WHERE pid=:pid";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":pid", pid);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("상품이 삭제되었습니다.");
            LoadProductList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }
    }
}
