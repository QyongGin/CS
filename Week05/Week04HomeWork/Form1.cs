using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04HomeWork
{
    public partial class FormManager: Form
    {
        // 인스턴스 필드(변수), 멤버변수
        Department[] departments; // 전역변수 class 안, method 밖
        List<Professor> professors;

        // 생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣어준다.
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100]; // rvalue 크기 반드시 지정
            professors = new List<Professor>();
        }

        
        private void btnRegisterDepartment_Click(object sender, EventArgs e) 
        {


            // 학과코드와 이름이 비면 안됨.

            //if문과 for문을 어떻게 관리하는지가 관건.
            int index = -1;
            for (int i=0; i < departments.Length; i++) {
                if (departments[i] == null) {
                    if (index < 0) {
                        index = i;
                    }
                } else {
                    if (departments[i].Code == tbxDepartmentCode.Text) {
                        //메세지 띄우고 
                       
                        return;
                    }
                }
            }

            // 경험치가 없어서 생각을 못하는 것.
            if(index < 0) {
                //메시지 띄위기.
                return;
            }

            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);

            // 추후 아래 코드는 삭제.
            lbxDepartment.Items.Add(dept.Code);
            lbxDepartment.Items.Add(dept.Name);
            lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");



        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e) 
        {
            if (lbxDepartment.SelectedIndex < 0) {
                // 메세지 띄우고
                return;
            }

            // is 연산자 , 타입 확인용으로 사용.
            if (lbxDepartment.SelectedItem is Department) { // Selected 니가 선택한게 Department 타입이 맞니?
                var target = (Department)lbxDepartment.SelectedItem; // class 타입은 케스팅 함부로 못한다. 확인 무조건.
                for (int i=0; i < departments.Length; i++) {
                    if (departments[i] != null && departments[i] == target) {
                        departments[i] = null; // 삭제
                        break;
                    } 
                }

                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
                lbxDepartment.SelectedIndex = -1;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e) {
            switch(tabMain.SelectedIndex) {
                case 0:
                    break;
                case 1:
                    foreach (var department in departments) { // var=Department departments 요소를 가져와서 비교.
                        cmbProfessorDepartment.Items.Clear();
                        if (department != null) {
                            cmbProfessorDepartment.Items.Add(department); //콤보박스,리스트 유사.
                        }

                        cmbProfessorDepartment.SelectedIndex = -1;
                        lbxProfessor.Items.Clear();
                    }
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            // index값 검사해서 진행여부 결정
            lbxProfessor.Items.Clear();

            // as 형변환 연산자.
            // 형변환이 정상적이지 않으면 null 반환.

            var department = cmbProfessorDepartment.SelectedItem as Department;

            if(department != null) { // C# null은 무조건 검사해야한다.
                foreach ( var professor in professors ) {
                    if (professor != null && professor.DepartmentCode == department.Code) {
                        // && 연산자는 첫 조건부터 검사하므로 null 체크는 먼저.
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }
    }
}
