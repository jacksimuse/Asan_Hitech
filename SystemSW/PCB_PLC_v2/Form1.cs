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
        // 실린더 및 시그널 타워 객체 선언
        private DoubleCylinder loadCyl;     // 공급 실린더
        private SingleCylinder workCyl;     // 드릴 가공 실린더
        private DoubleCylinder moveCyl;     // 분배 실린더
        private DoubleCylinder unldCyl;     // 취출 실린더
        private DoubleCylinder stackCyl;    // 적재 실린더
        private DoubleCylinder contCyl;     // 창고 실린더
        private SingleCylinder stopperCyl;  // 스토퍼 실린더
        private SignalTower signalTower;

        // 비동기 시퀀스 취소 제어용 토큰
        private CancellationTokenSource _cts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // SDK 초기화
            IO.Initialize();

            // 실린더 객체 인스턴스 생성 (한글 태그명, 전진입력, 후진입력, 전진출력, 후진출력)
            loadCyl = new DoubleCylinder("공급 실린더", IOMap.Input.LOAD_FWD, IOMap.Input.LOAD_BWD, IOMap.Output.LOAD_FWD, IOMap.Output.LOAD_BWD);
            workCyl = new SingleCylinder("드릴 실린더", IOMap.Input.DRILL_DOWN, IOMap.Input.DRILL_UP, IOMap.Output.DRILL_SOL);
            moveCyl = new DoubleCylinder("분배 실린더", IOMap.Input.MOVE_FWD, IOMap.Input.MOVE_BWD, IOMap.Output.MOVE_FWD, IOMap.Output.MOVE_BWD);
            unldCyl = new DoubleCylinder("취출 실린더", IOMap.Input.UNLD_FWD, IOMap.Input.UNLD_BWD, IOMap.Output.UNLD_FWD, IOMap.Output.UNLD_BWD);
            stackCyl = new DoubleCylinder("적재 실린더", IOMap.Input.STACK_FWD, IOMap.Input.STACK_BWD, IOMap.Output.STACK_FWD, IOMap.Output.STACK_BWD);
            contCyl = new DoubleCylinder("창고 실린더", IOMap.Input.CONT_FWD, IOMap.Input.CONT_BWD, IOMap.Output.CONT_FWD, IOMap.Output.CONT_BWD);
            stopperCyl = new SingleCylinder("스토퍼 실린더", IOMap.Input.STOPPER_DOWN, IOMap.Input.STOPPER_UP, IOMap.Output.STOPPER);

            // 시그널 타워 객체 인스턴스 생성 (한글 태그명, Red, Yellow, Green 출력)
            signalTower = new SignalTower("시그널 타워", IOMap.Output.RED_LAMP, IOMap.Output.YELLOW_LAMP, IOMap.Output.GREEN_LAMP);

            // 설비 상태 초기설정 (Stop 빨강)
            UpdateSystemState(SystemState.Stop);
            SetWorkStatus(false);
            SetTestStatus(false);
        }

        private void loadCylFWD_Click(object sender, EventArgs e)
        {
            loadCyl.MoveFwd();
        }

        private void loadCylBWD_Click(object sender, EventArgs e)
        {
            loadCyl.MoveBwd();
        }

        private void WorkCylFWD_Click(object sender, EventArgs e)
        {
            workCyl.MoveFwd();
        }

        private void WorkCylBWD_Click(object sender, EventArgs e)
        {
            workCyl.MoveBwd();
        }

        private void MoveCylFWD_Click(object sender, EventArgs e)
        {
            moveCyl.MoveFwd();
        }

        private void MoveCylBWD_Click(object sender, EventArgs e)
        {
            moveCyl.MoveBwd();
        }

        private void UnldCylFWD_Click(object sender, EventArgs e)
        {
            unldCyl.MoveFwd();
        }

        private void UnldCylBWD_Click(object sender, EventArgs e)
        {
            unldCyl.MoveBwd();
        }

        private void ContCylFWD_Click(object sender, EventArgs e)
        {
            contCyl.MoveFwd();
        }

        private void ContCylBWD_Click(object sender, EventArgs e)
        {
            contCyl.MoveBwd();
        }

        private void EqpInit_Click(object sender, EventArgs e)
        {
            // 실린더 후진
            loadCyl.MoveBwd();
            workCyl.MoveBwd();
            moveCyl.MoveBwd();
            unldCyl.MoveBwd();
            contCyl.MoveBwd();
            // 스토퍼 상승 (후진)
            stopperCyl.MoveBwd();

            // 모든 장비 (드릴, 컨베이어, 흡착 stop)
            IO.SetDrillMotor(false);
            IO.SetConveyor(false);
            IO.SetSuction(false);

            // 시그널 타워 (레드, 엘로우, 그린 불 켜기)
            signalTower.SetRed(true);
            signalTower.SetYellow(true);
            signalTower.SetGreen(true);

            // 설비 상태 업데이트 (초기화 했을 때 -> idle 노랑)
            UpdateSystemState(SystemState.Idle);
            SetWorkStatus(false);
            SetTestStatus(false);
        }

        private void StackFWD_Click(object sender, EventArgs e)
        {
            stackCyl.MoveFwd();
        }

        private void StackBWD_Click(object sender, EventArgs e)
        {
            stackCyl.MoveBwd();
        }

        private void DrillOn_Click(object sender, EventArgs e)
        {
            IO.SetDrillMotor(true);
        }

        private void DrillOff_Click(object sender, EventArgs e)
        {
            IO.SetDrillMotor(false);
        }

        private void ConvOn_Click(object sender, EventArgs e)
        {
            IO.SetConveyor(true);
        }

        private void ConvOff_Click(object sender, EventArgs e)
        {
            IO.SetConveyor(false);
        }

        private void Red_Click(object sender, EventArgs e)
        {
            signalTower.ToggleRed();
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            signalTower.ToggleYellow();
        }

        private void Green_Click(object sender, EventArgs e)
        {
            signalTower.ToggleGreen();
        }

        private void stopperFWD_Click(object sender, EventArgs e)
        {
            stopperCyl.MoveFwd();
        }

        private void stopperBWD_Click(object sender, EventArgs e)
        {
            stopperCyl.MoveBwd();
        }

        private void SuctionON_Click(object sender, EventArgs e)
        {
            IO.SetSuction(true);
        }

        private void SuctionOff_Click(object sender, EventArgs e)
        {
            IO.SetSuction(false);
        }

        private async void OneCycle_Click(object sender, EventArgs e)
        {
            // 이전 시퀀스가 실행 중이면 취소 후 리턴
            if (_cts != null && !_cts.IsCancellationRequested) return;

            _cts = new CancellationTokenSource();
            var ct = _cts.Token;

            // 동작 시작 (run 초록)
            UpdateSystemState(SystemState.Run);

            try
            {
                await Task.Run(async () =>
                {
                    // 워크 검출 확인 (Input Bit 0E)
                    if (IO.IsWorkDetected)
                    {
                        // work 활성화 (워크가 공급, 작업, 분배될 때까지 초록)
                        SetWorkStatus(true);

                        // 공급 후진 확인이면 공급 전진
                        loadCyl.MoveFwd();
                        await Task.Delay(1500, ct);

                        // 공급 전진 확인이면 공급 후진
                        loadCyl.MoveBwd();
                        await Task.Delay(1500, ct);

                        // 드릴 상승이면 드릴 하강
                        workCyl.MoveFwd();
                        await Task.Delay(1500, ct);

                        // 드릴 off면 on
                        IO.SetDrillMotor(true);
                        await Task.Delay(2000, ct);

                        // 드릴 on이면 off
                        IO.SetDrillMotor(false);
                        await Task.Delay(500, ct);

                        // 드릴 하강이면 상승
                        workCyl.MoveBwd();
                        await Task.Delay(1500, ct);

                        // 분배 후진에 신호가 있으면 분배 전진
                        moveCyl.MoveFwd();
                        await Task.Delay(1500, ct);

                        // 분배 전진에 신호가 있으면 분배 후진
                        moveCyl.MoveBwd();
                        await Task.Delay(1500, ct);

                        // work 비활성화
                        SetWorkStatus(false);

                        // ---- 워크 구간 완료 후 컨베이어 구간 진입 ----
                        // test 활성화: 컨베이어에 워크가 올라왔을 때부터 시작
                        SetTestStatus(true);

                        // 컨베이어 on
                        IO.SetConveyor(true);

                        // 워크가 센서 구역을 지나가는 동안 감지된 신호를 누적할 래치 변수
                        bool detectedInductive = false;
                        bool detectedCapacitive = false;

                        // 센서 중 하나라도 처음 감지될 때까지 대기
                        while (!IO.IsInductiveSensorOn && !IO.IsCapacitiveSensorOn)
                        {
                            ct.ThrowIfCancellationRequested();
                            await Task.Delay(30, ct);
                        }

                        // 1.5초 동안 신호 누적
                        for (int i = 0; i < 50; i++)
                        {
                            ct.ThrowIfCancellationRequested();
                            if (IO.IsInductiveSensorOn) detectedInductive = true;
                            if (IO.IsCapacitiveSensorOn) detectedCapacitive = true;
                            await Task.Delay(30, ct);
                        }

                        // 금속 판별: 유도형 + 용량형 모두 감지
                        if (detectedInductive && detectedCapacitive)
                        {
                            await Task.Delay(100, ct);

                            unldCyl.MoveFwd();
                            await Task.Delay(1500, ct);

                            if (unldCyl.IsFwd())
                            {
                                unldCyl.MoveBwd();
                                await Task.Delay(1500, ct);
                            }

                            IO.SetConveyor(false);
                        }
                        // 플라스틱 판별: 용량형만 감지
                        else if (detectedCapacitive && !detectedInductive)
                        {
                            await Task.Delay(700, ct);

                            stopperCyl.MoveFwd();
                            await Task.Delay(1500, ct);

                            if (IO.IsStopperDetected)
                            {
                                IO.SetLiftUp(false);
                                IO.SetLiftDown(true);

                                while (!IO.IsLiftAtBottom)
                                {
                                    ct.ThrowIfCancellationRequested();
                                    await Task.Delay(50, ct);
                                }
                                IO.SetLiftDown(false);
                                await Task.Delay(300, ct);

                                IO.SetSuction(true);
                                await Task.Delay(1000, ct);

                                IO.SetLiftDown(false);
                                IO.SetLiftUp(true);

                                while (!IO.IsLiftAtLevel1)
                                {
                                    ct.ThrowIfCancellationRequested();
                                    await Task.Delay(50, ct);
                                }
                                IO.SetLiftUp(false);
                                await Task.Delay(500, ct);

                                stackCyl.MoveFwd();
                                await Task.Delay(1500, ct);

                                IO.SetSuction(false);
                                await Task.Delay(1000, ct);

                                if (stackCyl.IsFwd())
                                {
                                    stackCyl.MoveBwd();
                                    await Task.Delay(1500, ct);
                                }

                                contCyl.MoveFwd();
                                await Task.Delay(1500, ct);
                            }

                            IO.SetConveyor(false);
                        }
                        else
                        {
                            // 센서에 아무것도 걸리지 않으면 컨베이어 off
                            IO.SetConveyor(false);
                        }

                        SetTestStatus(false);
                    }
                    // 워크가 검출되지 않은 경우: work/test 비활성화 후 종료
                    else
                    {
                        SetWorkStatus(false);
                        SetTestStatus(false);
                    }
                }, ct);

                // 1회운전 정상 완료시 -> stop 빨강
                UpdateSystemState(SystemState.Stop);
            }
            catch (OperationCanceledException)
            {
                // 비상정지 또는 사이클정지에 의한 취소
                IO.SetDrillMotor(false);
                IO.SetConveyor(false);
                IO.SetSuction(false);
                IO.SetLiftUp(false);
                IO.SetLiftDown(false);

                SetWorkStatus(false);
                SetTestStatus(false);
                LogMessage("시퀀스가 정지되었습니다.");
            }
            finally
            {
                _cts?.Dispose();
                _cts = null;
            }
        }

        private void MotorON_MouseDown(object sender, MouseEventArgs e)
        {
            IO.SetLiftUp(true);
            IO.SetLiftDown(false);
        }

        private void MotorON_MouseUp(object sender, MouseEventArgs e)
        {
            IO.SetLiftUp(false);
            IO.SetLiftDown(false);
        }

        private void MotorOff_MouseDown(object sender, MouseEventArgs e)
        {
            IO.SetLiftUp(false);
            IO.SetLiftDown(true);
        }

        private void MotorOff_MouseUp(object sender, MouseEventArgs e)
        {
            IO.SetLiftUp(false);
            IO.SetLiftDown(false);
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
            UpdateSystemState(SystemState.Run);
            // TODO: 연속 운전 시퀀스 루프 구현 시 _cts로 취소 연동
        }

        private void btnCycleStop_Click(object sender, EventArgs e)
        {
            LogMessage("사이클 정지됨");
            // 실행 중인 시퀀스 취소
            _cts?.Cancel();
            UpdateSystemState(SystemState.Idle); // 연속 운전 완료/정지 -> idle 노랑
            SetWorkStatus(false);
            SetTestStatus(false);
        }

        private void btnEmergencyStop_Click(object sender, EventArgs e)
        {
            LogMessage("비상 정지 발동!");
            // 실행 중인 시퀀스 즉시 취소
            _cts?.Cancel();
            UpdateSystemState(SystemState.Stop); // 비상 정지 -> stop 빨강
            SetWorkStatus(false);
            SetTestStatus(false);
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
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtbLogs.Clear();
        }

        // --- 설비 상태 색상 제어 헬퍼 메서드 및 ENUM ---

        private enum SystemState
        {
            Stop,
            Idle,
            Run
        }

        private void UpdateSystemState(SystemState state)
        {
            if (btnStatusStop.InvokeRequired)
            {
                btnStatusStop.Invoke(new Action(() => UpdateSystemState(state)));
                return;
            }

            switch (state)
            {
                case SystemState.Stop:
                    btnStatusStop.BackColor = Color.Red;
                    btnStatusStop.ForeColor = Color.White;
                    btnStatusStop.Text = "Stop";
                    break;
                case SystemState.Idle:
                    btnStatusStop.BackColor = Color.Yellow;
                    btnStatusStop.ForeColor = Color.Black;
                    btnStatusStop.Text = "Idle";
                    break;
                case SystemState.Run:
                    btnStatusStop.BackColor = Color.Green;
                    btnStatusStop.ForeColor = Color.White;
                    btnStatusStop.Text = "Run";
                    break;
            }
            btnStatusStop.Refresh();
        }

        private void SetWorkStatus(bool active)
        {
            if (btnStatusWork.InvokeRequired)
            {
                btnStatusWork.Invoke(new Action(() => SetWorkStatus(active)));
                return;
            }

            if (active)
            {
                btnStatusWork.BackColor = Color.Green;
                btnStatusWork.ForeColor = Color.White;
            }
            else
            {
                btnStatusWork.UseVisualStyleBackColor = true;
                btnStatusWork.BackColor = SystemColors.Control;
                btnStatusWork.ForeColor = SystemColors.ControlText;
            }
            btnStatusWork.Refresh();
        }

        private void SetTestStatus(bool active)
        {
            if (btnStatusTest.InvokeRequired)
            {
                btnStatusTest.Invoke(new Action(() => SetTestStatus(active)));
                return;
            }

            if (active)
            {
                btnStatusTest.BackColor = Color.Green;
                btnStatusTest.ForeColor = Color.White;
            }
            else
            {
                btnStatusTest.UseVisualStyleBackColor = true;
                btnStatusTest.BackColor = SystemColors.Control;
                btnStatusTest.ForeColor = SystemColors.ControlText;
            }
            btnStatusTest.Refresh();
        }
    }
}
