using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test4;

namespace test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnState_Click(object sender, EventArgs e)
        {
            switch (cboColor.Text)
            {
                case "빨강":
                    Red red = new Red(true, false);
                    MessageBox.Show($"{cboColor.Text}의  {red.TurnON_OFF()}" );



                    switch (rdbOn.Checked)
                    {
                        case true:
                            btnRed.BackColor = Color.Red;
                            break;
                        case false:
                            btnRed.BackColor = Color.White;
                            break;
                    }
                    break;
                case "주황":
                    Yellow yellow = new Yellow(rdbOn.Checked, rdbOn.Checked);
                    MessageBox.Show($"{cboColor.Text}의  {yellow.TurnON_OFF()}") ;
                    switch (rdbOn.Checked)
                    {
                        case true:
                            btnYellow.BackColor = Color.Yellow;
                            break;
                        case false:
                            btnYellow.BackColor = Color.White;
                            break;
                    }
                    break;
                case "초록":
                    Green green = new Green(rdbOn.Checked, rdbOn.Checked);
                    MessageBox.Show($"{cboColor.Text}의  {green.TurnON_OFF()}" );
                    switch (rdbOn.Checked)
                    {
                        case true:
                            btnGreen.BackColor = Color.Green;
                            break;
                        case false:
                            btnGreen.BackColor = Color.White;
                            break;
                    }
                    break;
                default:
                    if (lblPower.ForeColor == Color.Green)
                    {
                        MessageBox.Show($"전원이 켜졌습니다. ");
                        SignalTower signalTower = new SignalTower(true);

                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPower.Text = "연결됨";
            lblPower.ForeColor = Color.Green;
        }
    }
}
