using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            ms = NMCSDKLib.MC_MasterInit(0);
            ms = NMCSDKLib.MC_MasterRUN(0);
        }

        private void loadCylFWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 0, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 0, true);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 1, false);
            }
        }

        private void loadCylBWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 1, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 0, false);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 1, true);
            }
        }

        private void WorkCylFWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 2, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 2, true);
            }
        }

        private void WorkCylBWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 3, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 2, false);
            }
        }

        private void MoveCylFWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 4, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 3, true);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 4, false);
            }
        }

        private void MoveCylBWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 5, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 3, false);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 4, true);
            }
        }

        private void UnldCylFWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 6, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 5, true);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 6, false);
            }
        }

        private void UnldCylBWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 7, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 5, false);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 6, true);
            }
        }

        private void ContCylFWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 4, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 2, true);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 3, false);
            }
        }

        private void ContCylBWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 5, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 2, false);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 3, true);
            }
        }

        private void EqpInit_Click(object sender, EventArgs e)
        {
            // 실린더
            loadCylBWD_Click(sender, e);
            WorkCylBWD_Click(sender, e);
            MoveCylBWD_Click(sender, e);
            UnldCylBWD_Click(sender, e);
            ContCylBWD_Click(sender, e);
            // 스토퍼
            stopperBWD_Click(sender, e);

            // 모든 장비
            // 드릴, 컨테이너, 흡착 stop
            DrillOff_Click(sender, e);
            ConvOff_Click(sender, e);
            SuctionOff_Click(sender, e);

            // 시그널 타워
            // 레드, 엘로우, 그린 불 켜기
            Red_Click(sender, e);
            Yellow_Click(sender, e);
            Green_Click(sender, e);
        }

        private void StackFWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 2, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 7, true);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 0, false);
            }
        }

        private void StackBWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 3, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 7, false);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 0, true);
            }
        }

        private void DrillOn_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 1, 5, ref a);

            if (!a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 5, true);
            }
        }

        private void DrillOff_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 1, 5, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 5, false);
            }
        }

        private void ConvOn_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 1, 6, ref a);

            if (!a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 6, true);
            }
        }

        private void ConvOff_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 1, 6, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 6, false);
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 1, 7, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 7, false);
            }
            else
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 7, true);
            }
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 2, 0, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 0, false);
            }
            else
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 0, true);
            }
        }

        private void Green_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 2, 1, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 1, false);
            }
            else
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 1, true);
            }
        }

        private void stopperFWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 0, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 4, true);
            }
        }

        private void stopperBWD_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 1, ref a);

            if (a)
            {
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 4, false);
            }
        }

        private void SuctionON_Click(object sender, EventArgs e)
        {
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 1, true);
        }

        private void SuctionOff_Click(object sender, EventArgs e)
        {
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 1, 1, false);
        }

        private void OneCycle_Click(object sender, EventArgs e)
        {
            // 스틸워크 기준으로 시퀀스 작성
            // 워크 공급부터 취출 되기까지 작성하기

            // 워크 검출 확인 (Input Bit 0E -> Address 5, Bit 6)
            bool workDetected = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 6, ref workDetected);

            // 워크 있으면
            if (workDetected)
            {
                // 공급 후진 확인
                // 공급 후진이면 공급 전진
                loadCylFWD_Click(sender, e);
                Thread.Sleep(1500); // 기계 동작 시간 대기

                // 공급 전진 확인
                // 공급 전진이면 공급 후진
                loadCylBWD_Click(sender, e);
                Thread.Sleep(1500);

                // 드릴 상승이면 드릴 하강
                WorkCylFWD_Click(sender, e);
                Thread.Sleep(1500);

                // 드릴 off면 on
                DrillOn_Click(sender, e);
                Thread.Sleep(2000); // 가공 시간 대기

                // 드릴 on이면 off
                DrillOff_Click(sender, e);
                Thread.Sleep(500);

                // 드릴 하강이면 상승
                WorkCylBWD_Click(sender, e);
                Thread.Sleep(1500);

                // 분배 후진에 신호가 있으면 분배 전진
                MoveCylFWD_Click(sender, e);
                Thread.Sleep(1500); // 전진 동작 시간 대기

                // 분배 전진에 신호가 있으면 분배 후진
                MoveCylBWD_Click(sender, e);
                Thread.Sleep(1500); // 후진 동작 시간 대기
            }

            // level 2 / 컨베이어부터 시작
            // 1. 컨베이어 on
            ConvOn_Click(sender, e);

            // 워크가 센서 구역을 지나가는 동안 감지된 신호를 누적(저장)할 래치 변수
            bool detectedInductive = false;  // 유도형 센서 (금속 감지 이력)
            bool detectedCapacitive = false; // 용량형 센서 (비금속/금속 감지 이력)

            // 1. 센서 중 하나라도 처음 감지될 때까지 대기
            bool currentInd = false, currentCap = false;
            while (!currentInd && !currentCap)
            {
                NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 6, 0, ref currentInd);  // Input 10 (Address 6, Bit 0)
                NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 6, 1, ref currentCap);  // Input 11 (Address 6, Bit 1)
                Thread.Sleep(30);
            }

            // 2. 처음 감지된 순간부터 워크가 센서 구역을 완전히 지나갈 때까지(약 1.5초) 신호 누적
            // 센서들이 순차적으로 켜지므로, 한 번이라도 감지되면 래치 변수에 저장합니다.
            for (int i = 0; i < 50; i++) // 30ms * 50번 = 1.5초 동안 감시
            {
                NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 6, 0, ref currentInd);
                NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 6, 1, ref currentCap);

                if (currentInd) detectedInductive = true;
                if (currentCap) detectedCapacitive = true;

                Thread.Sleep(30);
            }

            // 3. 수집된 신호 판별: 둘 다 불이 들어온 이력이 있으면 = steal (금속)
            if (detectedInductive && detectedCapacitive)
            {
                // 취출 실린더 앞까지 도달할 시간 대기
                Thread.Sleep(100); 

                // 4. steal이면 취출 전진한다
                UnldCylFWD_Click(sender, e);
                Thread.Sleep(1500);

                // 5. 취출 전진 신호가 있으면 취출 후진
                bool isUnldFwd = false;
                NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 7, ref isUnldFwd); // Input 07 (Address 4, Bit 7)
                if (isUnldFwd)
                {
                    UnldCylBWD_Click(sender, e);
                    Thread.Sleep(1500);
                }

                // 6. 컨베이어 off
                ConvOff_Click(sender, e);
            }
            // 3-1. 수집된 신호 판별: 유도형만 불 들어오면 = plastic (일반적으로 플라스틱은 용량형만 들어옵니다. 주석에 맞춰 논리 적용)
            else if (detectedCapacitive && !detectedInductive) 
            {
                // 스토퍼 앞까지 도달할 시간 대기
                Thread.Sleep(700);

                // 4-1. plastic이면 stopper 하강
                stopperFWD_Click(sender, e); // 스토퍼 하강
                Thread.Sleep(1500);

                // 5-1. stopper 검출 신호가 있으면 리프트 가장 아래까지 하강
                bool isStopperDetect = false;
                NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 6, 2, ref isStopperDetect); // 스토퍼 검출: Input 12 (Address 6, Bit 2)

                if (isStopperDetect)
                {
                    // 리프트 하강 시작 (모터 하강)
                    NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 2, false); // 상승 Off
                    NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 3, true);  // 하강 On

                    // 리프트가 가장 아래(LV_W)까지 갈 때까지 대기
                    bool isLvW = false;
                    while (!isLvW)
                    {
                        NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 6, 4, ref isLvW); // LV_W: Input 14 (Address 6, Bit 4)
                        Thread.Sleep(50);
                    }
                    // 리프트 하강 정지
                    NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 3, false);
                    Thread.Sleep(300);

                    // 6-1. 흡착 on
                    SuctionON_Click(sender, e);
                    Thread.Sleep(1000);

                    // 7-1. 리프트 lv_1까지 상승 
                    NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 3, false); // 하강 Off
                    NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 2, true);  // 상승 On

                    bool isLv1 = false;
                    while (!isLv1)
                    {
                        NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 6, 5, ref isLv1); // LV_1: Input 15 (Address 6, Bit 5)
                        Thread.Sleep(50);
                    }
                    // 리프트 상승 정지
                    NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 2, false);
                    Thread.Sleep(500);

                    // 8-1. 적재 전진
                    StackFWD_Click(sender, e);
                    Thread.Sleep(1500);

                    // 9-1. 흡착 off
                    SuctionOff_Click(sender, e);
                    Thread.Sleep(1000);

                    // 10-1. 적재 전진에 신호 있으면 적재 후진
                    bool isStackFwd = false;
                    NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 5, 3, ref isStackFwd); // 적재 전진 신호: Input 0B (Address 5, Bit 3)
                    
                    if (isStackFwd)
                    {
                        StackBWD_Click(sender, e);
                        Thread.Sleep(1500);
                    }

                    // 11-1. 창고 전진
                    ContCylFWD_Click(sender, e);
                    Thread.Sleep(1500);
                }

                // 시퀀스 종료 후 컨베이어 Off
                ConvOff_Click(sender, e);
            }

        }

        private void MotorON_MouseDown(object sender, MouseEventArgs e)
        {
            // 서보모터가 원형으로 돌아간다고 생각하고 상승과 하강에 신호를 넣고 빼고 해준다.
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 2, true); // 상승
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 3, false); // 하강
        }

        private void MotorON_MouseUp(object sender, MouseEventArgs e)
        {
            // 멈춤, 둘다 신호를 뺀다.
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 2, false); // 상승
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 3, false); // 하강
        }

        private void MotorOff_MouseDown(object sender, MouseEventArgs e)
        {
            // 서보모터가 원형으로 돌아간다고 생각하고 상승과 하강에 신호를 넣고 빼고 해준다.
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 2, false); // 상승
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 3, true); // 하강
        }

        private void MotorOff_MouseUp(object sender, MouseEventArgs e)
        {
            // 멈춤, 둘다 신호를 뺀다.
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 2, false); // 상승
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 2, 3, false); // 하강
        }

        public void LogMessage(string message)
        {
            if (rtbLogs.InvokeRequired)
            {
                rtbLogs.Invoke(new Action(() => LogMessage(message)));
            }
            else
            {
                rtbLogs.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n");
                rtbLogs.ScrollToCaret();
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            LogMessage("EQP Mode: AUTO selected.");
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            LogMessage("EQP Mode: MANUAL selected.");
        }

        private void btnContinuousRun_Click(object sender, EventArgs e)
        {
            LogMessage("연속 운전 시작");
        }

        private void btnCycleStop_Click(object sender, EventArgs e)
        {
            LogMessage("사이클 정지됨");
        }

        private void btnEmergencyStop_Click(object sender, EventArgs e)
        {
            LogMessage("비상 정지 발동!");
        }

        private void btnAutoTest_Click(object sender, EventArgs e)
        {
            LogMessage("Auto Menu: Test 버튼 클릭됨");
        }

        private void btnStatusStop_Click(object sender, EventArgs e)
        {
            LogMessage("설비 상태: Stop 클릭");
        }

        private void btnStatusWork_Click(object sender, EventArgs e)
        {
            LogMessage("설비 상태: Work 클릭");
        }

        private void btnStatusTest_Click(object sender, EventArgs e)
        {
            LogMessage("설비 상태: Test 클릭");
        }

        private void btnIOMonitor_Click(object sender, EventArgs e)
        {
            LogMessage("IO Monitor 열기");
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtbLogs.Clear();
        }
    }
}
