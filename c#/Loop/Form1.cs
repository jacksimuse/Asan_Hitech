using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            // 반복문 for                          반복 횟수 = 조건문
            //for (int i = 0; i < 5; i++) // 초기값; 반복 횟수; 증감
            //{
            //    // 실행문
            //    MessageBox.Show(i.ToString()); // i를 증가시키면서 출력하는 실행문
            //}

            // 반복문 1부터 4까지 출력되도록 하세요
            //for (int i = 1; i <= 4; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            // Q 반복문을 5부터 1까지 출력되도록 하세요  / i--
            for (int i = 5; i >= 1; i--)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // while 문

            int i = 0;

            //while (i < 5) // (조건) 조건이 참이면 반복문 실행
            //{
            //    MessageBox.Show("고장");
            //    // 조건을 제어할 수 있는 장치를 추가함
            //    i++;
            //}

            do
            {
                MessageBox.Show("실행");
                i++;
            }
            while (i < 5);


        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            //string[] fruits = { "딸기", "사과", "포도" };

            //foreach (string fruit in fruits) // (자료형 변수 in 변수(배열 or 리스트))
            //{
            //    MessageBox.Show(fruit);
            //}

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 }; // 자료형[] 변수 = { 자료형용 값 };
            foreach (int i in numbers) 
            {
                MessageBox.Show(i.ToString());
            }

            // 실수형 배열을 만들고 각 요소들을 출력해보자
            // foreach, for
            for (int i = 0; i < numbers.Length; i++)
            {
                MessageBox.Show(numbers[i].ToString()); // index 순서, 순번

                // numbers[0] = 1;
                // numbers[1] = 2;
                // numbers[6] = 7;
            }
        }
    }
}
