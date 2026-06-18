using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 프로그램 시작 시 기본 화면으로 생산관리 화면을 표시합니다.
            ShowControl(new ProductionControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowControl(new ProductionControl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControl(new QualityControl());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowControl(new InventoryControl());
        }

        /// <summary>
        /// groupBox1의 이전 화면을 제거하고 새로운 화면(UserControl)을 띄웁니다.
        /// </summary>
        private void ShowControl(UserControl control)
        {
            // 메모리 누수를 방지하기 위해 groupBox1 내부의 이전 컨트롤들을 모두 Dispose 처리합니다.
            while (groupBox1.Controls.Count > 0)
            {
                Control oldControl = groupBox1.Controls[0];
                groupBox1.Controls.RemoveAt(0);
                oldControl.Dispose();
            }

            // 새로운 컨트롤의 배치 속성을 지정하고 추가합니다.
            control.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(control);
        }
    }
}

