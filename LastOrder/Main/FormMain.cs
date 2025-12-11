using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void OpenPOSForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FormSaleManage)
                {
                    frm.Activate();
                    return;
                }
            }

            FormSaleManage pos = new FormSaleManage();
            pos.MdiParent = this;
            pos.WindowState = FormWindowState.Maximized;
            pos.Show();
        }
        private void OpenChildForm(Form child)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == child.GetType())
                {
                    f.Activate();
                    child.Dispose();
                    return;
                }
            }
            child.MdiParent = this;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private void menuSaleManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSaleManage());
        }

        private void menuRefundManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRefundManage());
        }

        private void menuProductManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProductManage());
        }

        private void menuStockManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStockManage());
        }

        private void menuSalesStats_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSalesStats());
        }

        private void menuShipment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormShipmentList());
        }

        private void menuEventManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEventManage());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            OpenPOSForm();
        }

        private void 사용자모드로전환ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelfCheckout self = new FormSelfCheckout();
            self.WindowState = FormWindowState.Maximized;
            self.Show();
            this.Hide();
        }
    }
}
