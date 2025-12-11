namespace Main
{
    partial class FormSelfCheckout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategoryAll = new System.Windows.Forms.Button();
            this.btnCategoryLunch = new System.Windows.Forms.Button();
            this.btnCategoryEtc = new System.Windows.Forms.Button();
            this.btnCategoryIcecream = new System.Windows.Forms.Button();
            this.btnCategoryFrozen = new System.Windows.Forms.Button();
            this.btnCategoryCold = new System.Windows.Forms.Button();
            this.btnCategoryBread = new System.Windows.Forms.Button();
            this.btnCategoryRamen = new System.Windows.Forms.Button();
            this.btnCategorySnack = new System.Windows.Forms.Button();
            this.btnCategoryDrink = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvCart = new System.Windows.Forms.ListView();
            this.colCartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProduct = new System.Windows.Forms.ListView();
            this.colProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리자모드로전환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCategoryAll);
            this.groupBox1.Controls.Add(this.btnCategoryLunch);
            this.groupBox1.Controls.Add(this.btnCategoryEtc);
            this.groupBox1.Controls.Add(this.btnCategoryIcecream);
            this.groupBox1.Controls.Add(this.btnCategoryFrozen);
            this.groupBox1.Controls.Add(this.btnCategoryCold);
            this.groupBox1.Controls.Add(this.btnCategoryBread);
            this.groupBox1.Controls.Add(this.btnCategoryRamen);
            this.groupBox1.Controls.Add(this.btnCategorySnack);
            this.groupBox1.Controls.Add(this.btnCategoryDrink);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 478);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "카테고리";
            // 
            // btnCategoryAll
            // 
            this.btnCategoryAll.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryAll.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryAll.Location = new System.Drawing.Point(18, 429);
            this.btnCategoryAll.Name = "btnCategoryAll";
            this.btnCategoryAll.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryAll.TabIndex = 14;
            this.btnCategoryAll.Text = "전체";
            this.btnCategoryAll.UseVisualStyleBackColor = false;
            this.btnCategoryAll.Click += new System.EventHandler(this.btnCategoryAll_Click);
            // 
            // btnCategoryLunch
            // 
            this.btnCategoryLunch.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryLunch.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryLunch.Location = new System.Drawing.Point(18, 204);
            this.btnCategoryLunch.Name = "btnCategoryLunch";
            this.btnCategoryLunch.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryLunch.TabIndex = 13;
            this.btnCategoryLunch.Text = "도시락";
            this.btnCategoryLunch.UseVisualStyleBackColor = false;
            this.btnCategoryLunch.Click += new System.EventHandler(this.btnCategoryLunch_Click);
            // 
            // btnCategoryEtc
            // 
            this.btnCategoryEtc.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryEtc.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryEtc.Location = new System.Drawing.Point(18, 384);
            this.btnCategoryEtc.Name = "btnCategoryEtc";
            this.btnCategoryEtc.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryEtc.TabIndex = 12;
            this.btnCategoryEtc.Text = "기타";
            this.btnCategoryEtc.UseVisualStyleBackColor = false;
            this.btnCategoryEtc.Click += new System.EventHandler(this.btnCategoryEtc_Click);
            // 
            // btnCategoryIcecream
            // 
            this.btnCategoryIcecream.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryIcecream.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryIcecream.Location = new System.Drawing.Point(18, 339);
            this.btnCategoryIcecream.Name = "btnCategoryIcecream";
            this.btnCategoryIcecream.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryIcecream.TabIndex = 11;
            this.btnCategoryIcecream.Text = "아이스크림";
            this.btnCategoryIcecream.UseVisualStyleBackColor = false;
            this.btnCategoryIcecream.Click += new System.EventHandler(this.btnCategoryIcecream_Click);
            // 
            // btnCategoryFrozen
            // 
            this.btnCategoryFrozen.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryFrozen.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryFrozen.Location = new System.Drawing.Point(18, 294);
            this.btnCategoryFrozen.Name = "btnCategoryFrozen";
            this.btnCategoryFrozen.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryFrozen.TabIndex = 10;
            this.btnCategoryFrozen.Text = "냉동";
            this.btnCategoryFrozen.UseVisualStyleBackColor = false;
            this.btnCategoryFrozen.Click += new System.EventHandler(this.btnCategoryFrozen_Click);
            // 
            // btnCategoryCold
            // 
            this.btnCategoryCold.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryCold.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryCold.Location = new System.Drawing.Point(18, 249);
            this.btnCategoryCold.Name = "btnCategoryCold";
            this.btnCategoryCold.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryCold.TabIndex = 9;
            this.btnCategoryCold.Text = "냉장";
            this.btnCategoryCold.UseVisualStyleBackColor = false;
            this.btnCategoryCold.Click += new System.EventHandler(this.btnCategoryCold_Click);
            // 
            // btnCategoryBread
            // 
            this.btnCategoryBread.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryBread.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryBread.Location = new System.Drawing.Point(18, 114);
            this.btnCategoryBread.Name = "btnCategoryBread";
            this.btnCategoryBread.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryBread.TabIndex = 8;
            this.btnCategoryBread.Text = "빵";
            this.btnCategoryBread.UseVisualStyleBackColor = false;
            this.btnCategoryBread.Click += new System.EventHandler(this.btnCategoryBread_Click);
            // 
            // btnCategoryRamen
            // 
            this.btnCategoryRamen.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryRamen.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryRamen.Location = new System.Drawing.Point(18, 159);
            this.btnCategoryRamen.Name = "btnCategoryRamen";
            this.btnCategoryRamen.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryRamen.TabIndex = 7;
            this.btnCategoryRamen.Text = "라면·면";
            this.btnCategoryRamen.UseVisualStyleBackColor = false;
            this.btnCategoryRamen.Click += new System.EventHandler(this.btnCategoryRamen_Click);
            // 
            // btnCategorySnack
            // 
            this.btnCategorySnack.BackColor = System.Drawing.Color.Thistle;
            this.btnCategorySnack.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategorySnack.Location = new System.Drawing.Point(18, 69);
            this.btnCategorySnack.Name = "btnCategorySnack";
            this.btnCategorySnack.Size = new System.Drawing.Size(107, 39);
            this.btnCategorySnack.TabIndex = 6;
            this.btnCategorySnack.Text = "과자";
            this.btnCategorySnack.UseVisualStyleBackColor = false;
            this.btnCategorySnack.Click += new System.EventHandler(this.btnCategorySnack_Click);
            // 
            // btnCategoryDrink
            // 
            this.btnCategoryDrink.BackColor = System.Drawing.Color.Thistle;
            this.btnCategoryDrink.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCategoryDrink.Location = new System.Drawing.Point(18, 24);
            this.btnCategoryDrink.Name = "btnCategoryDrink";
            this.btnCategoryDrink.Size = new System.Drawing.Size(107, 39);
            this.btnCategoryDrink.TabIndex = 5;
            this.btnCategoryDrink.Text = "음료";
            this.btnCategoryDrink.UseVisualStyleBackColor = false;
            this.btnCategoryDrink.Click += new System.EventHandler(this.btnCategoryDrink_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(884, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 30);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "전체 취소";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Thistle;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(769, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "선택 취소";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCartName,
            this.colCartQty,
            this.colCartAmount});
            this.lvCart.FullRowSelect = true;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(182, 293);
            this.lvCart.MultiSelect = false;
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(811, 179);
            this.lvCart.TabIndex = 16;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // colCartName
            // 
            this.colCartName.Text = "상품명";
            this.colCartName.Width = 150;
            // 
            // colCartQty
            // 
            this.colCartQty.Text = "수량";
            this.colCartQty.Width = 100;
            // 
            // colCartAmount
            // 
            this.colCartAmount.Text = "금액";
            this.colCartAmount.Width = 100;
            // 
            // lvProduct
            // 
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProductName,
            this.colPrice});
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(182, 71);
            this.lvProduct.MultiSelect = false;
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(811, 152);
            this.lvProduct.TabIndex = 15;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            // 
            // colProductName
            // 
            this.colProductName.Text = "상품명";
            this.colProductName.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.Text = "가격";
            this.colPrice.Width = 100;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Thistle;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPay.Location = new System.Drawing.Point(880, 526);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(113, 41);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "결제하기";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.Location = new System.Drawing.Point(683, 537);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 20);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "총 금액 : 0원";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Thistle;
            this.btnMinus.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(654, 488);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(109, 30);
            this.btnMinus.TabIndex = 21;
            this.btnMinus.Text = "수량 감소";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Thistle;
            this.btnPlus.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(539, 488);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(109, 30);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.Text = "수량 추가";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자모드로전환ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리자모드로전환ToolStripMenuItem
            // 
            this.관리자모드로전환ToolStripMenuItem.Name = "관리자모드로전환ToolStripMenuItem";
            this.관리자모드로전환ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.관리자모드로전환ToolStripMenuItem.Text = "관리자 모드로 전환";
            this.관리자모드로전환ToolStripMenuItem.Click += new System.EventHandler(this.관리자모드로전환ToolStripMenuItem_Click);
            // 
            // FormSelfCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.lvCart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSelfCheckout";
            this.Text = "FormSelfCheckout";
            this.Load += new System.EventHandler(this.FormSelfCheckout_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryAll;
        private System.Windows.Forms.Button btnCategoryLunch;
        private System.Windows.Forms.Button btnCategoryEtc;
        private System.Windows.Forms.Button btnCategoryIcecream;
        private System.Windows.Forms.Button btnCategoryFrozen;
        private System.Windows.Forms.Button btnCategoryCold;
        private System.Windows.Forms.Button btnCategoryBread;
        private System.Windows.Forms.Button btnCategoryRamen;
        private System.Windows.Forms.Button btnCategorySnack;
        private System.Windows.Forms.Button btnCategoryDrink;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.ColumnHeader colCartName;
        private System.Windows.Forms.ColumnHeader colCartQty;
        private System.Windows.Forms.ColumnHeader colCartAmount;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리자모드로전환ToolStripMenuItem;
    }
}