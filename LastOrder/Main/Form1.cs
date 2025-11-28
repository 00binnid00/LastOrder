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
    public partial class Form1 : Form
    {
        private string connectionString = "User Id=pos; Password=1111; " + "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
        private int totalAmount = 0;
        public Form1()
        {
            InitializeComponent();
            SetupListViews();
        }
        private void SetupListViews()
        {
            listViewProduct.View = View.Details;
            listViewProduct.FullRowSelect = true;
            listViewProduct.GridLines = true;
            listViewProduct.Columns.Clear();
            listViewProduct.Columns.Add("상품명", 150);
            listViewProduct.Columns.Add("가격", 80);
            listViewProduct.Columns.Add("재고", 80);

            listViewCart.View = View.Details;
            listViewCart.FullRowSelect = true;
            listViewCart.GridLines = true;
            listViewCart.Columns.Clear();
            listViewCart.Columns.Add("상품명", 150);
            listViewCart.Columns.Add("수량", 60);
            listViewCart.Columns.Add("금액", 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string category = null)
        {
            listViewProduct.Items.Clear();

            string sql = "SELECT PID, PNAME, PRICE, STOCK, CATEGORY FROM PRODUCT";

            if (category != null)
                sql += " WHERE CATEGORY = :cat";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    if (category != null)
                        cmd.Parameters.Add(":cat", category);

                    conn.Open();
                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string pname = dr["PNAME"].ToString();
                            int price = Convert.ToInt32(dr["PRICE"]);
                            int stock = Convert.ToInt32(dr["STOCK"]);
                            string pid = dr["PID"].ToString();

                            ListViewItem item = new ListViewItem(pname);
                            item.SubItems.Add(price.ToString());
                            item.SubItems.Add(stock.ToString());
                            item.Tag = pid;

                            listViewProduct.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("상품 조회 오류: " + ex.Message);
            }
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            LoadProducts("DRINK");
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            LoadProducts("SNACK");
        }

        private void btnCold_Click(object sender, EventArgs e)
        {
            LoadProducts("COLD");
        }

        private void btnEtc_Click(object sender, EventArgs e)
        {
            LoadProducts("ETC");
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택된 상품이 없습니다.");
                return;
            }

            ListViewItem selected = listViewProduct.SelectedItems[0];

            string name = selected.SubItems[0].Text;
            int price = int.Parse(selected.SubItems[1].Text);
            int stock = int.Parse(selected.SubItems[2].Text);

            int qty = (int)numQty.Value;

            if (qty > stock)
            {
                MessageBox.Show("재고 부족!");
                return;
            }

            int lineTotal = price * qty;

            ListViewItem cartItem = new ListViewItem(name);
            cartItem.SubItems.Add(qty.ToString());
            cartItem.SubItems.Add(lineTotal.ToString());

            listViewCart.Items.Add(cartItem);

            totalAmount += lineTotal;
            lblTotal.Text = "총 금액: " + totalAmount + "원";

            selected.SubItems[2].Text = (stock - qty).ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (listViewCart.Items.Count == 0)
            {
                MessageBox.Show("장바구니가 비어 있습니다.");
                return;
            }

            MessageBox.Show($"결제 완료!\n총 금액: {totalAmount}원");

            listViewCart.Items.Clear();
            totalAmount = 0;
            lblTotal.Text = "총 금액: 0원";
        }
    }
}
