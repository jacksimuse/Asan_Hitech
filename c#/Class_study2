using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Study2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 생성자가 없는 class 호출
            Employee employee = new Employee();
            employee.Salary = -1; // employee 이 객체가 가지고 있는 Salary에 속성 값을 부여, set

            MessageBox.Show(employee.Salary.ToString()); //  employee 이 객체가 가지고 있는 Salary의 속성 값을 가져옴, get
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }

    class Employee
    {
        // 월급 받는 가정
        private int salary;
        public int Salary 
        {
            get { return salary; }
            set 
            {
                // 월급을 받을건데 월급 마이너스 x
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }
    }
}
