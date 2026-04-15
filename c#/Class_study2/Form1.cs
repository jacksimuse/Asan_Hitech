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

        public void button2_Click(object sender, EventArgs e)
        {
            // 생성자가 없는 class 호출
            Employee employee = new Employee();
            employee.Salary = -1; // employee 이 객체가 가지고 있는 Salary에 속성 값을 부여, set

            MessageBox.Show(employee.Salary.ToString()); //  employee 이 객체가 가지고 있는 Salary의 속성 값을 가져옴, get
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Property1 property1 = new Property1(); // 속성 개체 1개 만들기
            MessageBox.Show(property1.Color);
            // property1.Color = "검정색"; // set 키워드가 없어서 값을 넣을 수가 없어
            button1.BackColor = Color.Green;
        }



        BankAccount person1; // 클래스 객체 선언
        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (person1 == null) // 객체 초기화가 되어 있지 않다면
            {
                // Q. text박스에 값이 없을 때 어떻게 해야될까요?

                // 생각 시나리오

                // textbox에 값이 없다
                // 값이 필요하다. 사용자에게 넣어달라고 말을 해야지


                if (tbName.Text == string.Empty || tbAccount.Text.Length == 0)
                // 텍스트 박스의 길이가 0 이면 글자가 없음
                // 텍스트 박스에 글자가 없으면 글자가 없음  / string.Empty, ""
                {
                    MessageBox.Show($"이름과 계좌번호를 입력해주세요");

                    return; // 실행문이 끝나면 돌려보냄
                }

                //else   // 코드 실행이 안되게 막아야겠다
                //{
                //    person1 = new BankAccount(tbName.Text, int.Parse(tbAccount.Text)); // 객체 초기화
                //    // 객체의 필드가 public으로 되어 있어서 값을 가져올 수 있음
                //    MessageBox.Show($"{person1.Name}의 계좌가 생성 되었습니다. 계좌번호는  {person1.Account}입니다");
                //}

                person1 = new BankAccount(tbName.Text, int.Parse(tbAccount.Text)); // 객체 초기화
                // 객체의 필드가 public으로 되어 있어서 값을 가져올 수 있음
                MessageBox.Show($"{person1.Name}의 계좌가 생성 되었습니다. 계좌번호는  {person1.Account}입니다");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int money = 10000;
            if (person1 == null)
            {
                MessageBox.Show("계좌가 생성되지 않았습니다");
                return;
            }

            MessageBox.Show(person1.Deposit(money)); // 객체.메서드() 호출
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            
            if (person1 == null) return;

            int money = 10000;
            MessageBox.Show(person1.Withdraw(money));


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (person1 == null)
            {
                return;
            }

            if (person1.Name == tbName.Text)
            {
                MessageBox.Show($"{person1.Name}님의 잔액이 {person1.Money} 남아있습니다");
            }
            else
            {
                MessageBox.Show($"{tbName.Text}님의 계좌를 확인할 수 없습니다");
            }
        }
    }

    // 속성에 대해서 정리하는 class를 만들어봅시다.
    class Property1
    {
        // 필드 2개
        private string color = "흰색";
        public string Color
        {
            get { return color; }
        }
    }

    // class, 필드, 속성 복습
    // 쓰기 전용 하나 만들어 봅시다
    // Property2라는 클래스 만들고 필드 둘 memo 만들고, 속성 부여
    class Property2
    {
        // 필드 2개
        private string memo;
        public string Memo
        {
            set { memo = value; }
        }

        void MemoWrite()
        {
            // 로그 기록
            memo += "위 문장을 추가합니다 ";
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
                    salary = value;
                }
                else
                {
                    salary = value;
                }
            }
        }
    }
}
