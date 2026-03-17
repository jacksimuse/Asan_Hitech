using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 정수 ?
            // 자연수, 0, 음수
            int a = 1; //  정수형 자료형(int) 변수명 = 값;
            MessageBox.Show(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 실수형
            // 정수 + 소수점
            double b = 1.23; //  실수형 자료형(double) 변수명 = 값;
            MessageBox.Show(b.ToString()); // , . 키워드 사이는 .으로 이어짐

            // 3가지 실수형
            // double, float, decimal
            float f = 1.0f; // 접미사 f가 붙습니다
            decimal d = 3.14m; // 접미사 m이 붙습니다
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 문자형
            // 문자 1개를 담음
            char c = 'a'; //  문자형 자료형(char) 변수명 = 값;
            MessageBox.Show(c.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 문자열형
            // 문자 여러개를 담음
            string str = "문자열";
            MessageBox.Show(str.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // boolean형
            // 참과 거짓을 표현
            bool d = true; // true, false 2가지만 있음
            MessageBox.Show(d.ToString()); // 메세지박스를 화면에 띄워라(d를 문자열로 바꿔서)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // object는 모든 자료형을 받을 수 있다.
            object ob = true;
        }
    }
}
