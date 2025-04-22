namespace Week07Homework
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
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInputProductStock = new System.Windows.Forms.TextBox();
            this.tbxInputProductPrice = new System.Windows.Forms.TextBox();
            this.tbxInputProductName = new System.Windows.Forms.TextBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchProductTotalPrice = new System.Windows.Forms.Label();
            this.lblSearchProductRegDate = new System.Windows.Forms.Label();
            this.lblSearchProductStock = new System.Windows.Forms.Label();
            this.lblSearchProductSalePrice = new System.Windows.Forms.Label();
            this.lblSearchProductPrice = new System.Windows.Forms.Label();
            this.lblSearchProductCode = new System.Windows.Forms.Label();
            this.lblSearchProductName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.tbxSearchProcuctCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxSearchProduct = new System.Windows.Forms.ListBox();
            this.tbxSearchNameCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxInput.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.btnInput);
            this.gbxInput.Controls.Add(this.label3);
            this.gbxInput.Controls.Add(this.label2);
            this.gbxInput.Controls.Add(this.label1);
            this.gbxInput.Controls.Add(this.tbxInputProductStock);
            this.gbxInput.Controls.Add(this.tbxInputProductPrice);
            this.gbxInput.Controls.Add(this.tbxInputProductName);
            this.gbxInput.Location = new System.Drawing.Point(12, 30);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(314, 279);
            this.gbxInput.TabIndex = 0;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "상품등록";
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.White;
            this.btnInput.Location = new System.Drawing.Point(129, 181);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(164, 32);
            this.btnInput.TabIndex = 22;
            this.btnInput.Text = "등록";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "재고";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "가격";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxInputProductStock
            // 
            this.tbxInputProductStock.Location = new System.Drawing.Point(129, 122);
            this.tbxInputProductStock.Name = "tbxInputProductStock";
            this.tbxInputProductStock.Size = new System.Drawing.Size(164, 25);
            this.tbxInputProductStock.TabIndex = 2;
            // 
            // tbxInputProductPrice
            // 
            this.tbxInputProductPrice.Location = new System.Drawing.Point(129, 81);
            this.tbxInputProductPrice.Name = "tbxInputProductPrice";
            this.tbxInputProductPrice.Size = new System.Drawing.Size(164, 25);
            this.tbxInputProductPrice.TabIndex = 1;
            // 
            // tbxInputProductName
            // 
            this.tbxInputProductName.Location = new System.Drawing.Point(129, 39);
            this.tbxInputProductName.Name = "tbxInputProductName";
            this.tbxInputProductName.Size = new System.Drawing.Size(164, 25);
            this.tbxInputProductName.TabIndex = 0;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.lblSearchProductTotalPrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductRegDate);
            this.gbxSearch.Controls.Add(this.lblSearchProductStock);
            this.gbxSearch.Controls.Add(this.lblSearchProductSalePrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductPrice);
            this.gbxSearch.Controls.Add(this.lblSearchProductCode);
            this.gbxSearch.Controls.Add(this.lblSearchProductName);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.btnCal);
            this.gbxSearch.Controls.Add(this.tbxSearchProcuctCount);
            this.gbxSearch.Controls.Add(this.label12);
            this.gbxSearch.Controls.Add(this.label11);
            this.gbxSearch.Controls.Add(this.label10);
            this.gbxSearch.Controls.Add(this.label9);
            this.gbxSearch.Controls.Add(this.label8);
            this.gbxSearch.Controls.Add(this.label7);
            this.gbxSearch.Controls.Add(this.label6);
            this.gbxSearch.Controls.Add(this.label5);
            this.gbxSearch.Controls.Add(this.lbxSearchProduct);
            this.gbxSearch.Controls.Add(this.tbxSearchNameCode);
            this.gbxSearch.Controls.Add(this.label4);
            this.gbxSearch.Location = new System.Drawing.Point(351, 30);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(566, 418);
            this.gbxSearch.TabIndex = 6;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "상품조회";
            // 
            // lblSearchProductTotalPrice
            // 
            this.lblSearchProductTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblSearchProductTotalPrice.Location = new System.Drawing.Point(325, 370);
            this.lblSearchProductTotalPrice.Name = "lblSearchProductTotalPrice";
            this.lblSearchProductTotalPrice.Size = new System.Drawing.Size(202, 23);
            this.lblSearchProductTotalPrice.TabIndex = 28;
            // 
            // lblSearchProductRegDate
            // 
            this.lblSearchProductRegDate.BackColor = System.Drawing.Color.White;
            this.lblSearchProductRegDate.Location = new System.Drawing.Point(325, 272);
            this.lblSearchProductRegDate.Name = "lblSearchProductRegDate";
            this.lblSearchProductRegDate.Size = new System.Drawing.Size(202, 23);
            this.lblSearchProductRegDate.TabIndex = 27;
            // 
            // lblSearchProductStock
            // 
            this.lblSearchProductStock.BackColor = System.Drawing.Color.White;
            this.lblSearchProductStock.Location = new System.Drawing.Point(325, 232);
            this.lblSearchProductStock.Name = "lblSearchProductStock";
            this.lblSearchProductStock.Size = new System.Drawing.Size(202, 23);
            this.lblSearchProductStock.TabIndex = 26;
            // 
            // lblSearchProductSalePrice
            // 
            this.lblSearchProductSalePrice.BackColor = System.Drawing.Color.White;
            this.lblSearchProductSalePrice.Location = new System.Drawing.Point(325, 191);
            this.lblSearchProductSalePrice.Name = "lblSearchProductSalePrice";
            this.lblSearchProductSalePrice.Size = new System.Drawing.Size(202, 23);
            this.lblSearchProductSalePrice.TabIndex = 25;
            // 
            // lblSearchProductPrice
            // 
            this.lblSearchProductPrice.BackColor = System.Drawing.Color.White;
            this.lblSearchProductPrice.Location = new System.Drawing.Point(325, 154);
            this.lblSearchProductPrice.Name = "lblSearchProductPrice";
            this.lblSearchProductPrice.Size = new System.Drawing.Size(202, 23);
            this.lblSearchProductPrice.TabIndex = 24;
            // 
            // lblSearchProductCode
            // 
            this.lblSearchProductCode.BackColor = System.Drawing.Color.White;
            this.lblSearchProductCode.Location = new System.Drawing.Point(325, 118);
            this.lblSearchProductCode.Name = "lblSearchProductCode";
            this.lblSearchProductCode.Size = new System.Drawing.Size(202, 23);
            this.lblSearchProductCode.TabIndex = 23;
            // 
            // lblSearchProductName
            // 
            this.lblSearchProductName.BackColor = System.Drawing.Color.White;
            this.lblSearchProductName.Location = new System.Drawing.Point(325, 81);
            this.lblSearchProductName.Name = "lblSearchProductName";
            this.lblSearchProductName.Size = new System.Drawing.Size(202, 23);
            this.lblSearchProductName.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(9, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 32);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.White;
            this.btnCal.Location = new System.Drawing.Point(471, 330);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(59, 25);
            this.btnCal.TabIndex = 20;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // tbxSearchProcuctCount
            // 
            this.tbxSearchProcuctCount.Location = new System.Drawing.Point(328, 330);
            this.tbxSearchProcuctCount.Name = "tbxSearchProcuctCount";
            this.tbxSearchProcuctCount.Size = new System.Drawing.Size(137, 25);
            this.tbxSearchProcuctCount.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "수량";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "총가격";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "등록일자";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "재고";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "할인가격";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "가격";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "코드";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "이름";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxSearchProduct
            // 
            this.lbxSearchProduct.FormattingEnabled = true;
            this.lbxSearchProduct.ItemHeight = 15;
            this.lbxSearchProduct.Location = new System.Drawing.Point(15, 148);
            this.lbxSearchProduct.Name = "lbxSearchProduct";
            this.lbxSearchProduct.Size = new System.Drawing.Size(196, 94);
            this.lbxSearchProduct.TabIndex = 3;
            this.lbxSearchProduct.SelectedIndexChanged += new System.EventHandler(this.lbxSearchProduct_SelectedIndexChanged);
            // 
            // tbxSearchNameCode
            // 
            this.tbxSearchNameCode.Location = new System.Drawing.Point(9, 74);
            this.tbxSearchNameCode.Name = "tbxSearchNameCode";
            this.tbxSearchNameCode.Size = new System.Drawing.Size(202, 25);
            this.tbxSearchNameCode.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "이름 && 코드";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 462);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxInput);
            this.Name = "Form1";
            this.Text = "7주차 숙제";
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInputProductStock;
        private System.Windows.Forms.TextBox tbxInputProductPrice;
        private System.Windows.Forms.TextBox tbxInputProductName;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox tbxSearchProcuctCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxSearchProduct;
        private System.Windows.Forms.TextBox tbxSearchNameCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchProductName;
        private System.Windows.Forms.Label lblSearchProductTotalPrice;
        private System.Windows.Forms.Label lblSearchProductRegDate;
        private System.Windows.Forms.Label lblSearchProductStock;
        private System.Windows.Forms.Label lblSearchProductSalePrice;
        private System.Windows.Forms.Label lblSearchProductPrice;
        private System.Windows.Forms.Label lblSearchProductCode;
    }
}

