using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 암시적 형변환
            // 실수 > 정수
            int a = 1;
            double b;
            b = a;

            MessageBox.Show(b.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2. 명시적 형변환 / (자료형)변수
            // 실수 > 정수
            double a = 3.14;
            int b;
            b = (int)a;

            MessageBox.Show(b.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3. Convert
            string a = "123";
            int b = Convert.ToInt32(a); // 변환해라 (변수)를 To~
            // "123" -> 123

            int c = 123;
            string d = Convert.ToString(c);
            // 123 -> "123"

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
