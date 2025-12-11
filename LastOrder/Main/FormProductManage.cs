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
        private int selectedPid = -1;

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

                // ※ 이벤트 정보 포함 JOIN
                string sql = @"
                    SELECT 
                        p.pid,
                        p.pname,
                        p.price,
                        p.category,
                        p.imgpath,
                        NVL(e.ename, '') AS eventinfo
                    FROM product p
                    LEFT JOIN pos_event e ON p.pid = e.pid
                    ORDER BY p.pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["pid"].ToString());
                    item.SubItems.Add(dr["pname"].ToString());
                    item.SubItems.Add(dr["price"].ToString());
                    item.SubItems.Add(dr["category"].ToString());
                    item.SubItems.Add(dr["imgpath"].ToString());
                    item.SubItems.Add(dr["eventinfo"].ToString());  // 추가

                    lvProduct.Items.Add(item);
                }
            }
        }
        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0)
            {
                selectedPid = -1;
                return;
            }

            ListViewItem item = lvProduct.SelectedItems[0];
            selectedPid = int.Parse(item.SubItems[0].Text);

            txtName.Text = item.SubItems[1].Text;
            txtPrice.Text = item.SubItems[2].Text;
            cbCategory.Text = item.SubItems[3].Text;

            selectedImgPath = item.SubItems[4].Text;

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
                    INSERT INTO product
                        (pid, pname, price, stock, category, imgpath, eventinfo)
                    VALUES (
                        (SELECT NVL(MAX(pid),1000)+1 FROM product),
                        :name, :price, 0, :category, :img, NULL
                    )";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", txtName.Text);
                cmd.Parameters.Add(":price", int.Parse(txtPrice.Text));
                cmd.Parameters.Add(":category", cbCategory.Text);
                cmd.Parameters.Add(":img", selectedImgPath);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("상품이 추가되었습니다.");
            LoadProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPid == -1)
            {
                MessageBox.Show("수정할 상품을 선택하세요.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    UPDATE product
                    SET pname = :name,
                        price = :price,
                        category = :category,
                        imgpath = :img
                    WHERE pid = :pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", txtName.Text);
                cmd.Parameters.Add(":price", int.Parse(txtPrice.Text));
                cmd.Parameters.Add(":category", cbCategory.Text);
                cmd.Parameters.Add(":img", selectedImgPath);
                cmd.Parameters.Add(":pid", selectedPid);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("상품이 수정되었습니다.");
            LoadProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPid == -1)
            {
                MessageBox.Show("삭제할 상품을 선택하세요.");
                return;
            }

            if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo)
                != DialogResult.Yes)
                return;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                // 먼저 이벤트 삭제 (FK 문제 방지)
                string sqlEvent = "DELETE FROM pos_event WHERE pid = :pid";
                OracleCommand cmdEvent = new OracleCommand(sqlEvent, conn);
                cmdEvent.Parameters.Add(":pid", selectedPid);
                cmdEvent.ExecuteNonQuery();

                // 상품 삭제
                string sql = "DELETE FROM product WHERE pid = :pid";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":pid", selectedPid);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("상품이 삭제되었습니다.");
            LoadProductList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }
    }
}
