using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 메서드(함수) ? 
            // 객체는 사물과 동작으로 표현할 수 있음
            // 메서드는 동작을 코드로 나타냄

            // 우리가 원하는 동작의 이름을 적어주고 alt+Enter


            // 전달해주는 요소, 인자 - (parameter), 반환형 - 메서드 이름 앞에 붙는 키워드(자료형)




            // 1. 매개변수(parameter) x 반환(return) x  
            Sum(); // 메서드 호출

            // 2. 매개변수(parameter) o 반환(return) x
            Sub(1, 2);

            // 3. 매개변수(parameter) x 반환(return) o
            int a = Mul(); // 반환형은 자료형 그 자체다
            //MessageBox.Show(a.ToString());

            // 4. 매개변수(parameter) o 반환(return) o
            int b = 3;
            double c = Div(a, b);
            MessageBox.Show(c.ToString());
        }

        private double Div(int a, int b)
        {
           return a / b;
        }

        private int Mul() // int, double로 반환하면 될 것 같습니다.
        {
            int a = 1;
            int b = 2;

            return a * b;
        }

        private void Sub(int v1, int v2) // (정수형 a, 정수형 b)인자를 받는다
        {
           // MessageBox.Show((v1 - v2).ToString());
        }

        private void Sum() // void - 반환할게 없다 / () 받을 인자도 없다, 파라미터 없다
        {
            // MessageBox.Show((1 + 2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Q 메서드 
            // 4가지
            // 1. 매개변수(parameter) x 반환(return) x   // 메서드에서 messagebox에 "클릭"
            Click();
            // 2. 매개변수(parameter) o 반환(return) x   // parameter에 "클릭" 이라는 글자를 전달해줍니다. / messagebox에 띄우기
            Click_p("클릭");
            // 3. 매개변수(parameter) x 반환(return) o   // 메서드에서 생성된 "클릭"이라는 글자를 받아와서 / messsagebox
            MessageBox.Show(Click_r());
            // 4. 매개변수(parameter) o 반환(return) o   // parameter에 "클"이라는 글자를 전달하고 메서드에서 "릭"이라는 글자를 합쳐서
            // 반환한뒤 messagebox에 띄우기
            MessageBox.Show(Click_pr("클"));
        }

        private string Click_pr(string v)
        {
            return v + "릭";
        }

        private string Click_r()
        {
            return "클릭";
        }

        private void Click_p(string v)
        {
            MessageBox.Show(v);
        }

        private void Click()
        {
            MessageBox.Show("클릭");
        }
    }
}
