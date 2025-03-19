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
    public partial class FormWeek3: Form
    {
        public FormWeek3()
        {
            InitializeComponent();
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            // 배열의 가장 큰 특징 : 고정길이
            // 배열 생성시 사용할 길이(Length)를 정해놓고 시작해야 함.

            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            
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

            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;


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
    
    }
}
