using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Week04HomeWork {
    public partial class FormManager : Form {
        // Revise
        // 인스턴스 필드(변수), 멤버변수
        // 전역변수 class 안, method 밖에 선언.
        Department[] departments; // Department 타입의 배열
        List<Professor> professors; // List<Professor> Professor 객체들을 저장하는 리스트 배열보다 유연, 동적으로 크기 조절
        Dictionary<string, Student> students; // 제네릭 -> <> Dictionary 키, 밸류 2022/44092 숫자 x 문자열. 키는 string, 값은 student 객체

        List<Grade> testGrades; // Grade 객체들의 리스트 
        TextBox[] tbxTestScores; // tbx를 배열로 관리하기 위한 변수
        Student selectedStudent = null;



        // 생성자
        // 인스턴스 생성시 초기화가 필요한 코드를 넣어준다.
        // 폼 생성시 자동 실행되므로 위 선언한 변수들을 사용가능하게 초기화시켜준다. 
        public FormManager() {
            InitializeComponent(); // UI요소 초기화
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

            for (int i = 1; i <= 4; i++) {
                cmbYear.Items.Add(i); // items은 어떤 형이든 받아들인다.
            }

            cmbClass.Items.AddRange(new object[] { "A", "B", "C" });
            // .Items 콤보박스 항목 목록 AddRange()  한 번에 추가 new object[] 배열 형태 {} 추가할 데이터 
            // 매개변수(파라미터) new object[] {} 배열 / new List<string>() {} 리스트 

            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");

            // 전공
            departments[0] = new Department() {
                Code = "A001",
                Name = "컴퓨터정보"
            };
            departments[1] = new Department() {
                Code = "A002",
                Name = "컴퓨터시스템"
            };
            for (int i = 0; i < departments.Length; i++) {
                if (departments[i] != null) {
                    lbxDepartment.Items.Add(departments[i]);
                }
            }

            // 교수님
            professors.Add(new Professor() {
                DepartmentCode = departments[0].Code,
                Number = "2020001",
                Name = "김인하"
            });
            professors.Add(new Professor() {
                DepartmentCode = departments[0].Code,
                Number = "2023003",
                Name = "김정석"
            });
            professors.Add(new Professor() {
                DepartmentCode = departments[1].Code,
                Number = "2023004",
                Name = "이공전"
            });

            // 학생
            students.Add("20240001", new Student() {
                Number = "20240001",
                Name = "김미영",
                RegStatus = "재학",
                Year = 1,
                BirthInfo = new DateTime(2004, 01, 01),
                DepartmentCode = "A001",
                AdvisorNumber = "2020001",
                Class = "B",
                Address = "인천 남구 용현동 100",
                Contact = "032-870-0000"
            });
            foreach (var student in students) {
                if (student.Value != null) {
                    lbxDictionary.Items.Add(student.Value);
                }
            }
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
            for (int i = 0; i < departments.Length; i++) {
                if (departments[i] == null) { // 빈 index 찾기.
                    if (index < 0) {
                        index = i;

                    }
                }
                else {
                    if (departments[i].Code == tbxDepartmentCode.Text) { // 현재 학과코드에 입력한 값과 departments에 저장된 i번째 요소가 같다면, 중복이라면
                        MessageBox.Show("동일한 코드는 사용이 불가능합니다."); //(구현)동일한 코드는 사용이 불가능하다는 메시지를 띄우고 포커스 이동한다
                        tbxDepartmentCode.Focus();

                        return;
                    }
                }
            }

            if (index < 0) { // 초기값과 같다(-1) 빈공간을 찾지 못했음.
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
            if (lbxDepartment.SelectedIndex < 0) { // lbx 화면에서 선택한 값의 index 가져오기. 
                MessageBox.Show("삭제할 학과를 선택해주세요."); // 선택하지 않음.
                return;
            }

            // is 연산자 , 타입 확인용으로 사용.
            if (lbxDepartment.SelectedItem is Department) { // Selected 니가 선택한게 Department 타입이 맞니?
                var target = (Department)lbxDepartment.SelectedItem;
                for (int i = 0; i < departments.Length; i++) {
                    if (departments[i] != null && departments[i] == target) {
                        departments[i] = null;
                        break;
                    }
                }

                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex); // RemoveAt() 해당 인덱스에 있는 요소 삭제.
                lbxDepartment.SelectedIndex = -1; // 초기화. 선택하지 않음.
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e) { // 탭 전환
            switch (tabMain.SelectedIndex) { // 선택한 index 항목
                case 0: // 학과정보
                    break;
                case 1: // 교수정보
                    cmbProfessorDepartment.Items.Clear(); // cmb 비운다.
                    foreach (var department in departments) // departments는 Department[]. var department는 departments 배열의 각 항목을 꺼내서 
                                                            // department라는 변수에 담는다. var는 자동으로 Department 타입으로 변환시켜주는 역할.
                    { // var=department departments 요소를 가져와서 비교.
                        if (department != null) { // department 데이터가 있다면 추가한다. 
                            cmbProfessorDepartment.Items.Add(department); //콤보박스,리스트 유사.
                        }
                        cmbProfessorDepartment.SelectedIndex = -1;
                        lbxProfessor.Items.Clear();
                    }
                    break;
                case 2: // 학생정보
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments) {
                        if (department != null) {
                            cmbDepartment.Items.Add(department);
                        }
                    }
                    ClearStudentInfo();
                    break;
                case 3:
                    //(숙제) 성적처리(TEST)의 모든 Control을 지우는 내용을 만들 것
                    ClearTestScoreInfo();
                    break;
                default:
                    break;
            }
        }


        private void ClearStudentInfo() {
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty; // Text,Label,String 다 string.Empty로 초기화가 가능하므로 통일화 시키기 위해 string.Empty를 선호한다. 기능적으로는 clear와 같다.
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";

            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;

            tbxAddress.Text = string.Empty;
            tbxContact.Text = string.Empty;

            //(숙제)
            //tbxNumber의 읽기전용을 해제한다.
            tbxNumber.ReadOnly = false;
            //SelectedStudent를 초기화 한다.
            selectedStudent = null;
            //btnRegister의 글자를 "등록"으로 설정한다.
            btnRegister.Text = "등록";
            //lbxDictionary의 선택을 초기화 한다.
            lbxDictionary.ClearSelected(); // ()는 메소드(함수)라 붙인다. 메소드는 실행을 담당. ()가 없는건 속성. 값만 있음.
            // 메소드는 선택된 항목을 ㅇㅇ해라. 라는 뜻이므로. ()안에 무엇이 들어갈지 필요해서 ()가 필요하다.
            // ClearSelected는 행동 이름 ()는 그 녀석에게 실행해.
        }
        private void ClearTestScoreInfo() {
            tbxTestNumber.Text = "";
            lblTestName.Text = "";
            lblTestTotalCount.Text = "";
            lblTestAverage.Text = "";
            for (int i = 0; i < tbxTestScores.Length; i++) {
                tbxTestScores[i].Text = "";
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e) {

            lbxProfessor.Items.Clear();

            // as 형변환 연산자.
            // 형변환이 정상적이지 않으면 null 반환.

            var department = cmbProfessorDepartment.SelectedItem as Department;

            if (department != null) { // C# null은 무조건 검사해야한다.
                foreach (var professor in professors) {
                    if (professor != null && professor.DepartmentCode == department.Code) { // 실제 존재하는 과목인지 확인 후 교수 등록
                        // && 연산자는 첫 조건부터 검사하므로 null 체크는 먼저.
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e) {
            if (cmbProfessorDepartment.SelectedIndex < 0) {
                MessageBox.Show("학과를 선택해주세요.");
                cmbProfessorDepartment.Focus();
                return;
            }

            if (false == cmbProfessorDepartment.SelectedItem is Department dept) // item과 Department 타입을 비교하고(타입만검사) 객체 참조를 dept 변수에 담는다.
            {
                MessageBox.Show("학과정보에 이상 발생 Department 타입만 들어가야 합니다.");
                return;
            }

            if (tbxProfessorNumber.Text == null) {
                MessageBox.Show("교수번호를 입력해 주세요.");
                tbxProfessorNumber.Focus();
                return;
            }

            if (tbxProfessorName.Text == null) {
                MessageBox.Show("교수이름을 입력해 주세요.");
                tbxProfessorName.Focus();
                return;
            }

            foreach (var professor in professors) {
                if (professor.Number != null && professor.Number == tbxProfessorNumber.Text) {
                    MessageBox.Show("중복된 교수번호입니다.");
                    tbxProfessorNumber.Focus();
                    return;
                }
            }

            Professor prof = new Professor(); // prof는 Professor 타입 새 객체다. 이는 즉, Professor 타입만 저장할 수 있는 professors에 저장 가능하다.
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;
            prof.DepartmentCode = ((Department)cmbProfessorDepartment.SelectedItem).Code;  // 콤보박스에서 선택한 학과코드는 items->object타입이다. Department 타입으로 캐스팅, .Code값 꺼내기.
            professors.Add(prof);  // 리스트에 교수 추가
            lbxProfessor.Items.Add(prof);


        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e) {
            if (lbxProfessor.SelectedIndex < 0) {
                MessageBox.Show("삭제할 교수 정보를 선택해 주세요.");
                return;
            }

            if (lbxProfessor.SelectedItem is Professor) // 선택했는지+Professor타입인지 둘다 검사. stirng이나 다른타입, Null이 들어갈수도 있으니.
            {
                var target = (Professor)lbxProfessor.SelectedItem; // 바로 lbxProfessor.SelectedItem써도 되지만 확실하게 명시. or 가독성

                foreach (var professor in professors) {
                    if (professor.Number != null && professor.Number == target.Number) {
                        professors.Remove(professor); // 데이터 처리
                        break;
                    }
                }
                lbxProfessor.Items.Remove(target); // 로직분리 (데이터따로, UI따로 관리하기 위해) UI삭제는 가독성을 위해 foreach 밖에서 진행함.
                lbxProfessor.SelectedIndex = -1; // 역할을 분리하는건 좋은 습관이다.
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            // cmb index 변경시 소속학과 모든 교수정보를 지도교수 cmbAdvisor에 추가

            cmbAdvisor.Items.Clear();
            if (cmbDepartment.SelectedItem is Department dept) // var target = ((Department)cmbDepartment.SelectedItem).Code; 이 코드를 교수님은 dept라는 변수에 저장하게끔 해서 간소화함.
            {

                foreach (var professor in professors) {
                    if (professor != null && dept.Code == professor.DepartmentCode) {
                        cmbAdvisor.Items.Add(professor);
                    }
                }
            }
            cmbAdvisor.SelectedIndex = -1;


        }

        private void btnNew_Click(object sender, EventArgs e) {
            ClearStudentInfo();
        }


        private void btnRegister_Click(object sender, EventArgs e) {
            if (selectedStudent == null) {
                RegisterStudent(); // 구역이 너무 크면 메소드로 나누자.
            } else {
                UpdateStudent(); // call
            }
        }

        private void RegisterStudent() {
            // throw new NotImplementedException(); vs가 만들었다. 수정안하고 실행시 죽음.
            //(숙제)
            //학번이 비었거나 8자리가 아닌 경우 처리하지 않는다.
            //이름이 비었거나 2자 미만인 경우 처리하지 않는다.

            if (tbxNumber.Text == "" || tbxNumber.Text.Length != 8) // .text가 빈 문자열을 반환한다.
            {
                MessageBox.Show("8자리 형식의 학번을 입력해 주세요.");
                tbxNumber.Focus();
                return;
            }
            if (tbxName.Text == "" || tbxName.Text.Length < 2) {
                MessageBox.Show("이름이 비었거나 2자 미만입니다.");
                tbxName.Focus();
                return;
            }

            var number = tbxNumber.Text.Trim(); // Trim 공백제거

            // 수정일 때 생각해서 학번을 못 바꾸는 상황 고려. 
            if (tbxNumber.ReadOnly == false) {
                if (true == students.ContainsKey(number))// 실제 많이 사용하는 방법1
                { // ContainsKey 기본 타입은 True
                  // ContainsKey(number) 내가 입력한 학번으로 존재한다면 true값을 반환.
                    MessageBox.Show("이미 입력한 학번입니다.");
                    tbxNumber.Focus();
                    return; // 아예 이 메소드를 종료.
                }
            }



            // 중복되지 않고 올바른 입력을 했다면
            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth; //,birthDay;

            // TryParse() -> bool타입 반환 형변환 시도.죽지않는다. if문에 성공과 실패 여부를 true flase를 반환한다.
            // 그 후 out birthYear(저장할 변수)에 변환한 값, int로 변환 성공 시 값을 저장한다.
            if (int.TryParse(tbxBirthYear.Text, out birthYear)) {
                // (숙제)유효숫자확인 : 1900~9000
                if (birthYear < 1900 || birthYear > 9000) // 어차피 Datetime으로 저장할거라 else가 불필요하다 판단. 조건이 옳다고 해서 할 게 없음.
                {
                    MessageBox.Show("출생년도가 이상해요!");
                    tbxBirthYear.Focus();
                    return;
                }
            }
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth)) {
                //(숙제)유효숫자확인 : 1~12
                if (birthMonth < 1 || birthMonth > 12) {
                    MessageBox.Show("1월부터 12월까지 가능합니다. 잘못입력하셨어요.");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            if (int.TryParse(tbxBirthDay.Text, out int birthDay)) { // out과 동시에 선언. vs 2022년에만 사용.
                //(숙제)유효숫자확인 : 1~31
                if (birthDay < 1 || birthDay > 31) {
                    MessageBox.Show("1일부터 31일까지 가능합니다. 잘못입력하셨어요.");
                    tbxBirthDay.Focus();
                    return;
                }
            }


            // 현재 시스템 시간 Datetime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay); // 위에 out으로 저장한 생년월일을 Datetime 자료형으로 저장.
            // Datetime 타입은 년 월 일 시 분 초 순서대로 저장한다. birthYear부터 입력했으니 자동으로 .Year 속성에 저장이됨.

            if (cmbDepartment.SelectedIndex < 0) {
                // cmbDepartment.Focus();
                // return;
                student.DepartmentCode = null; // 자유학과 가능하면 null 학과가 무조건 있어야하면 return;
            } else {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code; // 오브젝트 타입 벗기고 Department로 변환
            }

            //(숙제)
            //지도교수를 설정한다. 선택한 지도교수가 없으면 null처리한다.
            if (cmbAdvisor.SelectedIndex < 0) {
                student.AdvisorNumber = null;
            }
            else {
                student.AdvisorNumber = ((Professor)cmbAdvisor.SelectedItem).Number;
            }
            //학년을 설정한다. 선택한 학년이 없으면 진행하지 않는다.
            if (cmbYear.SelectedIndex < 0) {
                MessageBox.Show("학년을 선택해 주세요.");
                cmbYear.Focus();
                return;
            }
            else {
                student.Year = ((int)cmbYear.SelectedItem); // object는 큰요소. int라는 작은 요소안에 들어가게 바꿔주자.
            }
            //반을 설정한다. 선택한 반이 없으면 진행하지 않는다.
            if (cmbClass.SelectedIndex < 0) {
                MessageBox.Show("반을 선택해 주세요.");
                cmbClass.Focus();
                return;
            }
            else {
                student.Class = ((string)cmbClass.SelectedItem);
            }
            //재적상태를 설정한다. 선택한 재적상태이 없으면 진행하지 않는다.
            if (cmbRegStatus.SelectedIndex < 0) {
                MessageBox.Show("재적상태를 선택해 주세요.");
                cmbRegStatus.Focus();
                return;
            }
            else {
                student.RegStatus = ((string)cmbRegStatus.SelectedItem);
            }
            //주소를 설정한다.
            if (tbxAddress.Text == "") {
                MessageBox.Show("주소를 입력해 주세요.");
                tbxAddress.Focus();
                return;
            }
            else {
                student.Address = tbxAddress.Text;
            }
            //연락처를 설정한다.
            if (tbxContact.Text == "") {
                MessageBox.Show("연락처를 입력해 주세요.");
                tbxContact.Focus();
                return;
            }
            else {
                student.Contact = tbxContact.Text;
            }



            students[number] = student; // 딕셔너리에 데이터 추가 방법 1 (중복->덮어씌움)
            // number라는 string 형식의 키에 Student 자료형인 student 밸류를 저장한다.
            // 같은 number 키가 있어도 덮어쓰기.
            // students.Add(number, student); // 딕셔너리에 데이터 추가 방법 2 (비추)
            lbxDictionary.Items.Add(student);
            selectedStudent = student;
            btnRegister.Name = "수정";
            tbxNumber.ReadOnly = true;
        }

        private void UpdateStudent() { //define

            //(숙제)
            //수정은 학번을 고칠 수 없다.

            // tbxNumber.ReadOnly = true; 등록이 된 후 수정이 안되기에 Register 부분으로 올림.

            //학번을 제외한 모든 사항은 위의 RegisterStudent()와 동일하게 진행한다.
            //모든 사항의 확인 및 수정이 끝나면 수정완료 메세지를 띄운 후 화면을 초기화 상태로 만든다
            RegisterStudent();
            MessageBox.Show("수정완료.");
            ClearStudentInfo();

        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e) {
            var student = (lbxDictionary.SelectedItem as Student);

            btnNew_Click(sender, EventArgs.Empty);

            if (student != null) {
                DisplaySelectedStudent(student);
            }
        }

        private void DisplaySelectedStudent(Student student) {
            selectedStudent = student;
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            //(숙제) 생년월일 중 월을 가져와 설정한다.
            //(숙제) 생년월일 중 일을 가져와 설정한다.
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();

            // 학생정보에 맞는 소속학과 가져오기
            //for (int i = 0; i < cmbDepartment.Items.Count; i++)
            //{
            //    if ((cmbDepartment.Items[i] as Department).Code
            //    == student.DepartmentCode)
            //    {
            //        cmbDepartment.SelectedIndex = i;
            //        break;
            //    }
            //}

            // Department와 professor. 과목과 교수님 정보는 객체로 저장했기 때문에 저장된 곳으로 가서
            // 객체 자체를 가져와야 한다. 나머지는 단순한 string, int 형식이므로 붙여넣기.
            foreach (var department in departments) // foreach 버전으로 해보기
            {
                if (student.DepartmentCode == department.Code) {
                    cmbDepartment.SelectedItem = department;
                    break;
                }
            }
            //(숙제)
            //지도교수
            foreach (var professor in professors) {
                if (student.AdvisorNumber == professor.Number) {
                    cmbAdvisor.SelectedItem = professor;
                    break;
                }
            }
            // 학년,반,재적상태,주소,연락처의 정보를 가져와 설정한다.
            cmbYear.SelectedItem = student.Year;
            cmbClass.SelectedItem = student.Class;
            cmbRegStatus.SelectedItem = student.RegStatus;
            tbxAddress.Text = student.Address;
            tbxContact.Text = student.Contact;
            btnRegister.Name = "수정"; //btnRegister의 글씨를 "수정"으로 변경한다.




        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e) {

            //(숙제) ClearTestScoreInfo()를 호출해서 화면을 정리한다.
            //(숙제) 학번이 입력되었는지 여부를 확인하고, 그에 맞는 처리를 진행한다
            // 여기서 ClearTestScoreInfo()에 학번까지 초기화해서 넣으면 내가 입력한 학번까지 초기화가 되어
            // 밑에 if문 실행이 제대로 되지 않는다. 초기화를 탭이 넘어왔을때 해도 늦지 않는다 판단.
            // 어차피 더하는게 아니라 = 대입하기 때문에 결과에서 학번을 바꾸고 검색해도 더해지지 않고 출력됨.

            if (tbxTestNumber.Text != "") {
                selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
            }
            else {
                MessageBox.Show("정확한 학번을 입력해 주세요.");
                return;
            }
            //(숙제) 학번을 통해 검색한 학생 정보에서 이름을 가져와 lblTestName에 설정한다.
            lblTestName.Text = selectedStudent.Name;

            Grade grade = SearchGradeByNumber(selectedStudent.Number);

            //if (grade != null) {
            //    for (int i = 0; i < grade.Scores.Count && i < tbxTestScores.Length; i++) {
            //        tbxTestScores[i].Text = grade.Scores[i].ToString("0.0");
            //    }
            //}
            // 

            if (grade != null) {
                for (int i = 0; i < grade.Count() && i < tbxTestScores.Length; i++) {
                    tbxTestScores[i].Text = grade.Get(i).ToString("0.0");
                }
            }

        }

        private Grade SearchGradeByNumber(string number) {
            foreach (Grade grade in testGrades) {
                if (grade.StudentNumber == number) {
                    return grade;
                }
            }
            return null;
        }

        private Student SearchStudentByNumber(string number) {
            if (students.ContainsKey(number)) {
                return students[number]; // 밸류 반환.
            } else {
                return null;
            }
        }

        private void btnTestRegScore_Click(object sender, EventArgs e) {
            if (selectedStudent == null) {
                tbxTestNumber.Focus();
                return;
            }
            // 학생의 성적 입력한 항목 중 중간이 비어있으면 안됨. -> 숫자가 들어가있다거나. -> 비어있으면 잘못됐다 판단.

            for (int i = 1; i < tbxTestScores.Length; i++) {
                if (string.IsNullOrEmpty(tbxTestScores[i - 1].Text) && false == string.IsNullOrEmpty(tbxTestScores[i].Text)) {
                    tbxTestScores[i].Focus();
                    return;
                        }
            }
            var grade = SearchGradeByNumber(selectedStudent.Number);
            if (grade == null) {
                grade = new Grade() {
                    StudentNumber = selectedStudent.Number
                };
            }
#if false
            grade.Scores.Clear();
#else
            grade.Clear();
#endif

            double temp;
            for (int i = 0; i < tbxTestScores.Length; i++) {
                if (string.IsNullOrEmpty(tbxTestScores[i].Text)) {
                    break;
                }

                if (false == double.TryParse(tbxTestScores[i].Text, out temp)) {
                    tbxTestScores[i].Focus();
                    return;
                }

                // grade의 Scores를 배열로 만들었다면
                // grade의 Scores를 딕셔너리로 만들었다면
                grade.Add(temp);
            }

            testGrades.Add(grade);

#if false
            // 총 과목수 출력
            lblTestTotalCount.Text = grade.Scores.Count.ToString();
#else
            lblTestTotalCount.Text = grade.Count().ToString();

#endif
            // 평균 출력
            double average = grade.Average();
            lblTestAverage.Text = average.ToString("0.0");
            if(average < 0 ) {
                MessageBox.Show("계산할 수 없습니다.");
                return;
            }
        }
        
    }
}
    
