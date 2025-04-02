namespace Week04HomeWork
{
    partial class FormManager
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
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.tbxBirthYear = new System.Windows.Forms.TextBox();
            this.BirthYear = new System.Windows.Forms.Label();
            this.tbxBirthMonth = new System.Windows.Forms.TextBox();
            this.lblBirthMonth = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.tbxBirthDay = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.tbxAdvisor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbRegStatus = new System.Windows.Forms.ComboBox();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbxArray = new System.Windows.Forms.ListBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lbxDictionary = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgDepartment = new System.Windows.Forms.TabPage();
            this.tpgProfessor = new System.Windows.Forms.TabPage();
            this.tpgStudent = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDepartmentCode = new System.Windows.Forms.TextBox();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxDepartment = new System.Windows.Forms.ListBox();
            this.btnRegisterDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProfessorDepartment = new System.Windows.Forms.ComboBox();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.lbxProfessor = new System.Windows.Forms.ListBox();
            this.btnRegisterProfessor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxProfessorNumber = new System.Windows.Forms.TextBox();
            this.tbxProfessorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpgDepartment.SuspendLayout();
            this.tpgProfessor.SuspendLayout();
            this.tpgStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNumber
            // 
            this.tbxNumber.BackColor = System.Drawing.Color.White;
            this.tbxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNumber.Location = new System.Drawing.Point(87, 14);
            this.tbxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 21);
            this.tbxNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(6, 14);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 20);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "학번";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(214, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.White;
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Location = new System.Drawing.Point(294, 16);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 21);
            this.tbxName.TabIndex = 2;
            // 
            // lblBirth
            // 
            this.lblBirth.Location = new System.Drawing.Point(6, 54);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(60, 20);
            this.lblBirth.TabIndex = 5;
            this.lblBirth.Text = "생년월일";
            this.lblBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthYear
            // 
            this.tbxBirthYear.BackColor = System.Drawing.Color.White;
            this.tbxBirthYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBirthYear.Location = new System.Drawing.Point(87, 54);
            this.tbxBirthYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthYear.Name = "tbxBirthYear";
            this.tbxBirthYear.Size = new System.Drawing.Size(100, 21);
            this.tbxBirthYear.TabIndex = 4;
            // 
            // BirthYear
            // 
            this.BirthYear.Location = new System.Drawing.Point(192, 54);
            this.BirthYear.Name = "BirthYear";
            this.BirthYear.Size = new System.Drawing.Size(36, 20);
            this.BirthYear.TabIndex = 6;
            this.BirthYear.Text = "년";
            this.BirthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthMonth
            // 
            this.tbxBirthMonth.BackColor = System.Drawing.Color.White;
            this.tbxBirthMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBirthMonth.Location = new System.Drawing.Point(233, 56);
            this.tbxBirthMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthMonth.Name = "tbxBirthMonth";
            this.tbxBirthMonth.Size = new System.Drawing.Size(46, 21);
            this.tbxBirthMonth.TabIndex = 7;
            // 
            // lblBirthMonth
            // 
            this.lblBirthMonth.Location = new System.Drawing.Point(284, 56);
            this.lblBirthMonth.Name = "lblBirthMonth";
            this.lblBirthMonth.Size = new System.Drawing.Size(36, 20);
            this.lblBirthMonth.TabIndex = 8;
            this.lblBirthMonth.Text = "월";
            this.lblBirthMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.Location = new System.Drawing.Point(376, 56);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(36, 20);
            this.lblBirthDay.TabIndex = 10;
            this.lblBirthDay.Text = "일";
            this.lblBirthDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxBirthDay
            // 
            this.tbxBirthDay.BackColor = System.Drawing.Color.White;
            this.tbxBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBirthDay.Location = new System.Drawing.Point(325, 56);
            this.tbxBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthDay.Name = "tbxBirthDay";
            this.tbxBirthDay.Size = new System.Drawing.Size(46, 21);
            this.tbxBirthDay.TabIndex = 9;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(6, 88);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(60, 20);
            this.lblDepartment.TabIndex = 11;
            this.lblDepartment.Text = "소속학과";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(87, 89);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(308, 20);
            this.cmbDepartment.TabIndex = 12;
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.Location = new System.Drawing.Point(6, 124);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(60, 20);
            this.lblAdvisor.TabIndex = 13;
            this.lblAdvisor.Text = "지도교수";
            this.lblAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxAdvisor
            // 
            this.tbxAdvisor.BackColor = System.Drawing.Color.White;
            this.tbxAdvisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAdvisor.Location = new System.Drawing.Point(87, 127);
            this.tbxAdvisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAdvisor.Name = "tbxAdvisor";
            this.tbxAdvisor.Size = new System.Drawing.Size(307, 21);
            this.tbxAdvisor.TabIndex = 14;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(6, 160);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(46, 20);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "학년";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(87, 162);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(100, 20);
            this.cmbYear.TabIndex = 16;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(294, 164);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(100, 20);
            this.cmbClass.TabIndex = 18;
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(214, 162);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 20);
            this.lblClass.TabIndex = 17;
            this.lblClass.Text = "분반";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRegStatus
            // 
            this.cmbRegStatus.FormattingEnabled = true;
            this.cmbRegStatus.Location = new System.Drawing.Point(87, 196);
            this.cmbRegStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRegStatus.Name = "cmbRegStatus";
            this.cmbRegStatus.Size = new System.Drawing.Size(100, 20);
            this.cmbRegStatus.TabIndex = 20;
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.Location = new System.Drawing.Point(6, 194);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(60, 20);
            this.lblRegStatus.TabIndex = 19;
            this.lblRegStatus.Text = "재적상태";
            this.lblRegStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = System.Drawing.Color.White;
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddress.Location = new System.Drawing.Point(87, 228);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(307, 21);
            this.tbxAddress.TabIndex = 22;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(6, 226);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 20);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "주소";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxContact
            // 
            this.tbxContact.BackColor = System.Drawing.Color.White;
            this.tbxContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxContact.Location = new System.Drawing.Point(87, 264);
            this.tbxContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(307, 21);
            this.tbxContact.TabIndex = 24;
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(6, 264);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 20);
            this.lblContact.TabIndex = 23;
            this.lblContact.Text = "연락처";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(9, 304);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(66, 44);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(87, 304);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(307, 44);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.ItemHeight = 12;
            this.lbxArray.Location = new System.Drawing.Point(410, 16);
            this.lbxArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(125, 100);
            this.lbxArray.TabIndex = 27;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 12;
            this.lbxList.Location = new System.Drawing.Point(410, 134);
            this.lbxList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(125, 100);
            this.lbxList.TabIndex = 28;
            // 
            // lbxDictionary
            // 
            this.lbxDictionary.FormattingEnabled = true;
            this.lbxDictionary.ItemHeight = 12;
            this.lbxDictionary.Location = new System.Drawing.Point(410, 245);
            this.lbxDictionary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxDictionary.Name = "lbxDictionary";
            this.lbxDictionary.Size = new System.Drawing.Size(125, 100);
            this.lbxDictionary.TabIndex = 29;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgDepartment);
            this.tabMain.Controls.Add(this.tpgProfessor);
            this.tabMain.Controls.Add(this.tpgStudent);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(64, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(560, 402);
            this.tabMain.TabIndex = 30;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tpgDepartment
            // 
            this.tpgDepartment.Controls.Add(this.btnRemoveDepartment);
            this.tpgDepartment.Controls.Add(this.lbxDepartment);
            this.tpgDepartment.Controls.Add(this.btnRegisterDepartment);
            this.tpgDepartment.Controls.Add(this.label1);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentCode);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentName);
            this.tpgDepartment.Controls.Add(this.label2);
            this.tpgDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpgDepartment.Name = "tpgDepartment";
            this.tpgDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDepartment.Size = new System.Drawing.Size(552, 364);
            this.tpgDepartment.TabIndex = 0;
            this.tpgDepartment.Text = "학과정보";
            this.tpgDepartment.UseVisualStyleBackColor = true;
            // 
            // tpgProfessor
            // 
            this.tpgProfessor.Controls.Add(this.btnRemoveProfessor);
            this.tpgProfessor.Controls.Add(this.lbxProfessor);
            this.tpgProfessor.Controls.Add(this.btnRegisterProfessor);
            this.tpgProfessor.Controls.Add(this.label4);
            this.tpgProfessor.Controls.Add(this.tbxProfessorNumber);
            this.tpgProfessor.Controls.Add(this.tbxProfessorName);
            this.tpgProfessor.Controls.Add(this.label5);
            this.tpgProfessor.Controls.Add(this.label3);
            this.tpgProfessor.Controls.Add(this.cmbProfessorDepartment);
            this.tpgProfessor.Location = new System.Drawing.Point(4, 34);
            this.tpgProfessor.Name = "tpgProfessor";
            this.tpgProfessor.Padding = new System.Windows.Forms.Padding(3);
            this.tpgProfessor.Size = new System.Drawing.Size(552, 364);
            this.tpgProfessor.TabIndex = 1;
            this.tpgProfessor.Text = "교수정보";
            this.tpgProfessor.UseVisualStyleBackColor = true;
            // 
            // tpgStudent
            // 
            this.tpgStudent.Controls.Add(this.lblNumber);
            this.tpgStudent.Controls.Add(this.lbxDictionary);
            this.tpgStudent.Controls.Add(this.tbxNumber);
            this.tpgStudent.Controls.Add(this.lbxList);
            this.tpgStudent.Controls.Add(this.tbxName);
            this.tpgStudent.Controls.Add(this.lbxArray);
            this.tpgStudent.Controls.Add(this.lblName);
            this.tpgStudent.Controls.Add(this.btnRegister);
            this.tpgStudent.Controls.Add(this.tbxBirthYear);
            this.tpgStudent.Controls.Add(this.btnNew);
            this.tpgStudent.Controls.Add(this.lblBirth);
            this.tpgStudent.Controls.Add(this.tbxContact);
            this.tpgStudent.Controls.Add(this.BirthYear);
            this.tpgStudent.Controls.Add(this.lblContact);
            this.tpgStudent.Controls.Add(this.tbxBirthMonth);
            this.tpgStudent.Controls.Add(this.tbxAddress);
            this.tpgStudent.Controls.Add(this.lblBirthMonth);
            this.tpgStudent.Controls.Add(this.lblAddress);
            this.tpgStudent.Controls.Add(this.tbxBirthDay);
            this.tpgStudent.Controls.Add(this.cmbRegStatus);
            this.tpgStudent.Controls.Add(this.lblBirthDay);
            this.tpgStudent.Controls.Add(this.lblRegStatus);
            this.tpgStudent.Controls.Add(this.lblDepartment);
            this.tpgStudent.Controls.Add(this.cmbClass);
            this.tpgStudent.Controls.Add(this.cmbDepartment);
            this.tpgStudent.Controls.Add(this.lblClass);
            this.tpgStudent.Controls.Add(this.lblAdvisor);
            this.tpgStudent.Controls.Add(this.cmbYear);
            this.tpgStudent.Controls.Add(this.tbxAdvisor);
            this.tpgStudent.Controls.Add(this.lblYear);
            this.tpgStudent.Location = new System.Drawing.Point(4, 34);
            this.tpgStudent.Name = "tpgStudent";
            this.tpgStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStudent.Size = new System.Drawing.Size(552, 364);
            this.tpgStudent.TabIndex = 2;
            this.tpgStudent.Text = "학생정보";
            this.tpgStudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "학과코드";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxDepartmentCode
            // 
            this.tbxDepartmentCode.BackColor = System.Drawing.Color.White;
            this.tbxDepartmentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDepartmentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDepartmentCode.Location = new System.Drawing.Point(89, 14);
            this.tbxDepartmentCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDepartmentCode.Name = "tbxDepartmentCode";
            this.tbxDepartmentCode.Size = new System.Drawing.Size(100, 21);
            this.tbxDepartmentCode.TabIndex = 4;
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.BackColor = System.Drawing.Color.White;
            this.tbxDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDepartmentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDepartmentName.Location = new System.Drawing.Point(88, 43);
            this.tbxDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(100, 21);
            this.tbxDepartmentName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "학과이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxDepartment
            // 
            this.lbxDepartment.FormattingEnabled = true;
            this.lbxDepartment.ItemHeight = 12;
            this.lbxDepartment.Location = new System.Drawing.Point(10, 92);
            this.lbxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxDepartment.Name = "lbxDepartment";
            this.lbxDepartment.Size = new System.Drawing.Size(527, 208);
            this.lbxDepartment.TabIndex = 29;
            // 
            // btnRegisterDepartment
            // 
            this.btnRegisterDepartment.BackColor = System.Drawing.Color.White;
            this.btnRegisterDepartment.Location = new System.Drawing.Point(195, 14);
            this.btnRegisterDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterDepartment.Name = "btnRegisterDepartment";
            this.btnRegisterDepartment.Size = new System.Drawing.Size(84, 50);
            this.btnRegisterDepartment.TabIndex = 28;
            this.btnRegisterDepartment.Text = "등록";
            this.btnRegisterDepartment.UseVisualStyleBackColor = false;
            this.btnRegisterDepartment.Click += new System.EventHandler(this.btnRegisterDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.BackColor = System.Drawing.Color.White;
            this.btnRemoveDepartment.Location = new System.Drawing.Point(453, 309);
            this.btnRemoveDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(84, 50);
            this.btnRemoveDepartment.TabIndex = 30;
            this.btnRemoveDepartment.Text = "삭제";
            this.btnRemoveDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "소속학과";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProfessorDepartment
            // 
            this.cmbProfessorDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessorDepartment.FormattingEnabled = true;
            this.cmbProfessorDepartment.Location = new System.Drawing.Point(89, 16);
            this.cmbProfessorDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProfessorDepartment.Name = "cmbProfessorDepartment";
            this.cmbProfessorDepartment.Size = new System.Drawing.Size(308, 20);
            this.cmbProfessorDepartment.TabIndex = 14;
            this.cmbProfessorDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbProfessorDepartment_SelectedIndexChanged);
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.BackColor = System.Drawing.Color.White;
            this.btnRemoveProfessor.Location = new System.Drawing.Point(453, 307);
            this.btnRemoveProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(84, 50);
            this.btnRemoveProfessor.TabIndex = 37;
            this.btnRemoveProfessor.Text = "삭제";
            this.btnRemoveProfessor.UseVisualStyleBackColor = false;
            // 
            // lbxProfessor
            // 
            this.lbxProfessor.FormattingEnabled = true;
            this.lbxProfessor.ItemHeight = 12;
            this.lbxProfessor.Location = new System.Drawing.Point(10, 110);
            this.lbxProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxProfessor.Name = "lbxProfessor";
            this.lbxProfessor.Size = new System.Drawing.Size(527, 184);
            this.lbxProfessor.TabIndex = 36;
            // 
            // btnRegisterProfessor
            // 
            this.btnRegisterProfessor.BackColor = System.Drawing.Color.White;
            this.btnRegisterProfessor.Location = new System.Drawing.Point(195, 44);
            this.btnRegisterProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterProfessor.Name = "btnRegisterProfessor";
            this.btnRegisterProfessor.Size = new System.Drawing.Size(84, 50);
            this.btnRegisterProfessor.TabIndex = 35;
            this.btnRegisterProfessor.Text = "등록";
            this.btnRegisterProfessor.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "학과코드";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxProfessorNumber
            // 
            this.tbxProfessorNumber.BackColor = System.Drawing.Color.White;
            this.tbxProfessorNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProfessorNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxProfessorNumber.Location = new System.Drawing.Point(89, 44);
            this.tbxProfessorNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxProfessorNumber.Name = "tbxProfessorNumber";
            this.tbxProfessorNumber.Size = new System.Drawing.Size(100, 21);
            this.tbxProfessorNumber.TabIndex = 31;
            // 
            // tbxProfessorName
            // 
            this.tbxProfessorName.BackColor = System.Drawing.Color.White;
            this.tbxProfessorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProfessorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxProfessorName.Location = new System.Drawing.Point(88, 73);
            this.tbxProfessorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxProfessorName.Name = "tbxProfessorName";
            this.tbxProfessorName.Size = new System.Drawing.Size(100, 21);
            this.tbxProfessorName.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "학과이름";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 402);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManager";
            this.Text = "학생관리";
            this.tabMain.ResumeLayout(false);
            this.tpgDepartment.ResumeLayout(false);
            this.tpgDepartment.PerformLayout();
            this.tpgProfessor.ResumeLayout(false);
            this.tpgProfessor.PerformLayout();
            this.tpgStudent.ResumeLayout(false);
            this.tpgStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox tbxBirthYear;
        private System.Windows.Forms.Label BirthYear;
        private System.Windows.Forms.TextBox tbxBirthMonth;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.TextBox tbxBirthDay;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.TextBox tbxAdvisor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbRegStatus;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lbxArray;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.ListBox lbxDictionary;
        private System.Windows.Forms.Label lblBirthMonth;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgDepartment;
        private System.Windows.Forms.TabPage tpgProfessor;
        private System.Windows.Forms.TabPage tpgStudent;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.ListBox lbxDepartment;
        private System.Windows.Forms.Button btnRegisterDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDepartmentCode;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.ListBox lbxProfessor;
        private System.Windows.Forms.Button btnRegisterProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxProfessorNumber;
        private System.Windows.Forms.TextBox tbxProfessorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProfessorDepartment;
    }
}

