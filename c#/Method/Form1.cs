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
        // 전역변수 / class에 직접 선언된 변수, 이 클래스 안이면 어디서든 접근 가능
        int click = 1;

        // 열거형
        enum Days // enum 이름(그룹 이름)
        { 
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Status
        { 
            Run,
            Idle,
            Error,
            Stop
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 메서드(함수) 
            // 객체는 사물과 동작으로 표현할 수 있음 / 변수 = 사물, 메서드 = 동작
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

        // 1. 메서드를 먼저 구현
        // 2. 호출

        // 1. 매개변수 x 반환 x
        // 2. 매개변수 o 반환 x
        // 3. 매개변수 x 반환 o
        // 4. 매개변수 o 반환 o

        // 반도체 장비를 가동한다는 가정
        // Run, Move, Grap, Make
        private void Run() 
        {
            MessageBox.Show("운전을 시작합니다");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void Move(int x) // x라는 숫자를 받을거야 호출할때 보내줘, 돌려주는 값은 없어
        {
            MessageBox.Show($"x축으로 {x}만큼 이동합니다");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Move(3);
        }


        private string Grap() // 호출할때 값은 필요없고, 웨이퍼라는 글자를 반환해줄게
        {
            return "웨이퍼";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string grap = $"장비에서 {Grap()}을 잡았습니다";
            MessageBox.Show(grap);
        }

        // 변수 or 메서드 이름 지어줄때
        // 1. 직관적, 2. 쉬울 것

        private string Make(string mat = "재료") // 호출할때 문자열을 넣어줘, 문자열로 돌려줄게
        {
            string semicon = $"{mat}를 결합하여 반도체로 만들었습니다";
            return semicon;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // 1. 가장 안쪽에 있는 메서드가 실행됩니다.
            // 2. Grap() = "웨이퍼"
            // 3. Grap이 Make의 매개변수가 됩니다.
            // 4. Make() = "반도체로 만들었습니다"
            // 5. product에 = "반도체로 만들었습니다"

            string product = Make(Grap()); // Make("웨이퍼") / "웨이퍼" = Grap()
            MessageBox.Show(product);

            MessageBox.Show(Make(Grap()));

            // 1. 변수 활용을 하면 누구나 이해하기 쉽게 코드를 작성할 수 있다.
            string a = Grap();
            string b = Make(a);
            MessageBox.Show(b); 

            // 2. 레거시 or 기존 프로젝트들 or AI가 짜준 코드에서 이해하기 어려운 부분들이 있을 수 있음
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Make());
            //MessageBox.Show(Make("웨이퍼"));

            Introduce();
            Introduce("강아지");
        }

        private void Sum(ref int a, ref int b)
        {
            // reference 참조 -> 원본 데이터를 그대로 사용하고 그대로 돌려줌
            a++;
            b++;
        }
        private void Sum2(int a,  int b)
        {
            // 값을 받아서 사용하고 이 함수에서 끝

            a++; // a = a +1
            b++; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //int a = 0;
            //int b = 3;

            //// 매개변수에 ref 없는 함수, 원데이터 복사본만 던져줌
            //Sum2(a, b);
            //MessageBox.Show(a.ToString()); // 0
            //MessageBox.Show(b.ToString()); // 3

            //// 매개변수에 ref 있는 함수, 원데이터 그대로 사용
            //Sum(ref a, ref b);
            //MessageBox.Show(a.ToString()); // 1
            //MessageBox.Show(b.ToString()); // 4

            int a = 3;
            int b = 6;
            Mul(ref a, ref b);
            MessageBox.Show($"a =  {a},  b = {b}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // out키워드
            // Method에서 반환값은 1개인데, 여러개 받고싶어요
            //bool a = int.TryParse("123", out int b);

            //MessageBox.Show(a.ToString());
            //MessageBox.Show(b.ToString());

            // 프로세스 구현을 하고나서 결과값에 따라 화면에 변화가 있음
            // 1.Run - Move - Grap - Make | 1회 사이클 완성 = Process true, 성공
            // 2.Run - Move / 해당 파트에서 오류가 발생하면서 실패 = Process false, 실패

            //string result = "";
            //bool final =  Process(out string result);

            //if (!final) 
            //{
            //    MessageBox.Show(result);
            //    return;
            //}

            Finger(out string first, out string second, out string third, out string fourth, out string fifth);
            MessageBox.Show(first+ " " + second + " " + third + " " + fourth + " " + fifth);
        }

        private bool Process(out string result)
        {
            // Run - Move - Grap 실행단계
            if (Grap() != "웨이퍼")
            {
                result = "실패";
                return false;
            }

            result = "성공";
            return true;
        }

        // Q1. 디폴트 있는 메서드 만들고 호출하기 / 디폴트 값 나오게, 파라미터 전달 값 나오게 2가지로 호출
        private void Introduce(string name = "최재훈")
        {
            MessageBox.Show($"{name}입니다");
        }
        // Q2. ref 사용해서 함수 내에서 곱해진 값을 원데이터로 확인하기
        private void Mul(ref int a, ref int b)
        {
            a *= 3;
            b *= 5;
        }

        // Q3. out 키워드를 이용해서 값을 최대 5개까지 받기
        private bool Finger(out string first, out string second, out string third, out string fourth, out string fifth)
        {
            first = "첫째";
            second = "둘째";
            third = "셋째";
            fourth = "넷째";
            fifth = "다섯째";
            return true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 지역변수, 이 메서드 안에서만 동작하는 변수
            // 메서드가 호출되면 새로 생성됨
            // int click = 1;
            //MessageBox.Show($"{click}번 클릭 했습니다");
            //click++;

           // MessageBox.Show($"오늘은 {Days.Tuesday}입니다");

            // 열거형 사용방법
            Status a = Status.Error;

            switch (a)
            {
                case Status.Run:
                    MessageBox.Show("정상 가동");
                    break;

                case Status.Idle:
                    MessageBox.Show("예열 완료");
                    break;

                case Status.Error:
                  //  MessageBox.Show("에러 고장");
                    break;

                case Status.Stop:
                    MessageBox.Show("멈춤 상태");
                    break;

                default:
                    MessageBox.Show("작업자가 판단해서 동작시킬것");
                    break;
            }

            Rainbow color = Rainbow.Red;

            switch (color)
            {
                case Rainbow.Red:
                    MessageBox.Show(Rainbow.Red.ToString());
                    break;
                case Rainbow.Orange:
                    MessageBox.Show(Rainbow.Orange.ToString());
                    break;
                case Rainbow.Yellow:
                    MessageBox.Show(Rainbow.Yellow.ToString());
                    break;
                case Rainbow.Green:
                    MessageBox.Show(Rainbow.Green.ToString());
                    break;
                case Rainbow.Blue:
                    break;
                case Rainbow.Navy:
                    break;
                case Rainbow.Purple:
                    break;
                default:
                    break;
            }
        }

        // Q. 열거형 무지개 만들고 조건부 출력하기
        enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Navy,
            Purple
        }

    }
}
