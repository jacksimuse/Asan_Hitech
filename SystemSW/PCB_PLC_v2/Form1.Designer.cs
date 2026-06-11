namespace PCB_PLC
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.gbEQPMode = new System.Windows.Forms.GroupBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.gbAutoMenu = new System.Windows.Forms.GroupBox();
            this.OneCycle = new System.Windows.Forms.Button();
            this.btnContinuousRun = new System.Windows.Forms.Button();
            this.btnCycleStop = new System.Windows.Forms.Button();
            this.btnEmergencyStop = new System.Windows.Forms.Button();
            this.btnAutoTest = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.btnStatusStop = new System.Windows.Forms.Button();
            this.btnStatusWork = new System.Windows.Forms.Button();
            this.btnStatusTest = new System.Windows.Forms.Button();
            this.gbManualMenu = new System.Windows.Forms.GroupBox();
            this.EqpInit = new System.Windows.Forms.Button();
            this.btnIOMonitor = new System.Windows.Forms.Button();
            this.gbMachine = new System.Windows.Forms.GroupBox();
            this.loadCylFWD = new System.Windows.Forms.Button();
            this.loadCylBWD = new System.Windows.Forms.Button();
            this.WorkCylFWD = new System.Windows.Forms.Button();
            this.WorkCylBWD = new System.Windows.Forms.Button();
            this.MoveCylFWD = new System.Windows.Forms.Button();
            this.MoveCylBWD = new System.Windows.Forms.Button();
            this.UnldCylFWD = new System.Windows.Forms.Button();
            this.UnldCylBWD = new System.Windows.Forms.Button();
            this.ContCylFWD = new System.Windows.Forms.Button();
            this.ContCylBWD = new System.Windows.Forms.Button();
            this.SuctionON = new System.Windows.Forms.Button();
            this.SuctionOff = new System.Windows.Forms.Button();
            this.DrillOn = new System.Windows.Forms.Button();
            this.DrillOff = new System.Windows.Forms.Button();
            this.ConvOn = new System.Windows.Forms.Button();
            this.ConvOff = new System.Windows.Forms.Button();
            this.stopperFWD = new System.Windows.Forms.Button();
            this.stopperBWD = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.MotorON = new System.Windows.Forms.Button();
            this.MotorOff = new System.Windows.Forms.Button();
            this.StackFWD = new System.Windows.Forms.Button();
            this.StackBWD = new System.Windows.Forms.Button();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            
            this.gbEQPMode.SuspendLayout();
            this.gbAutoMenu.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbManualMenu.SuspendLayout();
            this.gbMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEQPMode
            // 
            this.gbEQPMode.Controls.Add(this.btnAuto);
            this.gbEQPMode.Controls.Add(this.btnManual);
            this.gbEQPMode.Location = new System.Drawing.Point(12, 12);
            this.gbEQPMode.Name = "gbEQPMode";
            this.gbEQPMode.Size = new System.Drawing.Size(200, 80);
            this.gbEQPMode.TabIndex = 0;
            this.gbEQPMode.TabStop = false;
            this.gbEQPMode.Text = "EQP Mode";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(6, 20);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(85, 45);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "AUTO";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(100, 20);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(85, 45);
            this.btnManual.TabIndex = 1;
            this.btnManual.Text = "MANUAL";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // gbAutoMenu
            // 
            this.gbAutoMenu.Controls.Add(this.btnAutoTest);
            this.gbAutoMenu.Controls.Add(this.btnEmergencyStop);
            this.gbAutoMenu.Controls.Add(this.btnCycleStop);
            this.gbAutoMenu.Controls.Add(this.btnContinuousRun);
            this.gbAutoMenu.Controls.Add(this.OneCycle);
            this.gbAutoMenu.Location = new System.Drawing.Point(12, 98);
            this.gbAutoMenu.Name = "gbAutoMenu";
            this.gbAutoMenu.Size = new System.Drawing.Size(200, 410);
            this.gbAutoMenu.TabIndex = 1;
            this.gbAutoMenu.TabStop = false;
            this.gbAutoMenu.Text = "AutoMenu";
            // 
            // OneCycle
            // 
            this.OneCycle.Location = new System.Drawing.Point(6, 30);
            this.OneCycle.Name = "OneCycle";
            this.OneCycle.Size = new System.Drawing.Size(188, 40);
            this.OneCycle.TabIndex = 29;
            this.OneCycle.Text = "1회 운전";
            this.OneCycle.UseVisualStyleBackColor = true;
            this.OneCycle.Click += new System.EventHandler(this.OneCycle_Click);
            // 
            // btnContinuousRun
            // 
            this.btnContinuousRun.Location = new System.Drawing.Point(6, 80);
            this.btnContinuousRun.Name = "btnContinuousRun";
            this.btnContinuousRun.Size = new System.Drawing.Size(188, 40);
            this.btnContinuousRun.TabIndex = 30;
            this.btnContinuousRun.Text = "연속 운전";
            this.btnContinuousRun.UseVisualStyleBackColor = true;
            this.btnContinuousRun.Click += new System.EventHandler(this.btnContinuousRun_Click);
            // 
            // btnCycleStop
            // 
            this.btnCycleStop.Location = new System.Drawing.Point(6, 130);
            this.btnCycleStop.Name = "btnCycleStop";
            this.btnCycleStop.Size = new System.Drawing.Size(188, 40);
            this.btnCycleStop.TabIndex = 31;
            this.btnCycleStop.Text = "사이클 정지";
            this.btnCycleStop.UseVisualStyleBackColor = true;
            this.btnCycleStop.Click += new System.EventHandler(this.btnCycleStop_Click);
            // 
            // btnEmergencyStop
            // 
            this.btnEmergencyStop.Location = new System.Drawing.Point(6, 180);
            this.btnEmergencyStop.Name = "btnEmergencyStop";
            this.btnEmergencyStop.Size = new System.Drawing.Size(188, 40);
            this.btnEmergencyStop.TabIndex = 32;
            this.btnEmergencyStop.Text = "비상 정지";
            this.btnEmergencyStop.UseVisualStyleBackColor = true;
            this.btnEmergencyStop.Click += new System.EventHandler(this.btnEmergencyStop_Click);
            // 
            // btnAutoTest
            // 
            this.btnAutoTest.Location = new System.Drawing.Point(6, 350);
            this.btnAutoTest.Name = "btnAutoTest";
            this.btnAutoTest.Size = new System.Drawing.Size(188, 40);
            this.btnAutoTest.TabIndex = 33;
            this.btnAutoTest.Text = "test";
            this.btnAutoTest.UseVisualStyleBackColor = true;
            this.btnAutoTest.Click += new System.EventHandler(this.btnAutoTest_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.btnStatusTest);
            this.gbStatus.Controls.Add(this.btnStatusWork);
            this.gbStatus.Controls.Add(this.btnStatusStop);
            this.gbStatus.Location = new System.Drawing.Point(542, 12);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(250, 80);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "설비 상태";
            // 
            // btnStatusStop
            // 
            this.btnStatusStop.BackColor = System.Drawing.Color.Red;
            this.btnStatusStop.ForeColor = System.Drawing.Color.White;
            this.btnStatusStop.Location = new System.Drawing.Point(10, 20);
            this.btnStatusStop.Name = "btnStatusStop";
            this.btnStatusStop.Size = new System.Drawing.Size(70, 45);
            this.btnStatusStop.TabIndex = 0;
            this.btnStatusStop.Text = "Stop";
            this.btnStatusStop.UseVisualStyleBackColor = false;
            this.btnStatusStop.Click += new System.EventHandler(this.btnStatusStop_Click);
            // 
            // btnStatusWork
            // 
            this.btnStatusWork.Location = new System.Drawing.Point(90, 20);
            this.btnStatusWork.Name = "btnStatusWork";
            this.btnStatusWork.Size = new System.Drawing.Size(70, 45);
            this.btnStatusWork.TabIndex = 1;
            this.btnStatusWork.Text = "work";
            this.btnStatusWork.UseVisualStyleBackColor = true;
            this.btnStatusWork.Click += new System.EventHandler(this.btnStatusWork_Click);
            // 
            // btnStatusTest
            // 
            this.btnStatusTest.Location = new System.Drawing.Point(170, 20);
            this.btnStatusTest.Name = "btnStatusTest";
            this.btnStatusTest.Size = new System.Drawing.Size(70, 45);
            this.btnStatusTest.TabIndex = 2;
            this.btnStatusTest.Text = "test";
            this.btnStatusTest.UseVisualStyleBackColor = true;
            this.btnStatusTest.Click += new System.EventHandler(this.btnStatusTest_Click);
            // 
            // gbManualMenu
            // 
            this.gbManualMenu.Controls.Add(this.gbMachine);
            this.gbManualMenu.Controls.Add(this.btnIOMonitor);
            this.gbManualMenu.Controls.Add(this.EqpInit);
            this.gbManualMenu.Location = new System.Drawing.Point(218, 98);
            this.gbManualMenu.Name = "gbManualMenu";
            this.gbManualMenu.Size = new System.Drawing.Size(754, 410);
            this.gbManualMenu.TabIndex = 3;
            this.gbManualMenu.TabStop = false;
            this.gbManualMenu.Text = "Manual Menu";
            // 
            // EqpInit
            // 
            this.EqpInit.Location = new System.Drawing.Point(30, 20);
            this.EqpInit.Name = "EqpInit";
            this.EqpInit.Size = new System.Drawing.Size(200, 40);
            this.EqpInit.TabIndex = 15;
            this.EqpInit.Text = "장비 초기화";
            this.EqpInit.UseVisualStyleBackColor = true;
            this.EqpInit.Click += new System.EventHandler(this.EqpInit_Click);
            // 
            // btnIOMonitor
            // 
            this.btnIOMonitor.Location = new System.Drawing.Point(520, 20);
            this.btnIOMonitor.Name = "btnIOMonitor";
            this.btnIOMonitor.Size = new System.Drawing.Size(200, 40);
            this.btnIOMonitor.TabIndex = 16;
            this.btnIOMonitor.Text = "IO Monitor";
            this.btnIOMonitor.UseVisualStyleBackColor = true;
            this.btnIOMonitor.Click += new System.EventHandler(this.btnIOMonitor_Click);
            // 
            // gbMachine
            // 
            this.gbMachine.Controls.Add(this.loadCylFWD);
            this.gbMachine.Controls.Add(this.loadCylBWD);
            this.gbMachine.Controls.Add(this.WorkCylFWD);
            this.gbMachine.Controls.Add(this.WorkCylBWD);
            this.gbMachine.Controls.Add(this.MoveCylFWD);
            this.gbMachine.Controls.Add(this.MoveCylBWD);
            this.gbMachine.Controls.Add(this.UnldCylFWD);
            this.gbMachine.Controls.Add(this.UnldCylBWD);
            this.gbMachine.Controls.Add(this.ContCylFWD);
            this.gbMachine.Controls.Add(this.ContCylBWD);
            this.gbMachine.Controls.Add(this.SuctionON);
            this.gbMachine.Controls.Add(this.SuctionOff);
            this.gbMachine.Controls.Add(this.DrillOn);
            this.gbMachine.Controls.Add(this.DrillOff);
            this.gbMachine.Controls.Add(this.ConvOn);
            this.gbMachine.Controls.Add(this.ConvOff);
            this.gbMachine.Controls.Add(this.stopperFWD);
            this.gbMachine.Controls.Add(this.stopperBWD);
            this.gbMachine.Controls.Add(this.Red);
            this.gbMachine.Controls.Add(this.Yellow);
            this.gbMachine.Controls.Add(this.Green);
            this.gbMachine.Controls.Add(this.MotorON);
            this.gbMachine.Controls.Add(this.MotorOff);
            this.gbMachine.Controls.Add(this.StackFWD);
            this.gbMachine.Controls.Add(this.StackBWD);
            this.gbMachine.Location = new System.Drawing.Point(10, 70);
            this.gbMachine.Name = "gbMachine";
            this.gbMachine.Size = new System.Drawing.Size(730, 320);
            this.gbMachine.TabIndex = 17;
            this.gbMachine.TabStop = false;
            this.gbMachine.Text = "Machine";
            // 
            // loadCylFWD
            // 
            this.loadCylFWD.BackColor = System.Drawing.Color.LightGray;
            this.loadCylFWD.Location = new System.Drawing.Point(20, 20);
            this.loadCylFWD.Name = "loadCylFWD";
            this.loadCylFWD.Size = new System.Drawing.Size(130, 40);
            this.loadCylFWD.TabIndex = 5;
            this.loadCylFWD.Text = "LoadCyl FWD";
            this.loadCylFWD.UseVisualStyleBackColor = false;
            this.loadCylFWD.Click += new System.EventHandler(this.loadCylFWD_Click);
            // 
            // loadCylBWD
            // 
            this.loadCylBWD.BackColor = System.Drawing.Color.LightBlue;
            this.loadCylBWD.Location = new System.Drawing.Point(160, 20);
            this.loadCylBWD.Name = "loadCylBWD";
            this.loadCylBWD.Size = new System.Drawing.Size(130, 40);
            this.loadCylBWD.TabIndex = 6;
            this.loadCylBWD.Text = "LoadCyl BWD";
            this.loadCylBWD.UseVisualStyleBackColor = false;
            this.loadCylBWD.Click += new System.EventHandler(this.loadCylBWD_Click);
            // 
            // WorkCylFWD
            // 
            this.WorkCylFWD.BackColor = System.Drawing.Color.LightGray;
            this.WorkCylFWD.Location = new System.Drawing.Point(20, 70);
            this.WorkCylFWD.Name = "WorkCylFWD";
            this.WorkCylFWD.Size = new System.Drawing.Size(130, 40);
            this.WorkCylFWD.TabIndex = 9;
            this.WorkCylFWD.Text = "WorkCyl FWD";
            this.WorkCylFWD.UseVisualStyleBackColor = false;
            this.WorkCylFWD.Click += new System.EventHandler(this.WorkCylFWD_Click);
            // 
            // WorkCylBWD
            // 
            this.WorkCylBWD.BackColor = System.Drawing.Color.LightBlue;
            this.WorkCylBWD.Location = new System.Drawing.Point(160, 70);
            this.WorkCylBWD.Name = "WorkCylBWD";
            this.WorkCylBWD.Size = new System.Drawing.Size(130, 40);
            this.WorkCylBWD.TabIndex = 10;
            this.WorkCylBWD.Text = "WorkCyl BWD";
            this.WorkCylBWD.UseVisualStyleBackColor = false;
            this.WorkCylBWD.Click += new System.EventHandler(this.WorkCylBWD_Click);
            // 
            // MoveCylFWD
            // 
            this.MoveCylFWD.BackColor = System.Drawing.Color.LightGray;
            this.MoveCylFWD.Location = new System.Drawing.Point(20, 120);
            this.MoveCylFWD.Name = "MoveCylFWD";
            this.MoveCylFWD.Size = new System.Drawing.Size(130, 40);
            this.MoveCylFWD.TabIndex = 11;
            this.MoveCylFWD.Text = "MoveCyl FWD";
            this.MoveCylFWD.UseVisualStyleBackColor = false;
            this.MoveCylFWD.Click += new System.EventHandler(this.MoveCylFWD_Click);
            // 
            // MoveCylBWD
            // 
            this.MoveCylBWD.BackColor = System.Drawing.Color.LightBlue;
            this.MoveCylBWD.Location = new System.Drawing.Point(160, 120);
            this.MoveCylBWD.Name = "MoveCylBWD";
            this.MoveCylBWD.Size = new System.Drawing.Size(130, 40);
            this.MoveCylBWD.TabIndex = 12;
            this.MoveCylBWD.Text = "MoveCyl BWD";
            this.MoveCylBWD.UseVisualStyleBackColor = false;
            this.MoveCylBWD.Click += new System.EventHandler(this.MoveCylBWD_Click);
            // 
            // UnldCylFWD
            // 
            this.UnldCylFWD.BackColor = System.Drawing.Color.LightGray;
            this.UnldCylFWD.Location = new System.Drawing.Point(20, 170);
            this.UnldCylFWD.Name = "UnldCylFWD";
            this.UnldCylFWD.Size = new System.Drawing.Size(130, 40);
            this.UnldCylFWD.TabIndex = 13;
            this.UnldCylFWD.Text = "UnldCyl FWD";
            this.UnldCylFWD.UseVisualStyleBackColor = false;
            this.UnldCylFWD.Click += new System.EventHandler(this.UnldCylFWD_Click);
            // 
            // UnldCylBWD
            // 
            this.UnldCylBWD.BackColor = System.Drawing.Color.LightBlue;
            this.UnldCylBWD.Location = new System.Drawing.Point(160, 170);
            this.UnldCylBWD.Name = "UnldCylBWD";
            this.UnldCylBWD.Size = new System.Drawing.Size(130, 40);
            this.UnldCylBWD.TabIndex = 14;
            this.UnldCylBWD.Text = "UnldCyl BWD";
            this.UnldCylBWD.UseVisualStyleBackColor = false;
            this.UnldCylBWD.Click += new System.EventHandler(this.UnldCylBWD_Click);
            // 
            // ContCylFWD
            // 
            this.ContCylFWD.BackColor = System.Drawing.Color.LightGray;
            this.ContCylFWD.Location = new System.Drawing.Point(20, 220);
            this.ContCylFWD.Name = "ContCylFWD";
            this.ContCylFWD.Size = new System.Drawing.Size(130, 40);
            this.ContCylFWD.TabIndex = 7;
            this.ContCylFWD.Text = "ContCyl FWD";
            this.ContCylFWD.UseVisualStyleBackColor = false;
            this.ContCylFWD.Click += new System.EventHandler(this.ContCylFWD_Click);
            // 
            // ContCylBWD
            // 
            this.ContCylBWD.BackColor = System.Drawing.Color.LightBlue;
            this.ContCylBWD.Location = new System.Drawing.Point(160, 220);
            this.ContCylBWD.Name = "ContCylBWD";
            this.ContCylBWD.Size = new System.Drawing.Size(130, 40);
            this.ContCylBWD.TabIndex = 8;
            this.ContCylBWD.Text = "ContCyl BWD";
            this.ContCylBWD.UseVisualStyleBackColor = false;
            this.ContCylBWD.Click += new System.EventHandler(this.ContCylBWD_Click);
            // 
            // SuctionON
            // 
            this.SuctionON.BackColor = System.Drawing.Color.LightGray;
            this.SuctionON.Location = new System.Drawing.Point(20, 270);
            this.SuctionON.Name = "SuctionON";
            this.SuctionON.Size = new System.Drawing.Size(130, 40);
            this.SuctionON.TabIndex = 27;
            this.SuctionON.Text = "Suction On";
            this.SuctionON.UseVisualStyleBackColor = false;
            this.SuctionON.Click += new System.EventHandler(this.SuctionON_Click);
            // 
            // SuctionOff
            // 
            this.SuctionOff.BackColor = System.Drawing.Color.LightBlue;
            this.SuctionOff.Location = new System.Drawing.Point(160, 270);
            this.SuctionOff.Name = "SuctionOff";
            this.SuctionOff.Size = new System.Drawing.Size(130, 40);
            this.SuctionOff.TabIndex = 28;
            this.SuctionOff.Text = "Suction Off";
            this.SuctionOff.UseVisualStyleBackColor = false;
            this.SuctionOff.Click += new System.EventHandler(this.SuctionOff_Click);
            // 
            // DrillOn
            // 
            this.DrillOn.BackColor = System.Drawing.Color.LightGray;
            this.DrillOn.Location = new System.Drawing.Point(420, 20);
            this.DrillOn.Name = "DrillOn";
            this.DrillOn.Size = new System.Drawing.Size(130, 40);
            this.DrillOn.TabIndex = 18;
            this.DrillOn.Text = "Drill On";
            this.DrillOn.UseVisualStyleBackColor = false;
            this.DrillOn.Click += new System.EventHandler(this.DrillOn_Click);
            // 
            // DrillOff
            // 
            this.DrillOff.BackColor = System.Drawing.Color.LightBlue;
            this.DrillOff.Location = new System.Drawing.Point(560, 20);
            this.DrillOff.Name = "DrillOff";
            this.DrillOff.Size = new System.Drawing.Size(130, 40);
            this.DrillOff.TabIndex = 19;
            this.DrillOff.Text = "Drill Off";
            this.DrillOff.UseVisualStyleBackColor = false;
            this.DrillOff.Click += new System.EventHandler(this.DrillOff_Click);
            // 
            // ConvOn
            // 
            this.ConvOn.BackColor = System.Drawing.Color.LightGray;
            this.ConvOn.Location = new System.Drawing.Point(420, 70);
            this.ConvOn.Name = "ConvOn";
            this.ConvOn.Size = new System.Drawing.Size(130, 40);
            this.ConvOn.TabIndex = 20;
            this.ConvOn.Text = "Conv On";
            this.ConvOn.UseVisualStyleBackColor = false;
            this.ConvOn.Click += new System.EventHandler(this.ConvOn_Click);
            // 
            // ConvOff
            // 
            this.ConvOff.BackColor = System.Drawing.Color.LightBlue;
            this.ConvOff.Location = new System.Drawing.Point(560, 70);
            this.ConvOff.Name = "ConvOff";
            this.ConvOff.Size = new System.Drawing.Size(130, 40);
            this.ConvOff.TabIndex = 21;
            this.ConvOff.Text = "Conv Off";
            this.ConvOff.UseVisualStyleBackColor = false;
            this.ConvOff.Click += new System.EventHandler(this.ConvOff_Click);
            // 
            // stopperFWD
            // 
            this.stopperFWD.BackColor = System.Drawing.Color.LightBlue;
            this.stopperFWD.Location = new System.Drawing.Point(420, 120);
            this.stopperFWD.Name = "stopperFWD";
            this.stopperFWD.Size = new System.Drawing.Size(130, 40);
            this.stopperFWD.TabIndex = 16;
            this.stopperFWD.Text = "Stopper Up";
            this.stopperFWD.UseVisualStyleBackColor = false;
            this.stopperFWD.Click += new System.EventHandler(this.stopperFWD_Click);
            // 
            // stopperBWD
            // 
            this.stopperBWD.BackColor = System.Drawing.Color.LightGray;
            this.stopperBWD.Location = new System.Drawing.Point(560, 120);
            this.stopperBWD.Name = "stopperBWD";
            this.stopperBWD.Size = new System.Drawing.Size(130, 40);
            this.stopperBWD.TabIndex = 17;
            this.stopperBWD.Text = "Stopper Down";
            this.stopperBWD.UseVisualStyleBackColor = false;
            this.stopperBWD.Click += new System.EventHandler(this.stopperBWD_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.White;
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(420, 170);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(85, 40);
            this.Red.TabIndex = 22;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.White;
            this.Yellow.ForeColor = System.Drawing.Color.Orange;
            this.Yellow.Location = new System.Drawing.Point(510, 170);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(85, 40);
            this.Yellow.TabIndex = 23;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.White;
            this.Green.ForeColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(600, 170);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(85, 40);
            this.Green.TabIndex = 24;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // MotorON
            // 
            this.MotorON.BackColor = System.Drawing.Color.LightGray;
            this.MotorON.Location = new System.Drawing.Point(420, 220);
            this.MotorON.Name = "MotorON";
            this.MotorON.Size = new System.Drawing.Size(130, 40);
            this.MotorON.TabIndex = 30;
            this.MotorON.Text = "Motor Up";
            this.MotorON.UseVisualStyleBackColor = false;
            this.MotorON.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MotorON_MouseDown);
            this.MotorON.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MotorON_MouseUp);
            // 
            // MotorOff
            // 
            this.MotorOff.BackColor = System.Drawing.Color.LightGray;
            this.MotorOff.Location = new System.Drawing.Point(560, 220);
            this.MotorOff.Name = "MotorOff";
            this.MotorOff.Size = new System.Drawing.Size(130, 40);
            this.MotorOff.TabIndex = 31;
            this.MotorOff.Text = "Motor Down";
            this.MotorOff.UseVisualStyleBackColor = false;
            this.MotorOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MotorOff_MouseDown);
            this.MotorOff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MotorOff_MouseUp);
            // 
            // StackFWD
            // 
            this.StackFWD.BackColor = System.Drawing.Color.LightGray;
            this.StackFWD.Location = new System.Drawing.Point(420, 270);
            this.StackFWD.Name = "StackFWD";
            this.StackFWD.Size = new System.Drawing.Size(130, 40);
            this.StackFWD.TabIndex = 25;
            this.StackFWD.Text = "Jokjae FWD";
            this.StackFWD.UseVisualStyleBackColor = false;
            this.StackFWD.Click += new System.EventHandler(this.StackFWD_Click);
            // 
            // StackBWD
            // 
            this.StackBWD.BackColor = System.Drawing.Color.LightBlue;
            this.StackBWD.Location = new System.Drawing.Point(560, 270);
            this.StackBWD.Name = "StackBWD";
            this.StackBWD.Size = new System.Drawing.Size(130, 40);
            this.StackBWD.TabIndex = 26;
            this.StackBWD.Text = "Jokjae BWD";
            this.StackBWD.UseVisualStyleBackColor = false;
            this.StackBWD.Click += new System.EventHandler(this.StackBWD_Click);
            // 
            // rtbLogs
            // 
            this.rtbLogs.Location = new System.Drawing.Point(12, 520);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(850, 130);
            this.rtbLogs.TabIndex = 4;
            this.rtbLogs.Text = "";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Font = new System.Drawing.Font("굴림", 20F);
            this.btnClearLog.Location = new System.Drawing.Point(870, 520);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(100, 130);
            this.btnClearLog.TabIndex = 5;
            this.btnClearLog.Text = "clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.rtbLogs);
            this.Controls.Add(this.gbManualMenu);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbAutoMenu);
            this.Controls.Add(this.gbEQPMode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEQPMode.ResumeLayout(false);
            this.gbAutoMenu.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbManualMenu.ResumeLayout(false);
            this.gbMachine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEQPMode;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.GroupBox gbAutoMenu;
        private System.Windows.Forms.Button OneCycle;
        private System.Windows.Forms.Button btnContinuousRun;
        private System.Windows.Forms.Button btnCycleStop;
        private System.Windows.Forms.Button btnEmergencyStop;
        private System.Windows.Forms.Button btnAutoTest;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Button btnStatusStop;
        private System.Windows.Forms.Button btnStatusWork;
        private System.Windows.Forms.Button btnStatusTest;
        private System.Windows.Forms.GroupBox gbManualMenu;
        private System.Windows.Forms.Button EqpInit;
        private System.Windows.Forms.Button btnIOMonitor;
        private System.Windows.Forms.GroupBox gbMachine;
        private System.Windows.Forms.Button loadCylFWD;
        private System.Windows.Forms.Button loadCylBWD;
        private System.Windows.Forms.Button WorkCylFWD;
        private System.Windows.Forms.Button WorkCylBWD;
        private System.Windows.Forms.Button MoveCylFWD;
        private System.Windows.Forms.Button MoveCylBWD;
        private System.Windows.Forms.Button UnldCylFWD;
        private System.Windows.Forms.Button UnldCylBWD;
        private System.Windows.Forms.Button ContCylFWD;
        private System.Windows.Forms.Button ContCylBWD;
        private System.Windows.Forms.Button SuctionON;
        private System.Windows.Forms.Button SuctionOff;
        private System.Windows.Forms.Button DrillOn;
        private System.Windows.Forms.Button DrillOff;
        private System.Windows.Forms.Button ConvOn;
        private System.Windows.Forms.Button ConvOff;
        private System.Windows.Forms.Button stopperFWD;
        private System.Windows.Forms.Button stopperBWD;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button MotorON;
        private System.Windows.Forms.Button MotorOff;
        private System.Windows.Forms.Button StackFWD;
        private System.Windows.Forms.Button StackBWD;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Button btnClearLog;
    }
}
