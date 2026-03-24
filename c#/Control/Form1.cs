using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnRed.Text == "빨간색") // 버튼의 글자가 빨간색이면
            {
                btnRed.BackColor = Color.Yellow; // 버튼의 색을 노란색으로
                btnRed.Text = "노란색"; // 버튼의 글자를 노란색으로 바꾼다.
            }
            else if (btnRed.Text == "노란색" ) // if 이외 조건 추가
            {
                btnRed.BackColor = Color.Green; // 버튼의 색을 노란색으로
                btnRed.Text = "초록색"; // 버튼의 글자를 노란색으로 바꾼다.
            }
            else if (btnRed.Text == "초록색") // if 이외 조건 추가
            {
                btnRed.BackColor = Color.Blue; // 버튼의 색을 노란색으로
                btnRed.Text = "파란색"; // 버튼의 글자를 노란색으로 바꾼다.
            }
            else if (btnRed.Text == "파란색") // if 이외 조건 추가
            {
                btnRed.BackColor = Color.Purple; // 버튼의 색을 노란색으로
                btnRed.Text = "보라색"; // 버튼의 글자를 노란색으로 바꾼다.
            }
            else // if의 조건 이외 모든 것
            {
                btnRed.BackColor = Color.White; // 버튼의 색을 노란색으로
                btnRed.Text = "흰색"; // 버튼의 글자를 노란색으로 바꾼다.
            }
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            // 변수 하나에 대하여 여러 조건을 만들 때 사용
            
            // break가 case와 한쌍
            // break를 빼고 case 사용하는 방법

            switch (btnYellow.Text)
            {
                case "빨간색":
                    btnYellow.BackColor = Color.Yellow;
                    btnYellow.Text = "노란색";
                    goto case "파란색";
                    break;

                case "노란색":
                case "초록색":
                    btnYellow.BackColor = Color.Blue;
                    btnYellow.Text = "파란색";
                    break;

                case "파란색":
                    btnYellow.BackColor = Color.Purple;
                    btnYellow.Text = "보라색";
                    break;

                default:
                    btnYellow.BackColor = Color.White;
                    btnYellow.Text = "흰색";
                    break;
            }
        }

        private void btnSignal_Click_1(object sender, EventArgs e)
        {
            // Q. if문을 사용해서 왼쪽 버튼에 색깔을 넣을겁니다.

            // btnRed.BackColor = Color.White -> Color.Red
            // btnYellow.BackColor = Color.White -> Color.Yellow
            // btnGreen.BackColor = Color.White -> Color.Green

            if (btnRed.BackColor == Color.White)
            {
                btnRed.BackColor = Color.Red;
            }
            else if (btnYellow.BackColor == Color.White)
            {
                btnYellow.BackColor = Color.Yellow;
            }
            else if (btnGreen.BackColor == Color.White)
            {
                btnGreen.BackColor = Color.Green;
            }

            if (btnRed.BackColor == Color.White)
            {
                btnRed.BackColor = Color.Red;
            }

            if (btnYellow.BackColor == Color.White)
            {
                btnYellow.BackColor = Color.Yellow;
            }

            if (btnGreen.BackColor == Color.White)
            {
                btnGreen.BackColor = Color.Green;
            }
        }
    }
}
