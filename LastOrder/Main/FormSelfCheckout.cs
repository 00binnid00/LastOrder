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
    public partial class FormSelfCheckout : Form
    {
        private List<CartItem> cartItems = new List<CartItem>();
        private int totalPrice = 0;

        private string connStr =
            "User Id=pos; Password=1111;" +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        public FormSelfCheckout()
        {
            InitializeComponent();
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0) return;
            var item = lvProduct.SelectedItems[0];
            AddToCart(item);
        }

        private void FormSelfCheckout_Load(object sender, EventArgs e)
        {
            LoadProducts("ALL");
            LoadCart();
        }

        private void LoadProducts(string category = "ALL")
        {
            lvProduct.Items.Clear();

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                string sql;

                if (category == "ALL")
                    sql = "SELECT pid, pname, price, stock, category FROM product ORDER BY pid";
                else
                    sql = "SELECT pid, pname, price, stock, category FROM product WHERE category = :cat ORDER BY pid";

                OracleCommand cmd = new OracleCommand(sql, conn);

                if (category != "ALL")
                    cmd.Parameters.Add(":cat", category);

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["pid"].ToString());
                    item.SubItems.Add(dr["pname"].ToString());
                    item.SubItems.Add(dr["price"].ToString());
                    item.SubItems.Add(dr["stock"].ToString());
                    item.SubItems.Add(dr["category"].ToString());

                    lvProduct.Items.Add(item);
                }
            }
        }


        private void AddToCart(ListViewItem item)
        {
            int pid = int.Parse(item.SubItems[0].Text);
            string pname = item.SubItems[1].Text;
            int price = int.Parse(item.SubItems[2].Text);

            // 기존 상품이면 수량 +1
            foreach (var c in cartItems)
            {
                if (c.PID == pid)
                {
                    c.Quantity++;
                    LoadCart();
                    return;
                }
            }

            // 신규 상품 추가
            cartItems.Add(new CartItem
            {
                PID = pid,
                PName = pname,
                Price = price,
                Quantity = 1
            });

            LoadCart();
        }
        private void LoadCart()
        {
            lvCart.Items.Clear();
            totalPrice = 0;

            foreach (var c in cartItems)
            {
                ListViewItem item = new ListViewItem(c.PName);
                item.SubItems.Add(c.Quantity.ToString());
                item.SubItems.Add(c.Amount.ToString());

                lvCart.Items.Add(item);
                totalPrice += c.Amount;
            }

            lblTotal.Text = totalPrice + "원";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count == 0) return;

            int index = lvCart.SelectedItems[0].Index;
            cartItems[index].Quantity++;

            LoadCart();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count == 0) return;

            int index = lvCart.SelectedItems[0].Index;

            if (cartItems[index].Quantity <= 1)
                cartItems.RemoveAt(index);
            else
                cartItems[index].Quantity--;

            LoadCart();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count == 0) return;

            int index = lvCart.SelectedItems[0].Index;
            cartItems.RemoveAt(index);

            LoadCart(); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            LoadCart();
        }

        public class CartItem
        {
            public int PID { get; set; }       // 상품코드
            public string PName { get; set; }  // 상품명
            public int Price { get; set; }     // 단가
            public int Quantity { get; set; }  // 수량

            public int Amount => Price * Quantity;  // 금액 = 단가 * 수량
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("장바구니가 비어 있습니다.");
                return;
            }

            FormPay fp = new FormPay(cartItems, totalPrice);
            fp.ShowDialog();

            if (fp.PaymentCompleted)
            {
                cartItems.Clear();
                LoadCart();
            }
        }


        private void btnCategoryDrink_Click(object sender, EventArgs e)
        {
            LoadProducts("DRINK");
        }

        private void btnCategorySnack_Click(object sender, EventArgs e)
        {
            LoadProducts("SNACK");
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

        private void btnCategoryCold_Click(object sender, EventArgs e)
        {
            LoadProducts("COLD");
        }

        private void btnCategoryFrozen_Click(object sender, EventArgs e)
        {
            LoadProducts("FROZEN");
        }

        private void btnCategoryIcecream_Click(object sender, EventArgs e)
        {
            LoadProducts("ICECREAM");
        }

        private void btnCategoryEtc_Click(object sender, EventArgs e)
        {
            LoadProducts("ETC");
        }

        private void btnCategoryAll_Click(object sender, EventArgs e)
        {
            LoadProducts("ALL");
        }

        private void 관리자모드로전환ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminLogin login = new FormAdminLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                FormMain main = new FormMain();
                main.Show();
                this.Close();
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
