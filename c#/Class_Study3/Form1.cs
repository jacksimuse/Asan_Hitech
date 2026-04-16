using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Study3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            // 제어문, 하나의 변수에 대해서 조건을 달면서 제어하는 문장
            switch (cboSelect.Text)
            {
                case "강아지":
                    Dog dog = new Dog(tbName.Text, 4, "꼬리");
                    //dog.Name =   tbName.Text;
                    // MessageBox.Show(dog.Speak());
                    MessageBox.Show(dog.Bark());
                    break;
                case "고양이":
                    Cat cat = new Cat(tbName.Text, 4, "방울");
                    //cat.Name = tbName.Text;
                    // MessageBox.Show(dog.Speak());
                    MessageBox.Show(cat.Mew());
                    break;

                case "새":
                    Bird bird = new Bird(tbName.Text, 2);
                    //bird.Name = tbName.Text;
                    // MessageBox.Show(dog.Speak());
                    MessageBox.Show(bird.Tweet());
                    break;

                default:
                    Animal animal = new Animal(tbName.Text, 2);
                    MessageBox.Show(animal.Speak());
                    MessageBox.Show(animal.Property());
                    break;
            }
        }
    }
}
