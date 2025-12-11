namespace Main
{
    partial class FormEventManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvEvent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numGet = new System.Windows.Forms.NumericUpDown();
            this.numBuy = new System.Windows.Forms.NumericUpDown();
            this.rbBundle = new System.Windows.Forms.RadioButton();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "이벤트";
            // 
            // lvEvent
            // 
            this.lvEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvEvent.FullRowSelect = true;
            this.lvEvent.GridLines = true;
            this.lvEvent.HideSelection = false;
            this.lvEvent.Location = new System.Drawing.Point(12, 91);
            this.lvEvent.Name = "lvEvent";
            this.lvEvent.Size = new System.Drawing.Size(918, 163);
            this.lvEvent.TabIndex = 1;
            this.lvEvent.UseCompatibleStateImageBehavior = false;
            this.lvEvent.View = System.Windows.Forms.View.Details;
            this.lvEvent.SelectedIndexChanged += new System.EventHandler(this.lvEvent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "상품명";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "가격";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "카테고리";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "이벤트명";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "할인 유형";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "기간";
            this.columnHeader6.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(399, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(426, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDiscountValue);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numGet);
            this.groupBox1.Controls.Add(this.numBuy);
            this.groupBox1.Controls.Add(this.rbBundle);
            this.groupBox1.Controls.Add(this.rbPercent);
            this.groupBox1.Controls.Add(this.rbAmount);
            this.groupBox1.Controls.Add(this.txtEventName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSelectedProduct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이벤트 정보 입력 및 목록";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numDiscountValue
            // 
            this.numDiscountValue.Location = new System.Drawing.Point(127, 191);
            this.numDiscountValue.Name = "numDiscountValue";
            this.numDiscountValue.Size = new System.Drawing.Size(201, 25);
            this.numDiscountValue.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(372, 139);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(337, 132);
            this.txtDescription.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "~";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(509, 68);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 25);
            this.dtEnd.TabIndex = 17;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(483, 34);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 25);
            this.dtStart.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "+";
            // 
            // numGet
            // 
            this.numGet.Location = new System.Drawing.Point(241, 246);
            this.numGet.Name = "numGet";
            this.numGet.Size = new System.Drawing.Size(73, 25);
            this.numGet.TabIndex = 14;
            // 
            // numBuy
            // 
            this.numBuy.Location = new System.Drawing.Point(129, 246);
            this.numBuy.Name = "numBuy";
            this.numBuy.Size = new System.Drawing.Size(73, 25);
            this.numBuy.TabIndex = 13;
            // 
            // rbBundle
            // 
            this.rbBundle.AutoSize = true;
            this.rbBundle.Location = new System.Drawing.Point(274, 140);
            this.rbBundle.Name = "rbBundle";
            this.rbBundle.Size = new System.Drawing.Size(58, 19);
            this.rbBundle.TabIndex = 11;
            this.rbBundle.TabStop = true;
            this.rbBundle.Text = "묶음";
            this.rbBundle.UseVisualStyleBackColor = true;
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Location = new System.Drawing.Point(195, 140);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(73, 19);
            this.rbPercent.TabIndex = 10;
            this.rbPercent.TabStop = true;
            this.rbPercent.Text = "퍼센트";
            this.rbPercent.UseVisualStyleBackColor = true;
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Location = new System.Drawing.Point(127, 140);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(58, 19);
            this.rbAmount.TabIndex = 9;
            this.rbAmount.TabStop = true;
            this.rbAmount.Text = "정액";
            this.rbAmount.UseVisualStyleBackColor = true;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(127, 84);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(201, 25);
            this.txtEventName.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "설명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "이벤트 기간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "묶음 조건";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "정액/정률 값";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "할인 유형";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "이벤트명";
            // 
            // lblSelectedProduct
            // 
            this.lblSelectedProduct.AutoSize = true;
            this.lblSelectedProduct.Location = new System.Drawing.Point(125, 38);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(129, 15);
            this.lblSelectedProduct.TabIndex = 1;
            this.lblSelectedProduct.Text = "lblSelectedProduct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "선택된 상품";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(795, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 49);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(795, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 49);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(795, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 49);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(795, 516);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 49);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "재조회";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormEventManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 592);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvEvent);
            this.Controls.Add(this.label1);
            this.Name = "FormEventManage";
            this.Text = "FormEventManage";
            this.Load += new System.EventHandler(this.FormEventManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvEvent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectedProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numGet;
        private System.Windows.Forms.NumericUpDown numBuy;
        private System.Windows.Forms.RadioButton rbBundle;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown numDiscountValue;
    }
}