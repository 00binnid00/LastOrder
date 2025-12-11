namespace Main
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.결제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaleManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefundManager = new System.Windows.Forms.ToolStripMenuItem();
            this.상품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStockManage = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalesStats = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipment = new System.Windows.Forms.ToolStripMenuItem();
            this.이벤트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEventManage = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자모드로전환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.결제ToolStripMenuItem,
            this.상품관리ToolStripMenuItem,
            this.매출관리ToolStripMenuItem,
            this.이벤트ToolStripMenuItem,
            this.사용자모드로전환ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 결제ToolStripMenuItem
            // 
            this.결제ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaleManage,
            this.menuRefundManager});
            this.결제ToolStripMenuItem.Name = "결제ToolStripMenuItem";
            this.결제ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.결제ToolStripMenuItem.Text = "결제";
            // 
            // menuSaleManage
            // 
            this.menuSaleManage.Name = "menuSaleManage";
            this.menuSaleManage.Size = new System.Drawing.Size(157, 26);
            this.menuSaleManage.Text = "판매 관리";
            this.menuSaleManage.Click += new System.EventHandler(this.menuSaleManage_Click);
            // 
            // menuRefundManager
            // 
            this.menuRefundManager.Name = "menuRefundManager";
            this.menuRefundManager.Size = new System.Drawing.Size(157, 26);
            this.menuRefundManager.Text = "환불 관리";
            this.menuRefundManager.Click += new System.EventHandler(this.menuRefundManager_Click);
            // 
            // 상품관리ToolStripMenuItem
            // 
            this.상품관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductManage,
            this.menuStockManage});
            this.상품관리ToolStripMenuItem.Name = "상품관리ToolStripMenuItem";
            this.상품관리ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.상품관리ToolStripMenuItem.Text = "상품 관리";
            // 
            // menuProductManage
            // 
            this.menuProductManage.Name = "menuProductManage";
            this.menuProductManage.Size = new System.Drawing.Size(238, 26);
            this.menuProductManage.Text = "상품 정보 관리";
            this.menuProductManage.Click += new System.EventHandler(this.menuProductManage_Click);
            // 
            // menuStockManage
            // 
            this.menuStockManage.Name = "menuStockManage";
            this.menuStockManage.Size = new System.Drawing.Size(238, 26);
            this.menuStockManage.Text = "재고 관리 (입고/출고)";
            this.menuStockManage.Click += new System.EventHandler(this.menuStockManage_Click);
            // 
            // 매출관리ToolStripMenuItem
            // 
            this.매출관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSalesStats,
            this.menuShipment});
            this.매출관리ToolStripMenuItem.Name = "매출관리ToolStripMenuItem";
            this.매출관리ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.매출관리ToolStripMenuItem.Text = "매출 관리";
            // 
            // menuSalesStats
            // 
            this.menuSalesStats.Name = "menuSalesStats";
            this.menuSalesStats.Size = new System.Drawing.Size(197, 26);
            this.menuSalesStats.Text = "매출 통계";
            this.menuSalesStats.Click += new System.EventHandler(this.menuSalesStats_Click);
            // 
            // menuShipment
            // 
            this.menuShipment.Name = "menuShipment";
            this.menuShipment.Size = new System.Drawing.Size(197, 26);
            this.menuShipment.Text = "출고(판매 내역)";
            this.menuShipment.Click += new System.EventHandler(this.menuShipment_Click);
            // 
            // 이벤트ToolStripMenuItem
            // 
            this.이벤트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEventManage});
            this.이벤트ToolStripMenuItem.Name = "이벤트ToolStripMenuItem";
            this.이벤트ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.이벤트ToolStripMenuItem.Text = "이벤트";
            // 
            // menuEventManage
            // 
            this.menuEventManage.Name = "menuEventManage";
            this.menuEventManage.Size = new System.Drawing.Size(172, 26);
            this.menuEventManage.Text = "이벤트 관리";
            this.menuEventManage.Click += new System.EventHandler(this.menuEventManage_Click);
            // 
            // 사용자모드로전환ToolStripMenuItem
            // 
            this.사용자모드로전환ToolStripMenuItem.Name = "사용자모드로전환ToolStripMenuItem";
            this.사용자모드로전환ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.사용자모드로전환ToolStripMenuItem.Text = "사용자 모드로 전환";
            this.사용자모드로전환ToolStripMenuItem.Click += new System.EventHandler(this.사용자모드로전환ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 결제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSaleManage;
        private System.Windows.Forms.ToolStripMenuItem menuRefundManager;
        private System.Windows.Forms.ToolStripMenuItem 상품관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProductManage;
        private System.Windows.Forms.ToolStripMenuItem menuStockManage;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSalesStats;
        private System.Windows.Forms.ToolStripMenuItem menuShipment;
        private System.Windows.Forms.ToolStripMenuItem 이벤트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEventManage;
        private System.Windows.Forms.ToolStripMenuItem 사용자모드로전환ToolStripMenuItem;
    }
}