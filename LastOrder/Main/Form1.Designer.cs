namespace Main
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtc = new System.Windows.Forms.Button();
            this.btnCold = new System.Windows.Forms.Button();
            this.btnSnack = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCart = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCart = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtc);
            this.groupBox1.Controls.Add(this.btnCold);
            this.groupBox1.Controls.Add(this.btnSnack);
            this.groupBox1.Controls.Add(this.btnDrink);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "카테고리";
            // 
            // btnEtc
            // 
            this.btnEtc.Location = new System.Drawing.Point(464, 22);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(113, 56);
            this.btnEtc.TabIndex = 4;
            this.btnEtc.Text = "기타";
            this.btnEtc.UseVisualStyleBackColor = true;
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // btnCold
            // 
            this.btnCold.Location = new System.Drawing.Point(320, 22);
            this.btnCold.Name = "btnCold";
            this.btnCold.Size = new System.Drawing.Size(113, 56);
            this.btnCold.TabIndex = 3;
            this.btnCold.Text = "냉장";
            this.btnCold.UseVisualStyleBackColor = true;
            this.btnCold.Click += new System.EventHandler(this.btnCold_Click);
            // 
            // btnSnack
            // 
            this.btnSnack.Location = new System.Drawing.Point(169, 24);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Size = new System.Drawing.Size(113, 56);
            this.btnSnack.TabIndex = 2;
            this.btnSnack.Text = "과자";
            this.btnSnack.UseVisualStyleBackColor = true;
            this.btnSnack.Click += new System.EventHandler(this.btnSnack_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Location = new System.Drawing.Point(17, 24);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(113, 56);
            this.btnDrink.TabIndex = 1;
            this.btnDrink.Text = "음료";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(12, 127);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(283, 238);
            this.listViewProduct.TabIndex = 1;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "상품명";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "가격";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "재고";
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(344, 127);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(283, 275);
            this.listViewCart.TabIndex = 2;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "상품명";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "수량";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "금액";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(12, 384);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(113, 30);
            this.btnAddCart.TabIndex = 3;
            this.btnAddCart.Text = "담기";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(182, 384);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(111, 25);
            this.numQty.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(265, 422);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "총 금액 : 0원";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(255, 441);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(113, 30);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "결제하기";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 475);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.listViewCart);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCold;
        private System.Windows.Forms.Button btnSnack;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
    }
}

