namespace test3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnState = new System.Windows.Forms.Button();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOn = new System.Windows.Forms.RadioButton();
            this.rdbOff = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(295, 12);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(244, 237);
            this.btnState.TabIndex = 0;
            this.btnState.Text = "상황 확인하기";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "빨강",
            "주황",
            "초록"});
            this.cboColor.Location = new System.Drawing.Point(15, 114);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(274, 26);
            this.cboColor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "시그널 타워 색깔";
            // 
            // rdbOn
            // 
            this.rdbOn.AutoSize = true;
            this.rdbOn.Checked = true;
            this.rdbOn.Location = new System.Drawing.Point(15, 185);
            this.rdbOn.Name = "rdbOn";
            this.rdbOn.Size = new System.Drawing.Size(56, 22);
            this.rdbOn.TabIndex = 3;
            this.rdbOn.TabStop = true;
            this.rdbOn.Text = "On";
            this.rdbOn.UseVisualStyleBackColor = true;
            // 
            // rdbOff
            // 
            this.rdbOff.AutoSize = true;
            this.rdbOff.Location = new System.Drawing.Point(15, 213);
            this.rdbOff.Name = "rdbOff";
            this.rdbOff.Size = new System.Drawing.Size(56, 22);
            this.rdbOff.TabIndex = 4;
            this.rdbOff.Text = "Off";
            this.rdbOff.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "시그널 타워 전원";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(164, 9);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(0, 18);
            this.lblPower.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(545, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 237);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "시그널 타워";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRed);
            this.flowLayoutPanel1.Controls.Add(this.btnYellow);
            this.flowLayoutPanel1.Controls.Add(this.btnGreen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 210);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(3, 72);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(286, 63);
            this.btnYellow.TabIndex = 8;
            this.btnYellow.UseVisualStyleBackColor = true;
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(3, 141);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(286, 63);
            this.btnGreen.TabIndex = 9;
            this.btnGreen.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(3, 3);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(286, 63);
            this.btnRed.TabIndex = 10;
            this.btnRed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbOff);
            this.Controls.Add(this.rdbOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.btnState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbOn;
        private System.Windows.Forms.RadioButton rdbOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
    }
}

