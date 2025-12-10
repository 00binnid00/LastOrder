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
    public partial class FormSaleManage : Form
    {
        private string connectionString = "User Id=pos; Password=1111; " + "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
        private string currentCategory = "전체";
        private ListViewItem selectedItem = null;

        public FormSaleManage()
        {
            InitializeComponent();
        }

        private void LoadProducts(string category = "전체")
        {
            lvProduct.Items.Clear();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql;

                if (category == "ALL")
                {
                    sql = "SELECT pid, pname, price, stock, category FROM product ORDER BY pid";
                }
                else
                {
                    sql = "SELECT pid, pname, price, stock, category FROM product WHERE category = :cat ORDER BY pid";
                }

                OracleCommand cmd = new OracleCommand(sql, conn);

                if (category != "ALL")
                    cmd.Parameters.Add(":cat", category);

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["pname"].ToString());
                    item.SubItems.Add(dr["price"].ToString());
                    item.SubItems.Add(dr["stock"].ToString());
                    item.SubItems.Add(dr["pid"].ToString());
                    item.SubItems.Add(dr["category"].ToString());

                    lvProduct.Items.Add(item);
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void UpdateTotal()
        {
            int sum = 0;

            foreach (ListViewItem item in lvCart.Items)
                sum += int.Parse(item.SubItems[2].Text);

            lblTotal.Text = sum + "원";
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                MessageBox.Show("상품을 선택하세요.");
                return;
            }

            string pname = selectedItem.SubItems[0].Text;
            int price = int.Parse(selectedItem.SubItems[1].Text);
            int stock = int.Parse(selectedItem.SubItems[2].Text);

            int qty = int.Parse(numQty.Text);

            if (qty > stock)
            {
                MessageBox.Show("재고가 부족합니다.");
                return;
            }

            int amount = price * qty;

            foreach (ListViewItem item in lvCart.Items)
            {
                if (item.SubItems[0].Text == pname)
                {
                    int oldQty = int.Parse(item.SubItems[1].Text);
                    int newQty = oldQty + qty;

                    int oldAmount = int.Parse(item.SubItems[2].Text);
                    int newAmount = oldAmount + amount;

                    item.SubItems[1].Text = newQty.ToString();
                    item.SubItems[2].Text = newAmount.ToString();

                    CalcTotal();
                    return;
                }
            }
            ListViewItem cartItem = new ListViewItem(pname);
            cartItem.SubItems.Add(qty.ToString());
            cartItem.SubItems.Add(amount.ToString());

            lvCart.Items.Add(cartItem);

            CalcTotal();
        }
        private void CalcTotal()
        {
            int total = 0;

            foreach (ListViewItem item in lvCart.Items)
                total += int.Parse(item.SubItems[2].Text);

            lblTotal.Text = $"총 금액 : {total}원";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lvCart.Items.Count == 0)
            {
                MessageBox.Show("장바구니가 비어있습니다.");
                return;
            }

            if (lblTotal.Text.Contains($"총 금액 : 0원"))
            {
                MessageBox.Show("결제 금액이 0원은 결제할 수 없습니다.");
                return;
            }

            FormMain main = (FormMain)this.MdiParent;

            string totalPrice = lblTotal.Text;
            ListView orderList = lvCart;

            FormPay payForm = new FormPay(this, orderList, totalPrice);
            payForm.MdiParent = main;
            payForm.Show();
        }

        public void ResetPOS()
        {
            lvCart.Items.Clear();
            lblTotal.Text = $"총 금액 : 0원";
            numQty.Text = "1";

        }


        private void lblTotal_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            LoadProducts("DRINK");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LoadProducts("ALL");
        }

        private void btnCategorySnack_Click(object sender, EventArgs e)
        {
            LoadProducts("SNACK");
        }

        private void btnCategoryCold_Click(object sender, EventArgs e)
        {
            LoadProducts("COLD");
        }

        private void btnCategoryEtc_Click(object sender, EventArgs e)
        {
            LoadProducts("ETC");
        }

        private void btnCategoryBread_Click(object sender, EventArgs e)
        {
            LoadProducts("BREAD");
        }

        private void btnCategoryRamen_Click(object sender, EventArgs e)
        {
            LoadProducts("RAMEN");
        }

        private void btnCategoryLunch_Click(object sender, EventArgs e)
        {
            LoadProducts("LUNCHBOX");
        }

        private void btnCategoryFrozen_Click(object sender, EventArgs e)
        {
            LoadProducts("FROZEN");
        }

        private void btnCategoryIcecream_Click(object sender, EventArgs e)
        {
            LoadProducts("ICECREAM");
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count > 0)
            {
                selectedItem = lvProduct.SelectedItems[0];
            }
        }

        private void lvProduct_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0) return;

            var item = lvProduct.SelectedItems[0];

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }

            lvCart.Items.Remove(lvCart.SelectedItems[0]);
            UpdateTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvCart.Items.Clear();
            lblTotal.Text = "0원";
        }
    }
}
