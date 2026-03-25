using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            // Q. top, middle, bot
            // top.text >, < middle.text 크면 빨간색 작으면 노란색
            // middle bot 비교하고 같으면 둘다 초록색 다르면 bot에만 파란색
            btnTop.BackColor =
                (Convert.ToInt32(btnTop.Text) > Convert.ToInt32(btnMiddle.Text)) ? Color.Red : Color.Yellow;
            btnMiddle.BackColor =
                (Convert.ToInt32(btnTop.Text) < Convert.ToInt32(btnMiddle.Text)) ? Color.Red : Color.Yellow;

            btnBot.BackColor =
                (Convert.ToInt32(btnMiddle.Text) != Convert.ToInt32(btnBot.Text)) ? Color.Blue : Color.Green;
            btnMiddle.BackColor =
                (Convert.ToInt32(btnMiddle.Text) == Convert.ToInt32(btnBot.Text)) ? Color.Green : btnMiddle.BackColor;

            // 생각 시나리오
            // 1. text와 text를 비교
            // 숫자로 형 변환을 해야겠다.
            int a = Convert.ToInt32(btnTop.Text);
            int b = Convert.ToInt32(btnMiddle.Text);
            int c = Convert.ToInt32(btnBot.Text);

            // 2. 숫자를 비교해서 색깔 넣기
            if (a > b)
            {
                btnTop.BackColor = Color.Red;
                btnMiddle.BackColor = Color.Yellow;
            }
            else if (a < b)
            {
                btnTop.BackColor = Color.Yellow;
                btnMiddle.BackColor = Color.Red;
            }

            // 3. 다음 문제
            if (b == c)
            {
                btnMiddle.BackColor = Color.Green;
                btnBot.BackColor = Color.Green;
            }
            else if (b != c)
            {
                btnBot.BackColor = Color.Blue;
            }
        }

       
        private void btnSignal2_Click(object sender, EventArgs e)
        {
            // Q
            // 1.신호를 클릭해서 메세지박스 20번 띄우기
            // 2.btnMiddle.Text에 3.14 값을 곱하기 할당해서 표시하기
            for (int i = 0; i < 20; i++)
            {
                MessageBox.Show("클릭");
            }

            // double middle = Convert.ToDouble(btnMiddle.Text) * 3.14;
            double middle = Convert.ToDouble(btnMiddle.Text);
            middle *= 3.14; // middle = middle * 3.14;
            // btnMiddle.Text = middle.ToString();
            btnMiddle.Text = Convert.ToString(middle);


            // 생각 시나리오
            // 1. 메세지 박스 20번 띄우기 
            // 복사 붙여넣으면 힘들것같은데...

            // 2. text는 문자열이던데 숫자를 어떻게 곱하지? 
            // 형태를 바꿔야겠구나

        }
    }
}
