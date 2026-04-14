using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        // 공간 1 (class 안)
        // 새롭게 만들어질 필드(전역변수) or 메서드 or 생성자
        int a = 0;

        void Color(string backcolor = "흰색")
        {
            MessageBox.Show($"{backcolor}으로 출력");
        }

        public Form1()
        {
            // 공간 2 (method, 생성자 안)

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 공간 2 (method, 생성자 안)
            // 만들어진 필드(전역변수) or 메서드를 사용하는 곳(호출)
            // 지역변수 / 해당 지역(method or 생성자)에서만 사용 가능

            int b = 0;

            //a = 1;

            Color();



            // 디폴트 값 넣는 함수 만들기
            // 디폴트 값으로는 "흰색"을 넣고 함수를 만들어서 빈값으로 호출, 값을 전달하여 호출
            // 함수에서 messagebox 띄우기


            Color("검정색");
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            // ref 값 넣어서 참조하기
            // 숫자 변수 만들고 100 초기화 한 다음,
            // ref 키워드가 들어간 함수를 만들고 원래 변수가 300이 되도록 만들기
            int number = 100;
            Reference(ref  number);
            MessageBox.Show(number.ToString());
        }

        void Reference(ref int num)
        {
            num *= 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // out으로 값 받기
            // return bool인 함수를 만들고 out으로 숫자 1개 문자열 1개를 받아오는 구조
            // 결과에 따라서 true 숫자 출력 / false 문자열 출력
            if (NumString(out int aa, out string bb))
            {
                MessageBox.Show(aa.ToString());
            }
            else
            {
                MessageBox.Show(bb);
            }

        }

        bool NumString(out int num, out string str)
        {
            num = 0;
            str = "문자열";
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 객체 생성까지
            
            Cookie cookie = new Cookie("과자1", 3.14, 1000); // 선언과 초기화



            MessageBox.Show($@"쿠키 이름 : {cookie.Name.ToString()}
쿠키 사이즈 : {cookie.Size.ToString()}
쿠키 가격 : {cookie.Price.ToString()}");
        }

        // 기본값 Default private
        void button5_Click(object sender, EventArgs e)
        {
            a++;
            MessageBox.Show($"{a}회 클릭했습니다");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int b = 1;
            MessageBox.Show($"{b}회 클릭했습니다");

        }
    }

    // 클래스 cookie  만들고 
    class Cookie
    {
        // 쿠키 이름, 사이즈, 가격
        // 전역변수(필드)

        // 한정자 public, private / 공공의, 사적인
        public string Name; // public을 사용하면 어디서든 사용 가능
        public double Size;  // private을 사용하면 자신이 속한 class에서만 사용 가능
        public int Price;

        // 생성자
        public Cookie(string name, double size, int price)
        {
            Name = name;
            Size = size;
            Price = price;
        }
    }
}
