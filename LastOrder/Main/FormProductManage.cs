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
using System.IO;

namespace Main
{
    public partial class FormProductManage : Form
    {
        private string connectionString =
            "User Id=pos; Password=1111;" +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        private string selectedImgPath = "";

        public FormProductManage()
        {
            InitializeComponent();
        }

        private void FormProductManage_Load(object sender, EventArgs e)
        {
            LoadProductList();
            LoadCategoryList();
        }
        private void LoadCategoryList()
        {
            cbCategory.Items.Clear();

            cbCategory.Items.AddRange(new string[]
            {
                "DRINK", "SNACK", "COLD", "BREAD", "RAMEN",
                "LUNCHBOX", "FROZEN", "ICECREAM", "ETC"
            });

            cbCategory.SelectedIndex = 0;
        }

        private void LoadProductList()
        {
            lvProduct.Items.Clear();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql =
                    "SELECT pid, pname, price, category, imgpath, eventinfo " +
                    "FROM product ORDER BY pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["pid"].ToString());
                    item.SubItems.Add(dr["pname"].ToString());
                    item.SubItems.Add(dr["price"].ToString());
                    item.SubItems.Add(dr["category"].ToString());
                    item.SubItems.Add(dr["imgpath"].ToString());
                    item.SubItems.Add(dr["eventinfo"].ToString());

                    lvProduct.Items.Add(item);
                }
            }
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvProduct.SelectedItems[0];

            txtName.Text = item.SubItems[1].Text;
            txtPrice.Text = item.SubItems[2].Text;
            cbCategory.Text = item.SubItems[3].Text;
            selectedImgPath = item.SubItems[4].Text;
            txtEvent.Text = item.SubItems[5].Text;

            if (File.Exists(selectedImgPath))
                picProduct.Image = Image.FromFile(selectedImgPath);
            else
                picProduct.Image = null;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedImgPath = dlg.FileName;
                picProduct.Image = Image.FromFile(selectedImgPath);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    INSERT INTO product (pid, pname, price, category, imgpath, eventinfo)
                    VALUES (
                        (SELECT NVL(MAX(pid), 1000) + 1 FROM product),
                        :name, :price, :category, :img, :event
                    )";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", txtName.Text);
                cmd.Parameters.Add(":price", int.Parse(txtPrice.Text));
                cmd.Parameters.Add(":category", cbCategory.Text);
                cmd.Parameters.Add(":img", selectedImgPath);
                cmd.Parameters.Add(":event", txtEvent.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("상품이 등록되었습니다!");
            }

            LoadProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 상품을 선택하세요.");
                return;
            }

            int pid = int.Parse(lvProduct.SelectedItems[0].Text);

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    UPDATE product
                    SET pname = :name,
                        price = :price,
                        category = :category,
                        imgpath = :img,
                        eventinfo = :event
                    WHERE pid = :pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", txtName.Text);
                cmd.Parameters.Add(":price", int.Parse(txtPrice.Text));
                cmd.Parameters.Add(":category", cbCategory.Text);
                cmd.Parameters.Add(":img", selectedImgPath);
                cmd.Parameters.Add(":event", txtEvent.Text);
                cmd.Parameters.Add(":pid", pid);

                cmd.ExecuteNonQuery();

                MessageBox.Show("상품 정보가 수정되었습니다!");
            }

            LoadProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 상품을 선택하세요.");
                return;
            }

            int pid = int.Parse(lvProduct.SelectedItems[0].Text);

            DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인",
                                                  MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM product WHERE pid = :pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":pid", pid);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("상품이 삭제되었습니다!");
            LoadProductList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }
    }
}
