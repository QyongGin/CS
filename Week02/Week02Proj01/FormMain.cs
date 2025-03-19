using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Proj01
{
    public partial class FormMain: Form // : Form 상속 
    {
        public FormMain() // 생성자가 class와 이름 동일
        {
            InitializeComponent(); // UI 디자인 코드가 듦
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOutput01_Click(object sender, EventArgs e) // 버튼 대표 이벤트 Click
        {
            bool isToggle = chkToggle.Checked; // bool = true or false 오직 Checked bool 타입
            if (isToggle) {
                string data1 = tbxinput1.Text; // 화면에 보이는 속성 Text string 타입 tbxinput1 타입은 텍스트 박스
                string data2 = tbxinput2.Text;
                string result = data1 + data2; // 문자열 연결 연산자
                lblResult.Text = result; // 레이블의 텍스트 속성에 result 문자열 출력
            }
            else
            {
                int data1 = int.Parse(tbxinput1.Text); 
                int data2 = int.Parse(tbxinput2.Text);
                int result = data1 + data2; // 산술연산자
                lblResult.Text = result.ToString(); 
            }
        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if(chkToggle.Checked == false)
            {
                int data1 = int.Parse(tbxinput1.Text);
                int data2 = int.Parse(tbxinput2.Text);
                int result = data1 + data2; // 산술연산자
                lblResult.Text = "더하기:" + result; // 문자열+숫자=>문자열 연결 연산자로 동작
            }
            else
            {
                int data1 = int.Parse(tbxinput1.Text);
                int data2 = int.Parse(tbxinput2.Text);
                int result = data1 - data2; // 산술연산자
                lblResult.Text = "빼기:" + result; // 문자열+숫자=>문자열 연결 연산자로 동작
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
            int data1 = int.Parse(tbxinput1.Text);
            int data2 = int.Parse(tbxinput2.Text);

            if (chkToggle.Checked == false)
            {
                int result = data1 + data2; // 산술연산자
                lblResult.Text = string.Format("더하기:{0}", result); // + 연산이 많을 땐 Format이 더 효율적
            }
            else
            {
                int result = data1 - data2; // 산술연산자
                lblResult.Text = $"빼기:{result}"; // 문자열보간법 
            }
        }

        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxinput1.Text);
            double data2 = double.Parse(tbxinput2.Text);

            if (chkToggle.Checked == false)
            {
                double result = data1 + data2; 
                lblResult.Text = string.Format("더하기:{0}", result); 
            }
            else
            {
                double result = data1 - data2; 
                lblResult.Text = $"빼기:{result}"; 
            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxinput1.Text;
            lblResult.Text += Environment.NewLine; // "\r\n" 과 "\n" 환경에 따라 줄바꿈이 다르므로 Environment.NewLine을 제공한다.
            // lblResult.Text = Environment.NewLine; //문자열임
            lblResult.Text += tbxinput1.Text.GetType(); // 문자열에 문자열이 아닌 애를 넣어도 더하기 때문에 오류없음
            // lblResult.Text = tbxinput1.Text.GetType();
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxinput1.Text[0];
            // lblResult.Text = tbxinput1.Text[0]; //char (문자)
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxinput1.Text[0].GetType();

            lblResult.Text += Environment.NewLine;
            char test1 = tbxinput1.Text[0]; 
            //c언어 : 1바이트 (ascii)
            //c# : 2바이트 (unicode) 90년대 이후 언어 char : 2바이트 (unicode)
            byte result1 = (byte)test1;   // 1바이트 부호 미지원 정수형
            sbyte result4 = (sbyte)test1; // 1바이트 부호 지원 정수형
            short result2 = (short)test1; // 2바이트 부호지원 정수형
            ushort result3 = test1;       // 2바이트 부호 미지원 정수형
            // int, uint, long, ulong ...

            lblResult.Text += $"{test1},{result1},{result2},{result3}";
        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            // 정수 -> 실수 : OK
            // 실수 -> 정수 : 처리 필요
            // 작은 숫자 -> 큰 숫자 : OK
            // 큰 숫자 -> 작은 숫자 : 처리 필요
            int data1 = int.Parse(tbxinput1.Text);
            float data2 = (float)double.Parse(tbxinput2.Text);
            long data3 = long.Parse(tbxinput3.Text);
            int data4 = (int)data3;

            double result1 = data1 + data2 + data3 + data4; // 
            lblResult.Text = result1.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)1.9 + (int)1.6 => 2
            long result2 = data1 + (long)data2 + data3 + data4; // 
            lblResult.Text = result2.ToString();

            lblResult.Text += "\r\n";
            lblResult.Text += "\n";

            // (int)(1.9 + 1.6) => 3  
            long result3 = (long)(data1 + data2 + data3 + data4); // 
            lblResult.Text = result3.ToString();
        }

        private void btnOutput07_Click(object sender, EventArgs e)
        {
            // 관계연산자 이용 
            bool result1 = (tbxinput1.Text == tbxinput2.Text);
            bool result2 = (tbxinput2.Text == tbxinput3.Text);
            bool result3 = (tbxinput1.Text == tbxinput3.Text);

            // 논리연산자
            if (result1 && result2 && result3) {
                lblResult.Text = "모두 일치";
            }
            else if (result1 || result2 || result3) {
                lblResult.Text = "적어도 일치하는 데이터가 있음";
            }
            else {
                lblResult.Text = "모두 불일치";
            }
        }

        private void btnOutput08_Click(object sender, EventArgs e)
        {
            var data1 = int.Parse(tbxinput1.Text);
            var data2 = int.Parse(tbxinput1.Text);

            string result; // 지역변수-초기화 자동으로 안됨
            if (data1 == data2)
            {
                result = "같아요";
            }
            else if (data1 < data2) 
            {
                result = "뒤가 커요";
            }
            else 
            {
                result = "앞이 커요";
            }

            lblResult.Text = result;
        }

        private void btnOutput09_Click(object sender, EventArgs e)
        {
            lblResult.Text = int.MinValue.ToString() + "\r\n";
            lblResult.Text += int.MaxValue.ToString() + "\r\n";
            lblResult.Text += Environment.NewLine;
            lblResult.Text += uint.MinValue.ToString() + "\r\n";
            lblResult.Text += uint.MaxValue.ToString() + "\r\n";
            lblResult.Text += Environment.NewLine;
            // 고정소수점형 decimal 
            lblResult.Text += decimal.MinValue.ToString() + "\n";
            lblResult.Text += decimal.MaxValue.ToString() + "\n";
        }

        private void btnOutput10_Click(object sender, EventArgs e)
        {
            // 배열 array / textBoxes 배열의 주소를 아는 변수(래퍼런스 타입)
            TextBox[] textBoxes; // 배열변수 선언
            textBoxes = new TextBox[5]; // new TextBox[5] 배열생성해서 변수에 위치 할당

            textBoxes[0] = tbxinput1;
            textBoxes[1] = tbxinput2;
            textBoxes[2] = tbxinput3;
            textBoxes[3] = tbxinput4;
            textBoxes[4] = tbxinput5;

            // 객체지향 언어의 특징
            // 자료형은 class(or struct)로 만든다.
            // class : (값 + 추가 meta data) + 기능... 값은 변수로 기능은 메소드로 표현
            int sum = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null // 주소가 없으면 null 할당이 있는지 없는지
                    && textBoxes[i].Text.Trim() != "") // Trim() 공백제거
                {
                    sum += int.Parse(textBoxes[i].Text);
                }
            }
            lblResult.Text = "총 합 : " + sum;
        }

        private void btnOutput11_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes; // 배열변수 선언
            textBoxes = new TextBox[5]; // new TextBox[5] 배열생성해서 변수에 위치 할당

            textBoxes[0] = tbxinput1;
            textBoxes[1] = tbxinput2;
            textBoxes[2] = tbxinput3;
            textBoxes[3] = tbxinput4;
            textBoxes[4] = tbxinput5;

            // 객체지향 언어의 특징
            // 자료형은 class(or struct)로 만든다.
            // class : (값 + 추가 meta data) + 기능... 값은 변수로 기능은 메소드로 표현
            int sum = 0;
            int count = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null // 주소가 없으면 null 할당이 있는지 없는지
                    && textBoxes[i].Text.Trim() != "") // Trim() 공백제거
                {
                    sum += int.Parse(textBoxes[i].Text);
                    ++count;
                }
            }
            lblResult.Text = "평균 : " + (sum / count);
        }
    
    }
}
