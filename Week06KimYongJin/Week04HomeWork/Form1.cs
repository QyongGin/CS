using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Week04HomeWork
{
    public partial class FormManager : Form
    {
        // 인스턴스 필드(변수), 멤버변수
        // 전역변수 class 안, method 밖에 선언.
        Department[] departments;
        List<Professor> professors;
        Dictionary<string,Student> students; // 제네릭 -> <> Dictionary 키, 밸류 2022/44092 숫자 x 문자열 -> 

        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        

        // 생성자
        // 인스턴스 생성시 초기화가 필요한 코드를 넣어준다.
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();

            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[] {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9,
            };

            cmbYear.Items.Add(1); // Items는 어떤 형이든 받아들인다.
            cmbYear.Items.Add(2);
            cmbYear.Items.Add(3);
            cmbYear.Items.Add(4);

            cmbClass.Items.Add("A");
            cmbClass.Items.Add("B");
            cmbClass.Items.Add("C");

            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");
        }


        private void btnRegisterDepartment_Click(object sender, EventArgs e) // 등록
        {

            if (tbxDepartmentCode == null) //(구현)학과코드가 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다.
            {
                MessageBox.Show("학과코드가 비어있습니다.");
                tbxDepartmentCode.Focus();
            }
            if (tbxDepartmentName == null) //(구현)학과이름이 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다.
            {
                MessageBox.Show("학과이름이 비어있습니다.");
                tbxDepartmentCode.Focus();
            }

            int index = -1; // index의 값이 0이라면 공간이 없어도 0으로 나와 알지 못한다. -1로 설정하여 공간이 없다면 여전히 -1로 인지하게두자.
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i] == null)
                { // 빈 index 찾기.
                    if (index < 0)
                    {
                        index = i;

                    }
                }
                else
                {
                    if (departments[i].Code == tbxDepartmentCode.Text)
                    { // 현재 학과코드에 입력한 값과 departments에 저장된 i번째 요소가 같다면, 중복이라면
                        MessageBox.Show("동일한 코드는 사용이 불가능합니다."); //(구현)동일한 코드는 사용이 불가능하다는 메시지를 띄우고 포커스 이동한다
                        tbxDepartmentCode.Focus();

                        return;
                    }
                }
            }

            if (index < 0)
            { // 초기값과 같다(-1) 빈공간을 찾지 못했음.
                MessageBox.Show("더 이상 신규 학과정보를 입력하실 수 없습니다.");
                return;
            }

            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept; // for문으로 찾은 빈공간에 데이터 저장.

            lbxDepartment.Items.Add(dept); // 여기서 Items는 lbx의 내부 데이터를 관리하는 속성이다. lbx 내부 데이터에 Add. dept 값을 추가한다. 그럼 lbx에 출력이 되겠지?

        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e) // 삭제
        {
            if (lbxDepartment.SelectedIndex < 0)
            { // lbx 화면에서 선택한 값의 index 가져오기. 
                MessageBox.Show("삭제할 학과를 선택해주세요."); // 선택하지 않음.
                return;
            }

            // is 연산자 , 타입 확인용으로 사용.
            if (lbxDepartment.SelectedItem is Department)
            { // Selected 니가 선택한게 Department 타입이 맞니?
                var target = (Department)lbxDepartment.SelectedItem;
                for (int i = 0; i < departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }

                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex); // RemoveAt() 해당 인덱스에 있는 요소 삭제.
                lbxDepartment.SelectedIndex = -1; // 초기화. 선택하지 않음.
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        { // 탭 전환
            switch (tabMain.SelectedIndex)
            { // 선택한 index 항목
                case 0: // 학과정보
                    break;
                case 1: // 교수정보
                    cmbProfessorDepartment.Items.Clear(); // cmb 비운다.
                    foreach (var department in departments)
                    { // var=department departments 요소를 가져와서 비교.
                        if (department != null)
                        { // department 데이터가 있다면 추가한다. 
                            cmbProfessorDepartment.Items.Add(department); //콤보박스,리스트 유사.
                        }
                        cmbProfessorDepartment.SelectedIndex = -1;
                        lbxProfessor.Items.Clear();
                    }
                    break;
                case 2: // 학생정보
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                        cmbProfessorDepartment.SelectedIndex = -1;
                    }
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbxProfessor.Items.Clear();

            // as 형변환 연산자.
            // 형변환이 정상적이지 않으면 null 반환.

            var department = cmbProfessorDepartment.SelectedItem as Department;

            if (department != null)
            { // C# null은 무조건 검사해야한다.
                foreach (var professor in professors)
                {
                    if (professor != null && professor.DepartmentCode == department.Code)
                    { // 실제 존재하는 과목인지 확인 후 교수 등록
                        // && 연산자는 첫 조건부터 검사하므로 null 체크는 먼저.
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            foreach (var professor in professors)
            {
                if (professor.Number != null && professor.Number == tbxProfessorNumber.Text)
                {
                    MessageBox.Show("중복된 교수번호입니다.");
                    tbxProfessorNumber.Focus();
                    return;
                }
            }

            Professor prof = new Professor();
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;
            prof.DepartmentCode = ((Department)cmbProfessorDepartment.SelectedItem).Code;  // 콤보박스에서 선택한 학과코드
            professors.Add(prof);  // 리스트에 교수 추가
            lbxProfessor.Items.Add(prof);


        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            var target = (Professor)lbxProfessor.SelectedItem;
            if (target == null)
            {
                MessageBox.Show("삭제할 교수 정보를 선택해주세요.");
                return;
            }

            if (lbxDepartment.SelectedItem is Professor)
            {
                var deltarget = (Professor)lbxProfessor.SelectedItem;

                foreach (var professor in professors)
                {
                    if (professor.Number != null && professor.Number == deltarget.Number)
                    {
                        professors.Remove(professor);
                        lbxProfessor.Items.Remove(deltarget);
                        break;
                    }
                }

                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex); // RemoveAt() 해당 인덱스에 있는 요소 삭제.
                lbxDepartment.SelectedIndex = -1; // 초기화. 선택하지 않음.
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmb index 변경시 소속학과 모든 교수정보를 지도교수 cmbAdvisor에 추가
            // 내가 선택한 index에 맞는 학과 교수 정보를 가져와야한다.
            cmbAdvisor.Items.Clear();
            if (cmbDepartment.SelectedItem is Department selectedDept)
            {
                foreach (var professor in professors)
                {
                    if (professor.DepartmentCode == selectedDept.Code)
                    {
                        cmbAdvisor.Items.Add(professor);  // 같은 학과 교수만 추가
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbxNumber.Text = "20";  // 학번
            tbxName.Clear();           // 이름
            tbxBirthYear.Text = "20";       // 생년
            tbxBirthMonth.Clear();          // 월
            tbxBirthDay.Clear();            // 일

            cmbDepartment.SelectedIndex = -1; // 소속학과
            cmbAdvisor.SelectedIndex = -1;  // 지도교수
            cmbYear.SelectedIndex = -1;      // 학년
            cmbClass.SelectedIndex = -1;      // 분반
            cmbRegStatus.SelectedIndex = -1;     // 재적상태


        }

        Student selectedStudent = null;
        private void btnRegister_Click(object sender, EventArgs e) {
            if(selectedStudent == null) {
                RegisterStudent(); // 구역이 너무 크면 메소드로 나누자.
            } else {
                UpdateStudent(); // call
            }
        }

        private void RegisterStudent() {
            // throw new NotImplementedException(); vs가 만들었다. 수정안하고 실행시 죽음.

            var number = tbxNumber.Text.Trim(); // Trim 공백제거

            // 실제 많이 사용하는 방법1
            if (true == students.ContainsKey(number)) { // ContainsKey 기본 타입은 True
                tbxNumber.Focus();
                return;
            }

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth; //,birthDay;

            // TryParse() -> bool타입 반환 형변환 시도.죽지않는다.
            // out ~ 결과를 birthYear에 반환. 래퍼런스값 준다. 포인터. true나 false를 반환해줄게. 저 변수에. -> 안되도 안죽는다. intparse 쓰지마.
            if (int.TryParse(tbxBirthYear.Text, out birthYear)) { 
                
            } else {
                return;
            }
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth)) {

            }
            else {
                return;
            }
            if (int.TryParse(tbxBirthDay.Text, out int birthDay)) { // out과 동시에 선언. vs 2022년에만 사용.

            }
            else {
                return;
            }

            // 현재 시스템 시간 Datetime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0) {
                // cmbDepartment.Focus();
                // return;
                student.DepartmentCode = null; // 자유학과 가능하면 null 학과가 무조건 있어야하면 return;
            } else {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code; // 오브젝트 타입 벗기고 Department로 변환
            }

            students[number] = student; // 딕셔너리에 데이터 추가 방법 1 (중복->덮어씌움)
            // students.Add(number, student); // 딕셔너리에 데이터 추가 방법 2 (비추)
            lbxDictionary.Items.Add(student); 
        }

        private void UpdateStudent() { //define
            throw new NotImplementedException();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e) {
            selectedStudent = (lbxDictionary.SelectedItem as Student);

            btnNew_Click(this, EventArgs.Empty); 

            if (selectedStudent != null) {
                DisplaySelectedStudent(selectedStudent);
            }
        }

        private void DisplaySelectedStudent(Student student) {
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e) {
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
        }

        private Student SearchStudentByNumber(string number) {
            if (students.ContainsKey (number)) {
                return students[number];
            } else {
                return null;
            }
        }
    }
}
