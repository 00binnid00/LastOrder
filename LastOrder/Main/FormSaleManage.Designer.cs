namespace Main
{
    partial class FormSaleManage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategoryDrink = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnCategorySnack = new System.Windows.Forms.Button();
            this.btnCategoryRamen = new System.Windows.Forms.Button();
            this.btnCategoryBread = new System.Windows.Forms.Button();
            this.btnCategoryCold = new System.Windows.Forms.Button();
            this.btnCategoryFrozen = new System.Windows.Forms.Button();
            this.btnCategoryIcecream = new System.Windows.Forms.Button();
            this.btnCategoryEtc = new System.Windows.Forms.Button();
            this.btnCategoryLunch = new System.Windows.Forms.Button();
            this.btnCategoryAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lvCart = new System.Windows.Forms.ListView();
            this.colCartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.colProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
=======
            this.colCartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCartAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCart = new System.Windows.Forms.ListView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.colProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProduct = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
>>>>>>> 80198e2a8585f3cc1deead29823c6192e83bdb18
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 11;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "카테고리";
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
            this.btnCategoryDrink.Click += new System.EventHandler(this.button5_Click);
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
            this.btnCategoryAll.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Thistle;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(770, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "선택 취소";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
<<<<<<< HEAD
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Thistle;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPay.Location = new System.Drawing.Point(881, 513);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(113, 41);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "결제하기";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(885, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "전체 취소";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.Location = new System.Drawing.Point(684, 524);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "총 금액 : 0원";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
=======
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
>>>>>>> 80198e2a8585f3cc1deead29823c6192e83bdb18
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCartName,
            this.colCartQty,
            this.colCartAmount});
            this.lvCart.FullRowSelect = true;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(183, 280);
            this.lvCart.MultiSelect = false;
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(811, 179);
            this.lvCart.TabIndex = 2;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
<<<<<<< HEAD
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Thistle;
            this.btnAdd.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(837, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(657, 225);
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(157, 25);
            this.numQty.TabIndex = 4;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lvProduct
=======
            // lblTotal
>>>>>>> 80198e2a8585f3cc1deead29823c6192e83bdb18
            // 
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProductName,
            this.colPrice});
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(183, 58);
            this.lvProduct.MultiSelect = false;
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(811, 152);
            this.lvProduct.TabIndex = 1;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            this.lvProduct.Click += new System.EventHandler(this.lvProduct_Click);
            // 
            // colProductName
            // 
            this.colProductName.Text = "상품명";
            this.colProductName.Width = 150;
            // 
<<<<<<< HEAD
            // colPrice
            // 
            this.colPrice.Text = "가격";
            this.colPrice.Width = 100;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.Location = new System.Drawing.Point(929, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
=======
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Thistle;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(770, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "선택 취소";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
>>>>>>> 80198e2a8585f3cc1deead29823c6192e83bdb18
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(547, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(363, 25);
            this.txtSearch.TabIndex = 9;
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
            // lvProduct
            // 
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProductName,
            this.colPrice});
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(183, 58);
            this.lvProduct.MultiSelect = false;
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(811, 152);
            this.lvProduct.TabIndex = 1;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            this.lvProduct.Click += new System.EventHandler(this.lvProduct_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Thistle;
            this.btnAdd.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(837, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(657, 225);
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(157, 25);
            this.numQty.TabIndex = 4;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(673, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 25);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.Location = new System.Drawing.Point(918, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // FormSaleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1027, 557);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvCart);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormSaleManage";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
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
<<<<<<< HEAD
=======
        private System.Windows.Forms.ColumnHeader colCartName;
        private System.Windows.Forms.ColumnHeader colCartQty;
        private System.Windows.Forms.ColumnHeader colCartAmount;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
>>>>>>> 80198e2a8585f3cc1deead29823c6192e83bdb18
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClear;
<<<<<<< HEAD
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.ColumnHeader colCartName;
        private System.Windows.Forms.ColumnHeader colCartQty;
        private System.Windows.Forms.ColumnHeader colCartAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
=======
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
>>>>>>> 80198e2a8585f3cc1deead29823c6192e83bdb18
    }
}

