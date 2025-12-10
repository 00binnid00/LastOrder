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
    public partial class FormPay : Form
    {
        private FormSaleManage mainForm;
        private ListView cartData;
        private string totalText;
        private int totalAmount;
        private string connectionString = "User Id = pos; Password = 1111; " + "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";

        public FormPay(FormSaleManage form, ListView cart, string total)
        {
            InitializeComponent();

            mainForm = form;
            cartData = cart;
            totalText = total;

            string onlyNumber = new string(total.Where(char.IsDigit).ToArray());
            totalAmount = int.Parse(onlyNumber);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelTotal.Text = totalText;

            foreach (ListViewItem item in cartData.Items)
            {
                listViewReceipt.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            SaveToDatabase(totalAmount, "현금");
            MessageBox.Show("현금 결제가 완료되었습니다.");

            mainForm.ResetPOS();

            this.Close();
        }

        private async void btnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("카드 승인 중입니다…");

            await Task.Delay(1000);

            SaveToDatabase(totalAmount, "카드");
            MessageBox.Show("카드 승인 완료!");
            mainForm.ResetPOS();
            this.Close();
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            int discount = 1000;

            int finalAmount = Math.Max(0, totalAmount - discount);

            SaveToDatabase(finalAmount, "쿠폰");

            MessageBox.Show($"쿠폰 적용 완료! -1000원 할인\n결제 금액: {finalAmount}원");
            mainForm.ResetPOS();
            this.Close();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "사용할 포인트를 입력하세요.", "포인트 결제", "0");

            if (int.TryParse(input, out int point))
            {
                int finalAmount = Math.Max(0, totalAmount - point);

                SaveToDatabase(finalAmount, "포인트");

                MessageBox.Show($"포인트 {point}점 사용 완료!\n결제 금액: {finalAmount}원");
                mainForm.ResetPOS();
                this.Close();
            }
            else
            {
                MessageBox.Show("잘못된 입력입니다.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "현금으로 낼 금액을 입력하세요.", "분할 결제", "0");

            if (int.TryParse(input, out int cashAmount))
            {
                if (cashAmount > totalAmount)
                {
                    MessageBox.Show("현금 금액이 결제 금액보다 클 수 없습니다.");
                    return;
                }

                int cardAmount = totalAmount - cashAmount;

                SaveToDatabase(totalAmount, "분할결제");

                MessageBox.Show(
                    $"분할 결제 완료!\n현금: {cashAmount}원\n카드: {cardAmount}원");
                mainForm.ResetPOS();

                this.Close();
            }
            else
            {
                MessageBox.Show("잘못된 입력입니다.");
            }
        }
        private void SaveToDatabase(int finalAmount, string method)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    string getSid = "SELECT NVL(MAX(sid), 0) + 1 FROM pos_sales";
                    OracleCommand cmd = new OracleCommand(getSid, conn);
                    int newSid = Convert.ToInt32(cmd.ExecuteScalar());

                    string insertSales =
                        "INSERT INTO pos_sales (sid, total, payment_method) VALUES (:sid, :total, :method)";
                    OracleCommand cmd2 = new OracleCommand(insertSales, conn);
                    cmd2.Parameters.Add(":sid", newSid);
                    cmd2.Parameters.Add(":total", finalAmount);
                    cmd2.Parameters.Add(":method", method);
                    cmd2.ExecuteNonQuery();

                    foreach (ListViewItem item in cartData.Items)
                    {
                        string pname = item.SubItems[0].Text;
                        int qty = int.Parse(item.SubItems[1].Text);
                        int amount = int.Parse(item.SubItems[2].Text);

                        // pid 찾기
                        string getPid = "SELECT pid FROM product WHERE pname = :pname";
                        OracleCommand cmd3 = new OracleCommand(getPid, conn);
                        cmd3.Parameters.Add(":pname", pname);
                        int pid = Convert.ToInt32(cmd3.ExecuteScalar());

                        string getSdid = "SELECT NVL(MAX(sdid), 0) + 1 FROM pos_sales_detail";
                        OracleCommand cmd4 = new OracleCommand(getSdid, conn);
                        int newSdid = Convert.ToInt32(cmd4.ExecuteScalar());

                        string insertDetail =
                            "INSERT INTO pos_sales_detail (sdid, sid, pid, qty, amount) " +
                            "VALUES (:sdid, :sid, :pid, :qty, :amount)";
                        OracleCommand cmd5 = new OracleCommand(insertDetail, conn);
                        cmd5.Parameters.Add(":sdid", newSdid);
                        cmd5.Parameters.Add(":sid", newSid);
                        cmd5.Parameters.Add(":pid", pid);
                        cmd5.Parameters.Add(":qty", qty);
                        cmd5.Parameters.Add(":amount", amount);
                        cmd5.ExecuteNonQuery();

                        string updateStock =
                            "UPDATE product SET stock = stock - :qty WHERE pid = :pid";
                        OracleCommand cmd6 = new OracleCommand(updateStock, conn);
                        cmd6.Parameters.Add(":qty", qty);
                        cmd6.Parameters.Add(":pid", pid);
                        cmd6.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 저장 오류: " + ex.Message);
            }
        }
    }
}
