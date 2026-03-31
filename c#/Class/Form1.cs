using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // 클래스 인스턴스 생성
            // 클래스로 생성된 객체 or 인스턴스는 서로 다른 존재이다.
            Person a = new Person(tbName.Text, tbPhone.Text, int.Parse(tbAge.Text));
            a.Introduce();

            Person b = new Person("사람", "010-7564-9789", 123);
            b.Introduce();
        }
    }

    // 쿠키틀, 템플릿
    class Person
    {
        public string Name;
        public string Phone;
        public int Age;

        // 생성자
        // 클래스가 처음 객체를 생성할 때 값을 세팅하는 곳
        public Person(string name, string phone, int age)
        {
            Name = name; // 클래스의 전역변수(필드)와 파라미터 값을 연결
            Phone = phone;
            Age = age;
        }

        public void Introduce()
        {
            MessageBox.Show($"안녕하세요. 저는 {Name}이고 연락처는 {Phone}이고, 나이는 {Age} 입니다");
        }
    }
}
