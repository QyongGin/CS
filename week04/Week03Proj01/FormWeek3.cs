using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01
{
    // class 구성요소 : 값(변수) + 기능(메소드)
    // crtl + a, ctrl + m,m == 줄여보기 ctrl + m 다시 보기
    // 메소드 안 변수 지역변수 -> 메소드 끝나면 사라진다. 전역변수는? class에.
    public partial class FormWeek3: Form 
    {
        // 인스턴스 변수
        // 멤버 변수
        // C#에서는 Field(필드)라고 부름
        TextBox[] arrTbxData = new TextBox[5]; // 변수 선언, 초기화까지는 class에서 가능하다. 동작은 method에서

        RadioButton[] radioButtons = null;

        List<CheckBox> checkBoxes = null;

        // 생성자
        // 1. class와 이름이 동일해야함.
        // 2. 반환타입 표시하면 안됨.
        // 3. 생성시 무조건 1번만 호출됨. 
        public FormWeek3()
        {
            InitializeComponent(); // tbx 배치한 내용.
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            radioButtons = new RadioButton[] {
                rbtAdd,
                rbtSub,
                rbtMul,
                rbtDiv,
            };

            checkBoxes = new List<CheckBox> {
                chkAdd,
                chkSub,
                chkMul,
                chkDiv,
            };
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            // 배열의 가장 큰 특징 : 고정길이
            // 배열 생성시 사용할 길이(Length)를 정해놓고 시작해야 함.

            // TextBox[] arrTbxData = new TextBox[5]; 밖에 있으니 사용
            // arrTbxData[0] = tbxData1;
            // arrTbxData[1] = tbxData2;
            // arrTbxData[2] = tbxData3;
            // arrTbxData[3] = tbxData4;
            // arrTbxData[4] = tbxData5;

            
            // int[] arrIntData = new int[5];
            // 배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 한다.
            // 다른 배열의 길이로 사용해도 괜찮다.
            // 배열 요소의 값은 
            // struct는 struct의 기본값 (int는0) 실수 0.0 불 false 초기화 
            // class는 null이 기본값 string 값 저장이 아니라 주소 저장이기 때문에 null 

            int[] arrIntData = new int[arrTbxData.Length];

            for (int i=0; i < arrTbxData.Length; i++)
            {
                if (arrTbxData[i].Text != null && arrTbxData[i].Text != "")
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else
                {
                    // arrIntData[i] = 0; -> 과 동일함... 왜?
                }
            }

            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
                {
                result = arrIntData[0];
                    for (int i = 1; i < arrIntData.Length; i++)
                    {
                        result -= arrIntData[i];
                    }
                }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }

            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus(); // 포커스가 숫자 입력한 장소로 이동. 어디가 잘못됐는지 표시.
                        MessageBox.Show("0은 안된다공!!");
                        return;
                    }
                    result /= arrIntData[i]; // 하나라도 0이 들었다면 종료. 
                }
            }

            else
            {
                MessageBox.Show("연산을 선택하세요.");
                return; // 메소드를 즉시 종료하고 호출한 곳으로 돌아간다. return 만나면 lbl까지 가지 않는다.
            }

                lblResult.Text = result.ToString();

        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
            // 배열의 가장 큰 특징 : 고정길이
            // 배열 생성시 사용할 길이(Length)를 정해놓고 시작해야 함.

            // TextBox[] arrTbxData = new TextBox[5];
            // arrTbxData[0] = tbxData1;
            // arrTbxData[1] = tbxData2;
            // arrTbxData[2] = tbxData3;
            // arrTbxData[3] = tbxData4;
            // arrTbxData[4] = tbxData5;


            // int[] arrIntData = new int[5];
            // 배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 한다.
            // 다른 배열의 길이로 사용해도 괜찮다.
            // 배열 요소의 값은 
            // struct는 struct의 기본값 (int는0) 실수 0.0 불 false 초기화 
            // class는 null이 기본값 string 값 저장이 아니라 주소 저장이기 때문에 null 

            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) 
                    // 문자열은 null인지 빈문자열인지 확인 string.IsNullOrEmpty(arrTbxData[i].Text) 자주 사용
                    // Null이나 Empty 라면 true 반환 그래서 false와 비교 
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else
                {
                    // arrIntData[i] = 0; -> 과 동일함... 왜?
                }
            }

            int result = 0;

            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }

            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus(); // 포커스가 숫자 입력한 장소로 이동. 어디가 잘못됐는지 표시.
                        MessageBox.Show("0은 안된다공!!");
                        return;
                    }
                    result /= arrIntData[i]; // 하나라도 0이 들었다면 종료. 
                }
            }

            else
            {
                MessageBox.Show("연산을 선택하세요.");
                return; // 메소드를 즉시 종료하고 호출한 곳으로 돌아간다. return 만나면 lbl까지 가지 않는다.
            }

            lblResult.Text = result.ToString();

        }

        private void btnProcess03_Click(object sender, EventArgs e) {
            //Array vs. List
            //고정길이 = 가변길이
            //Length = Count / 고정길이 Length 가변길이 Count 
            //공통점 : 요소 접근 방법 [index]
            // string a = "11";
            // int b = a.Length; 문자열 길이
            // b == 2
            // a += "b"; //"11b" // string은 변한게 아니라 새로 만듦.
            // b = a.Length; // 3 


            // TextBox[] arrTbxData = new TextBox[5];
            // arrTbxData[0] = tbxData1;
            // arrTbxData[1] = tbxData2;
            // arrTbxData[2] = tbxData3;
            // arrTbxData[3] = tbxData4;
            // arrTbxData[4] = tbxData5;

            // int[] arrIntData = new int[arrTbxData.Length];
            // Generic(일반화) 지원 자료형 // 일반화 -> '<>' 붙어야함.

            List<int> arrIntData = new List<int>();
            // List<int> arrIntData -> class형. list를 제어할 변수 // 

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
         
                {
                    //arrIntData[i] = int.Parse(arrTbxData[i].Text);
                    //Add() (추가)가 있다면 Insert()(삽입) Remove() 
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                }
                else {
    
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Count; i++) {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result *= arrIntData[i];
                }
            }

            else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus(); 
                        MessageBox.Show("0은 불가능!");
                        return;
                    }
                    result /= arrIntData[i];  
                }
            }

            else {
                MessageBox.Show("연산을 선택하세요.");
                return; 
            }

            lblResult.Text = result.ToString();

        }

        private void btnProcess04_Click(object sender, EventArgs e) {
            // TextBox[] arrTbxData = new TextBox[5] {
            //     tbxData1,
            //     tbxData2,
            //     tbxData3,
            //     tbxData4,
            //     tbxData5,
            // };

            // int[] arrIntData = new int[arrTbxData.Length];
            // Generic(일반화) 지원 자료형 // 일반화 -> '<>' 붙어야함.
            List<int> arrIntData = new List<int>();
            // List<int> arrIntData -> class형. list를 제어할 변수 // 

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    //arrIntData[i] = int.Parse(arrTbxData[i].Text);
                    //Add() (추가)가 있다면 Insert()(삽입) Remove() 
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                }
                else {

                }
            }

            int result = 0;
            string totalResult = "";

            if (!chkAdd.Checked && !chkDiv.Checked && !chkSub.Checked && !chkMul.Checked) { 
                MessageBox.Show("연산을 선택하세요.");
                return;
            }

            if (chkAdd.Checked) { // 체크박스 여러개 선택가능하니 수정
                for (int i = 0; i < arrIntData.Count; i++) {
                    result += arrIntData[i];
                }

                totalResult += $"더하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result -= arrIntData[i];
                }

                totalResult += $"빼기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result *= arrIntData[i];
                }

                totalResult += $"곱하기:{result}";
                totalResult += Environment.NewLine;
            }

            if (chkDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 불가능!");
                        return;
                    }
                    result /= arrIntData[i];
                }
                totalResult += $"나누기:{result}";
                totalResult += Environment.NewLine;
            }

            

            lblResult.Text = totalResult.ToString();

        }

        private void chkOption_CheckedChanged(object sender, EventArgs e) 
        {
            //객체지향 + GUI(event 지향)
           

            var isEng = chkOption.Checked;
            string word;
           
            for (int i = 0; i < radioButtons.Length; i++) {

                switch (i) {
                    case 0:
                        word = isEng ? "Add" : "더하기"; break;
                    case 1:
                        word = isEng ? "Sub" : "빼기"; break;
                    case 2:
                        word = isEng ? "Mul" : "곱하기"; break;
                    case 3:
                        word = isEng ? "Div" : "나누기"; break;
                    default: continue; // word 문 반드시 조건 충족 
                }

                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
        }

        private void btnProcess06_Click(object sender, EventArgs e)
        {
            // Combox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0 ) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }
            
            
            // cmbBeverage.Items.Count -> Count 입력이 되면 가변 // 콤보박스의 내용

            int price = 0;

            switch (cmbBeverage.SelectedItem.ToString()) {
                case "아메리카노": 
                    price = 2000; break;
                case "카페라떼":   
                    price = 5000; break;
                case "플랫화이트": 
                    price = 9000; break;
                default:
                    return;
            }

            //가변타입. 
            var iceoption = chkIce.Checked ? "아이스" : ""; //컴파일시 결과가 문자열 var == string이 된다.
            var iceprice = chkIce.Checked ? 500 : 0; // var -> 컴파일시 값을 보고 알아서 자료형을 정해줌. 편리!
            //iceprice = "100" 오류 현재 int형임

            lblResult.Text =
                $"{iceoption} {cmbBeverage.SelectedItem}: " + $"{price + iceprice}";
            // 화면에 펼쳐진 radio가 많다면 cbx
        }

        private void btnProcess07_Click(object sender, EventArgs e) 
        {
            // Combox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }


            // cmbBeverage.Items.Count -> Count 입력이 되면 가변 // 콤보박스의 내용

            int price = 0;

            switch (cmbBeverage.SelectedIndex) { // cmb 글자를 사용할지 index를 사용할지 취향 
                case 0:
                    price = 2000; break;
                case 1:
                    price = 5000; break;
                case 2:
                    price = 9000; break;
                default:
                    return;
            }

            //가변타입. 
            var iceoption = chkIce.Checked ? "아이스" : ""; //컴파일시 결과가 문자열 var == string이 된다.
            var iceprice = chkIce.Checked ? 500 : 0; // var -> 컴파일시 값을 보고 알아서 자료형을 정해줌. 편리!
            //iceprice = "100" 오류 현재 int형임

            lblResult.Text =
                $"{iceoption} {cmbBeverage.SelectedItem}: " + $"{price + iceprice}";
            // 화면에 펼쳐진 radio가 많다면 cbx
        }

        private void btnProcess08_Click(object sender, EventArgs e) 
        {
            // Combox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            // 배열의 길이는 값이 변경되지 않는 것을 보장해야 한다.
            // var prices = new int[(cmbBeverage.Items.Count] { // Count 가변형
            var prices = new int[] {
                2000,
                5000,
                9000,
            };

            // cmbBeverage.Items.Count -> Count 입력이 되면 가변 // 콤보박스의 내용
            int price;
            if (cmbBeverage.SelectedIndex < prices.Length) { //f9 입력 지점부터 정지
                price = prices[cmbBeverage.SelectedIndex];
            } else {
                return;
            }



            //가변타입. 
            var iceoption = chkIce.Checked ? "아이스" : ""; //컴파일시 결과가 문자열 var == string이 된다.
            var iceprice = chkIce.Checked ? 500 : 0; // var -> 컴파일시 값을 보고 알아서 자료형을 정해줌. 편리!
            //iceprice = "100" 오류 현재 int형임

            lblResult.Text =
                $"{iceoption} {cmbBeverage.SelectedItem}: " + $"{price + iceprice}";
            // 화면에 펼쳐진 radio가 많다면 cbx

        // sender 조상님
        // private void btnNum7_Click_1(object sender, EventArgs e) {
        //     Button button = (Button)sender;
        //     lblNumbers.Text = button.Text;
        // }
    }
    }

}
