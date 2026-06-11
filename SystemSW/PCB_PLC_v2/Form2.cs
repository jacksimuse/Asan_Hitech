using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCB_PLC
{
    public partial class Form2 : Form
    {
        private CheckBox[] inputCheckBoxes;
        private CheckBox[] outputCheckBoxes;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 배열로 관리하기 위해 초기화
            inputCheckBoxes = new CheckBox[] 
            {
                chkInput00, chkInput01, chkInput02, chkInput03, chkInput04, chkInput05, chkInput06, chkInput07,
                chkInput08, chkInput09, chkInput10, chkInput11, chkInput12, chkInput13, chkInput14, chkInput15,
                chkInput16, chkInput17, chkInput18, chkInput19, chkInput20, chkInput21, chkInput22, chkInput23,
                chkInput24, chkInput25, chkInput26, chkInput27, chkInput28, chkInput29, chkInput30, chkInput31
            };

            outputCheckBoxes = new CheckBox[] 
            {
                chkOutput00, chkOutput01, chkOutput02, chkOutput03, chkOutput04, chkOutput05, chkOutput06, chkOutput07,
                chkOutput08, chkOutput09, chkOutput10, chkOutput11, chkOutput12, chkOutput13, chkOutput14, chkOutput15,
                chkOutput16, chkOutput17, chkOutput18, chkOutput19, chkOutput20, chkOutput21, chkOutput22, chkOutput23,
                chkOutput24, chkOutput25, chkOutput26, chkOutput27, chkOutput28, chkOutput29, chkOutput30, chkOutput31
            };

            // IOMap의 한글 태그 명칭을 체크박스 텍스트에 적용
            for (byte i = 0; i < 32; i++)
            {
                if (IOMap.Input.Names.TryGetValue(i, out string inName))
                {
                    inputCheckBoxes[i].Text = $"X{i:X2} - {inName}";
                }
                else
                {
                    inputCheckBoxes[i].Text = $"X{i:X2} - 미사용";
                }

                if (IOMap.Output.Names.TryGetValue(i, out string outName))
                {
                    outputCheckBoxes[i].Text = $"Y{i:X2} - {outName}";
                }
                else
                {
                    outputCheckBoxes[i].Text = $"Y{i:X2} - 미사용";
                }
            }

            ioTimer.Start();
        }

        private void IoTimer_Tick(object sender, EventArgs e)
        {
            // IO 클래스를 통해 DWORD 통째로 읽어오기
            uint inData = IO.ReadInputDWord();
            uint outData = IO.ReadOutputDWord();

            for (int i = 0; i < 32; i++)
            {
                // 비트 마스킹을 통한 신호 확인
                bool isInputSet = (inData & (1U << i)) != 0;
                bool isOutputSet = (outData & (1U << i)) != 0;

                inputCheckBoxes[i].Checked = isInputSet;
                outputCheckBoxes[i].Checked = isOutputSet;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ioTimer != null)
            {
                ioTimer.Stop();
                ioTimer.Dispose();
            }
            base.OnFormClosing(e);
        }
    }
}