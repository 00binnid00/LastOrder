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
    public partial class FormEventManage : Form
    {
        private string connectionString =
            "User Id=pos; Password=1111;" +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        private int selectedPid = -1;
        private int selectedEid = -1;

        private int ParseIntFromTextBox(TextBox tb)
        {
            if (int.TryParse(tb.Text.Trim(), out int v))
                return v;
            return 0;
        }

        private class EventInfo
        {
            public int Pid;
            public int Eid;
            public string EventName;
            public string DiscountType;
            public int DiscountValue;
            public int BundleBuy;
            public int BundleGet;
            public string Description;
            public DateTime? StartDate;
            public DateTime? EndDate;
        }


        public FormEventManage()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            LoadProductEventList(keyword);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void FormEventManage_Load(object sender, EventArgs e)
        {
            txtSearch.KeyDown += txtSearch_KeyDown;

            LoadProductEventList();
        }
        private void LoadProductEventList(string keyword = "")
        {
            lvEvent.Items.Clear();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        p.pid,
                        p.pname,
                        p.price,
                        p.category,
                        e.eid,
                        e.event_name,
                        e.discount_type,
                        e.discount_value,
                        e.bundle_buy,
                        e.bundle_get,
                        e.description,
                        e.start_date,
                        e.end_date
                    FROM product p
                    LEFT JOIN event e
                      ON p.pid = e.pid
                    WHERE LOWER(p.pname) LIKE LOWER(:kw)
                    ORDER BY p.pid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":kw", "%" + keyword + "%");

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int pid = Convert.ToInt32(dr["pid"]);
                    string pname = dr["pname"].ToString();
                    int price = Convert.ToInt32(dr["price"]);
                    string category = dr["category"].ToString();

                    int eid = dr["eid"] == DBNull.Value ? -1 : Convert.ToInt32(dr["eid"]);
                    string eventName = dr["event_name"] == DBNull.Value ? "" : dr["event_name"].ToString();
                    string discountType = dr["discount_type"] == DBNull.Value ? "" : dr["discount_type"].ToString();
                    int discountValue = dr["discount_value"] == DBNull.Value ? 0 : Convert.ToInt32(dr["discount_value"]);
                    int bundleBuy = dr["bundle_buy"] == DBNull.Value ? 0 : Convert.ToInt32(dr["bundle_buy"]);
                    int bundleGet = dr["bundle_get"] == DBNull.Value ? 0 : Convert.ToInt32(dr["bundle_get"]);
                    string desc = dr["description"] == DBNull.Value ? "" : dr["description"].ToString();

                    DateTime? startDate = null;
                    DateTime? endDate = null;
                    string period = "";

                    if (dr["start_date"] != DBNull.Value)
                    {
                        startDate = Convert.ToDateTime(dr["start_date"]);
                        endDate = Convert.ToDateTime(dr["end_date"]);
                        period = $"{startDate:yyyy-MM-dd} ~ {endDate:yyyy-MM-dd}";
                    }

                    string displayType = "";
                    if (discountType == "AMOUNT")
                        displayType = $"금액 ({discountValue}원)";
                    else if (discountType == "PERCENT")
                        displayType = $"퍼센트 ({discountValue}%)";
                    else if (discountType == "BUNDLE")
                        displayType = $"묶음 ({bundleBuy}+{bundleGet})";

                    ListViewItem item = new ListViewItem(pname);
                    item.SubItems.Add(price.ToString());
                    item.SubItems.Add(category);
                    item.SubItems.Add(eventName);
                    item.SubItems.Add(displayType);
                    item.SubItems.Add(period); 

                    item.Tag = new EventInfo
                    {
                        Pid = pid,
                        Eid = eid,
                        EventName = eventName,
                        DiscountType = discountType,
                        DiscountValue = discountValue,
                        BundleBuy = bundleBuy,
                        BundleGet = bundleGet,
                        Description = desc,
                        StartDate = startDate,
                        EndDate = endDate
                    };

                    lvEvent.Items.Add(item);
                }
            }
            selectedPid = -1;
            selectedEid = -1;
            lblSelectedProduct.Text = "(상품 미선택)";
            ClearInput();
        }

        private void ClearInput()
        {
            txtEventName.Text = "";
            txtDescription.Text = "";
            numDiscountValue.Text = "0";
            numBuy.Text = "0";
            numGet.Text = "0";
            rbAmount.Checked = false;
            rbPercent.Checked = false;
            rbBundle.Checked = false;
            dtStart.Value = DateTime.Today;
            dtEnd.Value = DateTime.Today;
        }

        private void lvEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEvent.SelectedItems.Count == 0)
                return;

            var item = lvEvent.SelectedItems[0];
            lblSelectedProduct.Text = item.SubItems[0].Text;

            if (item.Tag is EventInfo info)
            {
                selectedPid = info.Pid;
                selectedEid = info.Eid;

                txtEventName.Text = info.EventName ?? "";
                txtDescription.Text = info.Description ?? "";

                numDiscountValue.Text = info.DiscountValue.ToString();
                numBuy.Text = info.BundleBuy.ToString();
                numGet.Text = info.BundleGet.ToString();

                rbAmount.Checked = (info.DiscountType == "AMOUNT");
                rbPercent.Checked = (info.DiscountType == "PERCENT");
                rbBundle.Checked = (info.DiscountType == "BUNDLE");

                if (info.StartDate.HasValue) dtStart.Value = info.StartDate.Value;
                if (info.EndDate.HasValue) dtEnd.Value = info.EndDate.Value;
            }
            else
            {
                selectedPid = -1;
                selectedEid = -1;
            }
        }
        private string GetDiscountType()
        {
            if (rbAmount.Checked) return "AMOUNT";
            if (rbPercent.Checked) return "PERCENT";
            if (rbBundle.Checked) return "BUNDLE";
            return "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedPid == -1)
            {
                MessageBox.Show("이벤트를 등록할 상품을 먼저 선택하세요.");
                return;
            }

            string dtype = GetDiscountType();
            if (dtype == "")
            {
                MessageBox.Show("할인 유형을 선택하세요.");
                return;
            }

            int discountValue = (int)numDiscountValue.Value;
            int buy = (int)numBuy.Value;
            int get = (int)numGet.Value;

            if (dtype == "BUNDLE" && (buy <= 0 || get <= 0))
            {
                MessageBox.Show("묶음할인(1+1, 2+1 등)은 구매/무료 개수를 입력하세요.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    INSERT INTO event (
                        eid, pid, event_name, discount_type,
                        discount_value, bundle_buy, bundle_get,
                        description, start_date, end_date
                    ) VALUES (
                        (SELECT NVL(MAX(eid),0) + 1 FROM event),
                        :pid, :name, :dtype,
                        :dvalue, :buy, :get,
                        :desc, :sdate, :edate
                    )";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":pid", selectedPid);
                cmd.Parameters.Add(":name", txtEventName.Text);
                cmd.Parameters.Add(":dtype", dtype);
                cmd.Parameters.Add(":dvalue", discountValue);
                cmd.Parameters.Add(":buy", buy);
                cmd.Parameters.Add(":get", get);
                cmd.Parameters.Add(":desc", txtDescription.Text);
                cmd.Parameters.Add(":sdate", dtStart.Value);
                cmd.Parameters.Add(":edate", dtEnd.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("이벤트가 등록되었습니다.");
            LoadProductEventList(txtSearch.Text.Trim());
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (selectedEid == -1)
            {
                MessageBox.Show("수정할 이벤트가 선택되지 않았습니다.");
                return;
            }

            string dtype = GetDiscountType();
            if (dtype == "")
            {
                MessageBox.Show("할인 유형을 선택하세요.");
                return;
            }

            int discountValue = (int)numDiscountValue.Value;
            int buy = (int)numBuy.Value;
            int get = (int)numGet.Value;

            if (dtype == "BUNDLE" && (buy <= 0 || get <= 0))
            {
                MessageBox.Show("묶음할인(1+1, 2+1 등)은 구매/무료 개수를 입력하세요.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                    UPDATE event
                    SET event_name    = :name,
                        discount_type = :dtype,
                        discount_value= :dvalue,
                        bundle_buy    = :buy,
                        bundle_get    = :get,
                        description   = :desc,
                        start_date    = :sdate,
                        end_date      = :edate
                    WHERE eid = :eid";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":name", txtEventName.Text);
                cmd.Parameters.Add(":dtype", dtype);
                cmd.Parameters.Add(":dvalue", discountValue);
                cmd.Parameters.Add(":buy", buy);
                cmd.Parameters.Add(":get", get);
                cmd.Parameters.Add(":desc", txtDescription.Text);
                cmd.Parameters.Add(":sdate", dtStart.Value);
                cmd.Parameters.Add(":edate", dtEnd.Value);
                cmd.Parameters.Add(":eid", selectedEid);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("이벤트가 수정되었습니다.");
            LoadProductEventList(txtSearch.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEid == -1)
            {
                MessageBox.Show("삭제할 이벤트가 선택되지 않았습니다.");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "정말 이 이벤트를 삭제하시겠습니까?",
                "이벤트 삭제",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM event WHERE eid = :eid";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":eid", selectedEid);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("이벤트가 삭제되었습니다.");
            LoadProductEventList(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadProductEventList();
        }
    }
}
