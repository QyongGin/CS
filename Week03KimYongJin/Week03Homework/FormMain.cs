using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Homework
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // 배열 대신 num1, num2에 저장. 
        // 숫자를 누르면 누른 대상이 출력, 저장. 
        // 연산식을 누르면 누른 대상이 출력, 저장.
        // btnCal을 누르지 않고 다른 연산식을 또 누르면 먼저 눌렀던 연산식을 시행 후 다시 저장.
        // sender는 이벤트를 일으킨 대상. sender를 조건식에 사용하고 싶음.
        // sender를 as연산자를 통하여 Button으로 변환시킨다. 만든 Button의 텍스트가 곧 역할이니까 string으로 Button의 텍스트 저장.
        // 저장된 값에 따라 역할 수행.


        string cost;
        string num1;
        string num2;
        int operand1;
        int operand2;
        string buttonText;
        Button clickedButton;

        private void btnNum0_Click_1(object sender, EventArgs e)
        {
            clickedButton = sender as Button; // sender = 대상이된 객체. 객체를 버튼 형식으로 전환해서 버튼 변수에 저장.
            buttonText = clickedButton.Text; // 버튼의 텍스트 값을 string 변수에 저장.

            if (cost == null)
            {
                if (lblNumbers.Text == "0")
                {
                    lblNumbers.Text = "";
                    num1 += buttonText;
                    lblNumbers.Text += buttonText;

                }
                else
                {
                    num1 += buttonText;
                    lblNumbers.Text += buttonText;
                }
            }
            else
            {
                lblNumbers.Text = "";
                num2 += buttonText;
                lblNumbers.Text += buttonText;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button; 
            buttonText = clickedButton.Text; 

            switch (cost) // sender(대상) 텍스트 값을 사용.
            {
                case "+":
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 + operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblExpression.Text = num1 + buttonText;
                    lblNumbers.Text = num1;
                    cost = buttonText;
                    break;
                case "-":
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 - operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblExpression.Text = num1 + buttonText;
                    lblNumbers.Text = num1;
                    cost = buttonText;
                    break;
                case "*":
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 * operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblExpression.Text = num1 + buttonText;
                    lblNumbers.Text = num1;
                    cost = buttonText;
                    break;
                case "/":
                    if(num1 == "0" && num2 == "0")
                    {
                        lblNumbers.Text = "숫자를 다시 입력해주세요.";
                        MessageBox.Show("잘못된 입력입니다.");
                    }
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 / operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblExpression.Text = num1 + buttonText;
                    lblNumbers.Text = num1;
                    cost = buttonText;
                    break;
                case "=":
                    cost = buttonText;
                    lblExpression.Text = num1 + buttonText; 
                    break;
                case null:
                    cost = buttonText;
                    lblExpression.Text += num1 + cost;
                    lblNumbers.Text = null;
                    break;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button; 
            buttonText = clickedButton.Text; 

            switch (cost) 
            {
                case "+":
                    lblExpression.Text = num1 + cost + num2 + buttonText;
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 + operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblNumbers.Text = num1;
                    break;
                case "-":
                    lblExpression.Text = num1 + cost + num2 + buttonText;
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 - operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblNumbers.Text = num1;
                    break;
                case "*":
                    lblExpression.Text = num1 + cost + num2 + buttonText;
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 * operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblNumbers.Text = num1;
                    break;
                case "/":
                    lblExpression.Text = num1 + cost + num2 + buttonText;
                    operand1 = int.Parse(num1);
                    operand2 = int.Parse(num2);
                    operand1 = operand1 / operand2;
                    num1 = operand1.ToString();
                    num2 = null;
                    lblNumbers.Text = num1;
                    break;
                case null:
                    lblExpression.Text += buttonText;
                    break;
            }
            cost = buttonText;
        }
    }
    
}
