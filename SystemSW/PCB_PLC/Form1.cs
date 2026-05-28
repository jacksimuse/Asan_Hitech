using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNMCMotionSDK;

namespace PCB_PLC
{
    public partial class Form1 : Form
    {
        // 외부 라이브러리 가져와서 사용하기
        NMCSDKLib.MC_STATUS ms;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //MessageBox.Show(ms.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            //MessageBox.Show(ms.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Double cylinder 코드가 2줄
            // Single cylinder 코드가 1줄
           


            // 공급 후진에 신호가 있으면
            bool a = false;
            // MasterID, EtherCatAddr, / Input 0, Output 1 / Offset, bitOffset / ref a
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 0, ref a);

            if (a)
            {
                // 공급 전진
                // MasterID, EtherCatAddr, Offset, bitOffset, true/false 
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 0, true);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 1, false);
                //MessageBox.Show(ms.ToString());
            }
        }

        // 예제
        // output 모든 신호 끄고 켜기 / 버튼 새로 만들어서 기능 넣기

        // Input = 센서 신호 받아옴
        // Output = 장비에 신호를 보냄

        private void button4_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0,0,0,4,0, ref a);
            //MessageBox.Show(ms.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ms = NMCSDKLib.MC_MasterInit(0);
            ms = NMCSDKLib.MC_MasterRUN(0);
        }

        // STOP 버튼
        private void button5_Click(object sender, EventArgs e)
        {
                // stop 버튼으로 모든 후진 버튼 메서드를 호출

                button7_Click(sender, e); // 공급 후진
                button9_Click(sender, e); // 창고 후진
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
