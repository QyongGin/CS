namespace Week03Proj01
{
    partial class FormWeek3
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
            this.tbxData1 = new System.Windows.Forms.TextBox();
            this.tbxData2 = new System.Windows.Forms.TextBox();
            this.tbxData3 = new System.Windows.Forms.TextBox();
            this.tbxData4 = new System.Windows.Forms.TextBox();
            this.tbxData5 = new System.Windows.Forms.TextBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.chkOption = new System.Windows.Forms.CheckBox();
            this.pnlRadioGroup = new System.Windows.Forms.Panel();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.rbtMul = new System.Windows.Forms.RadioButton();
            this.rbtSub = new System.Windows.Forms.RadioButton();
            this.rbtAdd = new System.Windows.Forms.RadioButton();
            this.btnProcess01 = new System.Windows.Forms.Button();
            this.btnProcess02 = new System.Windows.Forms.Button();
            this.btnProcess03 = new System.Windows.Forms.Button();
            this.btnProcess04 = new System.Windows.Forms.Button();
            this.btnProcess05 = new System.Windows.Forms.Button();
            this.btnProcess10 = new System.Windows.Forms.Button();
            this.btnProcess09 = new System.Windows.Forms.Button();
            this.btnProcess08 = new System.Windows.Forms.Button();
            this.btnProcess07 = new System.Windows.Forms.Button();
            this.btnProcess06 = new System.Windows.Forms.Button();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkIce = new System.Windows.Forms.CheckBox();
            this.pnlRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxData1
            // 
            this.tbxData1.Location = new System.Drawing.Point(13, 13);
            this.tbxData1.Name = "tbxData1";
            this.tbxData1.Size = new System.Drawing.Size(100, 21);
            this.tbxData1.TabIndex = 0;
            // 
            // tbxData2
            // 
            this.tbxData2.Location = new System.Drawing.Point(120, 13);
            this.tbxData2.Name = "tbxData2";
            this.tbxData2.Size = new System.Drawing.Size(100, 21);
            this.tbxData2.TabIndex = 1;
            // 
            // tbxData3
            // 
            this.tbxData3.Location = new System.Drawing.Point(227, 13);
            this.tbxData3.Name = "tbxData3";
            this.tbxData3.Size = new System.Drawing.Size(100, 21);
            this.tbxData3.TabIndex = 2;
            // 
            // tbxData4
            // 
            this.tbxData4.Location = new System.Drawing.Point(334, 13);
            this.tbxData4.Name = "tbxData4";
            this.tbxData4.Size = new System.Drawing.Size(100, 21);
            this.tbxData4.TabIndex = 3;
            // 
            // tbxData5
            // 
            this.tbxData5.Location = new System.Drawing.Point(441, 13);
            this.tbxData5.Name = "tbxData5";
            this.tbxData5.Size = new System.Drawing.Size(100, 21);
            this.tbxData5.TabIndex = 4;
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(13, 41);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(60, 16);
            this.chkAdd.TabIndex = 5;
            this.chkAdd.Text = "더하기";
            this.chkAdd.UseVisualStyleBackColor = true;
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(120, 41);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(48, 16);
            this.chkSub.TabIndex = 6;
            this.chkSub.Text = "빼기";
            this.chkSub.UseVisualStyleBackColor = true;
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(227, 41);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(60, 16);
            this.chkMul.TabIndex = 7;
            this.chkMul.Text = "곱하기";
            this.chkMul.UseVisualStyleBackColor = true;
            // 
            // chkDiv
            // 
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(334, 41);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(60, 16);
            this.chkDiv.TabIndex = 8;
            this.chkDiv.Text = "나누기";
            this.chkDiv.UseVisualStyleBackColor = true;
            // 
            // chkOption
            // 
            this.chkOption.AutoSize = true;
            this.chkOption.Location = new System.Drawing.Point(441, 41);
            this.chkOption.Name = "chkOption";
            this.chkOption.Size = new System.Drawing.Size(50, 16);
            this.chkOption.TabIndex = 9;
            this.chkOption.Text = "ENG";
            this.chkOption.UseVisualStyleBackColor = true;
            // 
            // pnlRadioGroup
            // 
            this.pnlRadioGroup.Controls.Add(this.rbtDiv);
            this.pnlRadioGroup.Controls.Add(this.rbtMul);
            this.pnlRadioGroup.Controls.Add(this.rbtSub);
            this.pnlRadioGroup.Controls.Add(this.rbtAdd);
            this.pnlRadioGroup.Location = new System.Drawing.Point(13, 64);
            this.pnlRadioGroup.Name = "pnlRadioGroup";
            this.pnlRadioGroup.Size = new System.Drawing.Size(528, 46);
            this.pnlRadioGroup.TabIndex = 11;
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Location = new System.Drawing.Point(321, 15);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(59, 16);
            this.rbtDiv.TabIndex = 3;
            this.rbtDiv.TabStop = true;
            this.rbtDiv.Text = "나누기";
            this.rbtDiv.UseVisualStyleBackColor = true;
            // 
            // rbtMul
            // 
            this.rbtMul.AutoSize = true;
            this.rbtMul.Location = new System.Drawing.Point(214, 15);
            this.rbtMul.Name = "rbtMul";
            this.rbtMul.Size = new System.Drawing.Size(59, 16);
            this.rbtMul.TabIndex = 2;
            this.rbtMul.TabStop = true;
            this.rbtMul.Text = "곱하기";
            this.rbtMul.UseVisualStyleBackColor = true;
            // 
            // rbtSub
            // 
            this.rbtSub.AutoSize = true;
            this.rbtSub.Location = new System.Drawing.Point(107, 15);
            this.rbtSub.Name = "rbtSub";
            this.rbtSub.Size = new System.Drawing.Size(47, 16);
            this.rbtSub.TabIndex = 1;
            this.rbtSub.TabStop = true;
            this.rbtSub.Text = "빼기";
            this.rbtSub.UseVisualStyleBackColor = true;
            // 
            // rbtAdd
            // 
            this.rbtAdd.AutoSize = true;
            this.rbtAdd.Location = new System.Drawing.Point(4, 15);
            this.rbtAdd.Name = "rbtAdd";
            this.rbtAdd.Size = new System.Drawing.Size(59, 16);
            this.rbtAdd.TabIndex = 0;
            this.rbtAdd.TabStop = true;
            this.rbtAdd.Text = "더하기";
            this.rbtAdd.UseVisualStyleBackColor = true;
            // 
            // btnProcess01
            // 
            this.btnProcess01.Location = new System.Drawing.Point(13, 117);
            this.btnProcess01.Name = "btnProcess01";
            this.btnProcess01.Size = new System.Drawing.Size(75, 23);
            this.btnProcess01.TabIndex = 12;
            this.btnProcess01.Text = "연산 1";
            this.btnProcess01.UseVisualStyleBackColor = true;
            this.btnProcess01.Click += new System.EventHandler(this.btnProcess01_Click);
            // 
            // btnProcess02
            // 
            this.btnProcess02.Location = new System.Drawing.Point(120, 116);
            this.btnProcess02.Name = "btnProcess02";
            this.btnProcess02.Size = new System.Drawing.Size(75, 23);
            this.btnProcess02.TabIndex = 13;
            this.btnProcess02.Text = "연산 2";
            this.btnProcess02.UseVisualStyleBackColor = true;
            this.btnProcess02.Click += new System.EventHandler(this.btnProcess02_Click);
            // 
            // btnProcess03
            // 
            this.btnProcess03.Location = new System.Drawing.Point(227, 117);
            this.btnProcess03.Name = "btnProcess03";
            this.btnProcess03.Size = new System.Drawing.Size(75, 23);
            this.btnProcess03.TabIndex = 14;
            this.btnProcess03.Text = "연산 3";
            this.btnProcess03.UseVisualStyleBackColor = true;
            // 
            // btnProcess04
            // 
            this.btnProcess04.Location = new System.Drawing.Point(334, 117);
            this.btnProcess04.Name = "btnProcess04";
            this.btnProcess04.Size = new System.Drawing.Size(75, 23);
            this.btnProcess04.TabIndex = 15;
            this.btnProcess04.Text = "연산 4";
            this.btnProcess04.UseVisualStyleBackColor = true;
            // 
            // btnProcess05
            // 
            this.btnProcess05.Location = new System.Drawing.Point(441, 117);
            this.btnProcess05.Name = "btnProcess05";
            this.btnProcess05.Size = new System.Drawing.Size(75, 23);
            this.btnProcess05.TabIndex = 16;
            this.btnProcess05.Text = "연산 5";
            this.btnProcess05.UseVisualStyleBackColor = true;
            // 
            // btnProcess10
            // 
            this.btnProcess10.Location = new System.Drawing.Point(441, 146);
            this.btnProcess10.Name = "btnProcess10";
            this.btnProcess10.Size = new System.Drawing.Size(75, 23);
            this.btnProcess10.TabIndex = 21;
            this.btnProcess10.UseVisualStyleBackColor = true;
            // 
            // btnProcess09
            // 
            this.btnProcess09.Location = new System.Drawing.Point(334, 146);
            this.btnProcess09.Name = "btnProcess09";
            this.btnProcess09.Size = new System.Drawing.Size(75, 23);
            this.btnProcess09.TabIndex = 20;
            this.btnProcess09.UseVisualStyleBackColor = true;
            // 
            // btnProcess08
            // 
            this.btnProcess08.Location = new System.Drawing.Point(227, 146);
            this.btnProcess08.Name = "btnProcess08";
            this.btnProcess08.Size = new System.Drawing.Size(75, 23);
            this.btnProcess08.TabIndex = 19;
            this.btnProcess08.Text = "얼마 3";
            this.btnProcess08.UseVisualStyleBackColor = true;
            // 
            // btnProcess07
            // 
            this.btnProcess07.Location = new System.Drawing.Point(120, 145);
            this.btnProcess07.Name = "btnProcess07";
            this.btnProcess07.Size = new System.Drawing.Size(75, 23);
            this.btnProcess07.TabIndex = 18;
            this.btnProcess07.Text = "얼마 2";
            this.btnProcess07.UseVisualStyleBackColor = true;
            // 
            // btnProcess06
            // 
            this.btnProcess06.Location = new System.Drawing.Point(13, 146);
            this.btnProcess06.Name = "btnProcess06";
            this.btnProcess06.Size = new System.Drawing.Size(75, 23);
            this.btnProcess06.TabIndex = 17;
            this.btnProcess06.Text = "얼마 1";
            this.btnProcess06.UseVisualStyleBackColor = true;
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "아메리카노",
            "카페라떼",
            "플랫화이트"});
            this.cmbBeverage.Location = new System.Drawing.Point(12, 194);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(121, 20);
            this.cmbBeverage.TabIndex = 22;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(15, 245);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(946, 274);
            this.lblResult.TabIndex = 23;
            // 
            // chkIce
            // 
            this.chkIce.AutoSize = true;
            this.chkIce.Location = new System.Drawing.Point(147, 196);
            this.chkIce.Name = "chkIce";
            this.chkIce.Size = new System.Drawing.Size(48, 16);
            this.chkIce.TabIndex = 24;
            this.chkIce.Text = "얼음";
            this.chkIce.UseVisualStyleBackColor = true;
            // 
            // FormWeek3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 552);
            this.Controls.Add(this.chkIce);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.btnProcess10);
            this.Controls.Add(this.btnProcess09);
            this.Controls.Add(this.btnProcess08);
            this.Controls.Add(this.btnProcess07);
            this.Controls.Add(this.btnProcess06);
            this.Controls.Add(this.btnProcess05);
            this.Controls.Add(this.btnProcess04);
            this.Controls.Add(this.btnProcess03);
            this.Controls.Add(this.btnProcess02);
            this.Controls.Add(this.btnProcess01);
            this.Controls.Add(this.pnlRadioGroup);
            this.Controls.Add(this.chkOption);
            this.Controls.Add(this.chkDiv);
            this.Controls.Add(this.chkMul);
            this.Controls.Add(this.chkSub);
            this.Controls.Add(this.chkAdd);
            this.Controls.Add(this.tbxData5);
            this.Controls.Add(this.tbxData4);
            this.Controls.Add(this.tbxData3);
            this.Controls.Add(this.tbxData2);
            this.Controls.Add(this.tbxData1);
            this.Name = "FormWeek3";
            this.Text = "Form1";
            this.pnlRadioGroup.ResumeLayout(false);
            this.pnlRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxData1;
        private System.Windows.Forms.TextBox tbxData2;
        private System.Windows.Forms.TextBox tbxData3;
        private System.Windows.Forms.TextBox tbxData4;
        private System.Windows.Forms.TextBox tbxData5;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkDiv;
        private System.Windows.Forms.CheckBox chkOption;
        private System.Windows.Forms.Panel pnlRadioGroup;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.RadioButton rbtMul;
        private System.Windows.Forms.RadioButton rbtSub;
        private System.Windows.Forms.RadioButton rbtAdd;
        private System.Windows.Forms.Button btnProcess01;
        private System.Windows.Forms.Button btnProcess02;
        private System.Windows.Forms.Button btnProcess03;
        private System.Windows.Forms.Button btnProcess04;
        private System.Windows.Forms.Button btnProcess05;
        private System.Windows.Forms.Button btnProcess10;
        private System.Windows.Forms.Button btnProcess09;
        private System.Windows.Forms.Button btnProcess08;
        private System.Windows.Forms.Button btnProcess07;
        private System.Windows.Forms.Button btnProcess06;
        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkIce;
    }
}

