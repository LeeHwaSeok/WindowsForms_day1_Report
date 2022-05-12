using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_day1_Report
{
    public partial class Form1 : Form
    {
        //Tb.Text에 입력한 변수를 담을 그릇 선언
        private double saved=0;
        //산술식을 위한 변수
        private string op, abs;
        //계산 후 초기값 세팅을 위해
        int a=0;
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //b0~b9 -> 숫자 표현
        private void b0_Click(object sender, EventArgs e)
        {
            //예외처리
            //0은 1번이상 출력하지 않음  // TB ==0
            //결과가 나온 후 숫자 입력시 reset  //  a==1
            if (TB.Text == "0" || a == 1) { TB.Text = "0"; a = 0; }
            else { TB.Text = TB.Text + "0"; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "1"; a = 0; }
            else { TB.Text = TB.Text + "1"; }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "2"; a = 0; }
            else { TB.Text = TB.Text + "2"; }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "3"; a = 0; }
            else { TB.Text = TB.Text + "3"; }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1){ TB.Text = "4"; a = 0; }
            else { TB.Text = TB.Text + "4"; }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "5"; a = 0; }
            else { TB.Text = TB.Text + "5"; }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "6"; a = 0; }
            else { TB.Text = TB.Text + "6"; }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "7"; a = 0; }
            else { TB.Text = TB.Text + "7"; }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "8"; a = 0; }
            else { TB.Text = TB.Text + "8"; }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (TB.Text == "0" || a == 1) { TB.Text = "9"; a = 0; }
            else { TB.Text = TB.Text + "9"; }
        }

        //초기화
        private void b_clear_Click(object sender, EventArgs e)
        {
            TB.Clear();
            Accumulate_TB.Clear();
            //초기값 0으로 세팅
            TB.Text = "0"; 
        }

        //지우기
        private void b_backspace_Click(object sender, EventArgs e)
        {
            //뒤에서부터 자르기
            TB.Text = TB.Text.Remove(TB.Text.Length - 1);

            //초기값 0으로 세팅
            if (TB.Text.Length == 0) TB.Text = "0";

        }

        //소수점 표현
        private void b_dot_Click(object sender, EventArgs e)
        {
            //공백 상태에서 .을 클릭하면 0.으로 세팅
            if (TB.Text == "") { TB.Text = "0.";}
            //예외처리 dot은 1번만 사용가능
            else if (TB.Text.Contains(".")) { }         
            else { TB.Text = TB.Text + "."; }

            // a를 초기화 안해주니까 dot을 바로 사용하지 못해서 a를 0으로 초기화
            // a = 1 -> 연산 후 (리셋)
            // a = 0 -> 연산 중 (리셋 안함)
            a = 0;
        }

        //산술식 계산
        private void b_equal_Click(object sender, EventArgs e)
        {

            //예외처리 
            //  + 10 = ->  0 + 10 = 10
            if (TB.Text == "")
            {
                TB.Text = "0";
            }

            //누적값 표현 A + B =
            Accumulate_TB.Text = saved.ToString() + op + TB.Text + " =";

            // 연산을 위한 형변환
            Double value = Double.Parse(TB.Text);


            switch (op)  
            { 
                case " + ":
                    TB.Text = (saved + value).ToString(); 
                    break; 
                case " - ":
                    TB.Text = (saved - value).ToString(); 
                    break;
                case " * ":
                    TB.Text = (saved * value).ToString();
                    break; 
                case " / ":
                    TB.Text = (saved / value).ToString(); 
                    break;
                case " % ":
                    TB.Text = (saved % value).ToString();
                    break;
                case " ^ ":
                    TB.Text = (Math.Pow(saved, value)).ToString();
                    break;

            }

            //reset
            a = 1;

        }

        private void Accumulate_TB_TextChanged(object sender, EventArgs e)
        {

        }
        
        //이하 수식 표현

        //덧셈
        private void b_add_Click(object sender, EventArgs e)
        {
      
                //예외처리 : 텍스트가 비었을경우 
                //saved는 0이 초기값이다.
                if (TB.Text == "") { TB.Text = saved.ToString(); }

                //save는 텍스트 박스 값을 더블형으로 저장함
                saved = Double.Parse(TB.Text);

                //산술식 표현
                op = " + ";

                //누적창에 무엇을 더했는지 시각적으로 표현
                Accumulate_TB.Text = TB.Text + op;

                //clear
                TB.Clear();
            
        }

        //뺄셈
        private void b_sub_Click(object sender, EventArgs e)
        {
            // Parse는 문자열 to 실수 형태
            // ToStirng 실수 to 문자 형태
            if (TB.Text == "") { TB.Text = saved.ToString(); }
            saved = Double.Parse(TB.Text);

            op = " - ";
            Accumulate_TB.Text = TB.Text + op;
            TB.Clear();

        }

        //곱셈
        private void b_multiply_Click(object sender, EventArgs e)
        {
            if (TB.Text == "") { TB.Text = saved.ToString(); }
            saved = Double.Parse(TB.Text);
            op = " * ";
            Accumulate_TB.Text = TB.Text + op;
            TB.Clear();

        }
        
        //나눗셈
        private void b_div_Click(object sender, EventArgs e)
        {
            if (TB.Text == "") { TB.Text = saved.ToString(); }
            saved = Double.Parse(TB.Text);
            op = " / ";
            Accumulate_TB.Text = TB.Text + op;
            TB.Clear();
        }

        //몫
        private void b_share_Click(object sender, EventArgs e)
        {
            if (TB.Text == "") { TB.Text = saved.ToString(); }
            saved = Double.Parse(TB.Text);
            op = " % ";
            Accumulate_TB.Text = TB.Text + op;
            TB.Clear();
        }

        //거듭제곱
        private void b_pow_Click(object sender, EventArgs e)
        {
            if (TB.Text == "") { TB.Text = saved.ToString(); }
            saved = Double.Parse(TB.Text);
            op = " ^ ";
            Accumulate_TB.Text = TB.Text + op;
            TB.Clear();
        }

        //절댓값
        private void b_abs_Click(object sender, EventArgs e)
        {
            if (TB.Text == "") { TB.Text = saved.ToString(); }
            saved = Double.Parse(TB.Text);
            if (saved < 0) { saved = saved * (-1); }
            TB.Text = (saved).ToString();
            abs = " | ";
            Accumulate_TB.Text = abs + TB.Text + abs;
            TB.Clear();
        }
    }
}


