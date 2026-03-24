using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            // 산술연산자
            // +,-,*,/,%

            int a = 10;
            int b = 5;

            MessageBox.Show((a + b).ToString());
            MessageBox.Show((a - b).ToString());
            MessageBox.Show((a * b).ToString());
            MessageBox.Show((a / b).ToString()); // 몫
            MessageBox.Show((a % b).ToString()); // 나머지
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;

            a += 5; // a = a + 5;
            MessageBox.Show(a.ToString());
            a -= 5; // a = a - 5;
            MessageBox.Show(a.ToString());
            a *= 5; // a = a * 5;
            MessageBox.Show(a.ToString());
            a /= 5; // a = a / 5;
            MessageBox.Show(a.ToString());
            a %= 5; // a = a % 5;
            MessageBox.Show(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 기계 에러 발생

            // 기계의 신호를 계속 받으면서 비교하는 변수가 있음
            // 변수의 값이 "err" 이면 button2의 색깔을 빨간색으로 바꿈
            // "err"가 아니면 초록색으로 바꾸기

            // == 같다, != 같지않다

            string state = "normal"; // 정상 상태로 시작

            if (state == "err")
            {
                button2.BackColor = Color.Red;
            }
            else if (state != "err")
            {
                button2.BackColor = Color.Green;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 실린더 전진 후진

            // 양솔
            // 실린더 전진 하려면 / 전진 on 후진 off 
            // 실린더 후진 하려면 / 전진 off 후진 on

            bool front = false;
            bool back = true;

            // 양솔을 전진하려면 어떻게 해야될까요?
            if (front && !back)
            {
                MessageBox.Show("실린더 전진");
            }

            // 양솔을 후진하려면 어떻게 해야될까요?
            if (!front && back)
            {
                MessageBox.Show("실린더 후진");
            }

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // () ? 앞 : 뒤
            // "00" 정지, "10" 운전
            string machine = "00";

            string state = (machine == "10") ? "정지" : "운전";

            MessageBox.Show(state.ToString());
        }
    }
}
