namespace Main
{
    partial class FormPay
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.listViewReceipt = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotal.Location = new System.Drawing.Point(25, 29);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(185, 28);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "총 금액 : 0원";
            // 
            // listViewReceipt
            // 
            this.listViewReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewReceipt.HideSelection = false;
            this.listViewReceipt.Location = new System.Drawing.Point(30, 81);
            this.listViewReceipt.Name = "listViewReceipt";
            this.listViewReceipt.Size = new System.Drawing.Size(734, 205);
            this.listViewReceipt.TabIndex = 3;
            this.listViewReceipt.UseCompatibleStateImageBehavior = false;
            this.listViewReceipt.View = System.Windows.Forms.View.Details;
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
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Thistle;
            this.btnCash.Location = new System.Drawing.Point(30, 328);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(131, 57);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "현금";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.Thistle;
            this.btnCard.Location = new System.Drawing.Point(178, 328);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(131, 57);
            this.btnCard.TabIndex = 5;
            this.btnCard.Text = "카드";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCoupon
            // 
            this.btnCoupon.BackColor = System.Drawing.Color.Thistle;
            this.btnCoupon.Location = new System.Drawing.Point(328, 328);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(131, 57);
            this.btnCoupon.TabIndex = 6;
            this.btnCoupon.Text = "쿠폰";
            this.btnCoupon.UseVisualStyleBackColor = false;
            this.btnCoupon.Click += new System.EventHandler(this.btnCoupon_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.Thistle;
            this.btnSplit.Location = new System.Drawing.Point(480, 328);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(131, 57);
            this.btnSplit.TabIndex = 7;
            this.btnSplit.Text = "포인트";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Thistle;
            this.button5.Location = new System.Drawing.Point(633, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 57);
            this.button5.TabIndex = 8;
            this.button5.Text = "분할결제";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnCoupon);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.listViewReceipt);
            this.Controls.Add(this.labelTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ListView listViewReceipt;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCoupon;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button button5;
    }
}