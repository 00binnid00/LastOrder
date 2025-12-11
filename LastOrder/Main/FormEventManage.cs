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
        private string connStr =
            "User Id=pos; Password=1111;" +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        private int selectedPid = -1;
        private int selectedEid = -1;
        private class EventInfo
        {
            public int Pid;
            public int Eid;
            public string EName;
            public string EType;
            public int DiscountValue;
            public int BuyQty;
            public int FreeQty;
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
            LoadEventList(txtSearch.Text.Trim());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void FormEventManage_Load(object sender, EventArgs e)
        {
            txtSearch.KeyDown += txtSearch_KeyDown;
            LoadEventList();
        }
        private void LoadEventList(string keyword = "")
        {
            lvEvent.Items.Clear();

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            p.pid,
                            p.pname,
                            p.price,
                            p.category,
                            e.eid,
                            e.ename,
                            e.etype,
                            e.discount_value,
                            e.buy_qty,
                            e.free_qty,
                            e.sdate,
                            e.edate,
                            e.description
                        FROM product p
                        LEFT JOIN pos_event e ON p.pid = e.pid
                        WHERE LOWER(p.pname) LIKE LOWER(:key)
                        ORDER BY p.pid";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":key", "%" + keyword + "%");

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int pid = Convert.ToInt32(dr["pid"]);
                        int eid = dr["eid"] == DBNull.Value ? -1 : Convert.ToInt32(dr["eid"]);

                        string pname = dr["pname"].ToString();
                        int price = Convert.ToInt32(dr["price"]);
                        string category = dr["category"].ToString();

                        string ename = dr["ename"] == DBNull.Value ? "" : dr["ename"].ToString();
                        string etype = dr["etype"] == DBNull.Value ? "" : dr["etype"].ToString();
                        int dval = dr["discount_value"] == DBNull.Value ? 0 : Convert.ToInt32(dr["discount_value"]);
                        int buy = dr["buy_qty"] == DBNull.Value ? 0 : Convert.ToInt32(dr["buy_qty"]);
                        int free = dr["free_qty"] == DBNull.Value ? 0 : Convert.ToInt32(dr["free_qty"]);
                        string desc = dr["description"] == DBNull.Value ? "" : dr["description"].ToString();

                        DateTime? sdate = dr["sdate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["sdate"]);
                        DateTime? edate = dr["edate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["edate"]);

                        string period = (sdate != null ? $"{sdate:yyyy-MM-dd} ~ {edate:yyyy-MM-dd}" : "이벤트 없음");

                        string displayType =
                            etype == "AMOUNT" ? $"정액 ({dval}원)" :
                            etype == "PERCENT" ? $"퍼센트 ({dval}%)" :
                            etype == "BUNDLE" ? $"묶음 ({buy}+{free})" : "";

                        // ListView에 보여줄 내용
                        ListViewItem item = new ListViewItem(pname);
                        item.SubItems.Add(price.ToString());
                        item.SubItems.Add(category);
                        item.SubItems.Add(ename);
                        item.SubItems.Add(displayType);
                        item.SubItems.Add(period);

                        // ★ 강타입 EventInfo를 Tag에 넣어둠
                        EventInfo info = new EventInfo
                        {
                            Pid = pid,
                            Eid = eid,
                            EName = ename,
                            EType = etype,
                            DiscountValue = dval,
                            BuyQty = buy,
                            FreeQty = free,
                            Description = desc,
                            StartDate = sdate,
                            EndDate = edate
                        };

                        item.Tag = info;

                        lvEvent.Items.Add(item);
                    }
                }

                selectedPid = -1;
                selectedEid = -1;
                lblSelectedProduct.Text = "(상품 미선택)";
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("이벤트 목록 로드 오류: " + ex.Message);
            }
        }

        private void ClearInput()
        {
            txtEventName.Text = "";
            txtDescription.Text = "";
            numDiscountValue.Value = 0;
            numBuy.Value = 1;
            numGet.Value = 1;
            rbAmount.Checked = false;
            rbPercent.Checked = false;
            rbBundle.Checked = false;
            dtStart.Value = DateTime.Today;
            dtEnd.Value = DateTime.Today;
        }

        private void lvEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEvent.SelectedItems.Count == 0) return;

            var tag = lvEvent.SelectedItems[0].Tag as EventInfo;
            if (tag == null) return;

            selectedPid = tag.Pid;
            selectedEid = tag.Eid;

            lblSelectedProduct.Text = lvEvent.SelectedItems[0].Text;   // 상품명

            txtEventName.Text = tag.EName;
            txtDescription.Text = tag.Description;

            numDiscountValue.Value = tag.DiscountValue;
            numBuy.Value = tag.BuyQty;
            numGet.Value = tag.FreeQty;

            rbAmount.Checked = (tag.EType == "AMOUNT");
            rbPercent.Checked = (tag.EType == "PERCENT");
            rbBundle.Checked = (tag.EType == "BUNDLE");

            if (tag.StartDate.HasValue) dtStart.Value = tag.StartDate.Value;
            if (tag.EndDate.HasValue) dtEnd.Value = tag.EndDate.Value;
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
                MessageBox.Show("상품을 먼저 선택하세요.");
                return;
            }

            string etype = GetDiscountType();
            if (etype == "")
            {
                MessageBox.Show("할인 유형을 선택하세요.");
                return;
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO pos_event (
                            eid, pid, ename, etype,
                            discount_value, buy_qty, free_qty,
                            description, sdate, edate
                        ) VALUES (
                            (SELECT NVL(MAX(eid),0)+1 FROM pos_event),
                            :pid, :ename, :etype,
                            :dval, :buy, :fqty,
                            :p_desc, :sdate, :edate
                        )";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":pid", selectedPid);
                    cmd.Parameters.Add(":ename", txtEventName.Text);
                    cmd.Parameters.Add(":etype", etype);
                    cmd.Parameters.Add(":dval", (int)numDiscountValue.Value);
                    cmd.Parameters.Add(":buy", (int)numBuy.Value);
                    cmd.Parameters.Add(":fqty", (int)numGet.Value);
                    cmd.Parameters.Add(":p_desc", txtDescription.Text);
                    cmd.Parameters.Add(":sdate", dtStart.Value);
                    cmd.Parameters.Add(":edate", dtEnd.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("이벤트가 등록되었습니다.");
                LoadEventList(txtSearch.Text.Trim());
            }
            catch (OracleException ox)
            {
                MessageBox.Show("이벤트 등록 오류: " + ox.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("이벤트 등록 오류: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEid == -1)
            {
                MessageBox.Show("수정할 이벤트를 선택하세요.");
                return;
            }

            string etype = GetDiscountType();
            if (etype == "")
            {
                MessageBox.Show("할인 유형을 선택하세요.");
                return;
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    string sql = @"
                        UPDATE pos_event
                        SET ename = :ename,
                            etype = :etype,
                            discount_value = :dval,
                            buy_qty = :buy,
                            free_qty = :fqty,
                            description = :p_desc,
                            sdate = :sdate,
                            edate = :edate
                        WHERE eid = :eid";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":ename", txtEventName.Text);
                    cmd.Parameters.Add(":etype", etype);
                    cmd.Parameters.Add(":dval", (int)numDiscountValue.Value);
                    cmd.Parameters.Add(":buy", (int)numBuy.Value);
                    cmd.Parameters.Add(":fqty", (int)numGet.Value);
                    cmd.Parameters.Add(":p_desc", txtDescription.Text);
                    cmd.Parameters.Add(":sdate", dtStart.Value);
                    cmd.Parameters.Add(":edate", dtEnd.Value);
                    cmd.Parameters.Add(":eid", selectedEid);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("이벤트가 수정되었습니다.");
                LoadEventList(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("이벤트 수정 오류: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEid == -1)
            {
                MessageBox.Show("삭제할 이벤트를 선택하세요.");
                return;
            }

            if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    string sql = "DELETE FROM pos_event WHERE eid = :eid";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":eid", selectedEid);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("이벤트가 삭제되었습니다.");
                LoadEventList(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("이벤트 삭제 오류: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadEventList();
        }
    }
}
