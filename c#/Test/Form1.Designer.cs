namespace test
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
            this.btnSignal = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnSignal2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignal
            // 
            this.btnSignal.Location = new System.Drawing.Point(62, 25);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.Size = new System.Drawing.Size(723, 403);
            this.btnSignal.TabIndex = 0;
            this.btnSignal.Text = "신호";
            this.btnSignal.UseVisualStyleBackColor = true;
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(934, 50);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(723, 199);
            this.btnTop.TabIndex = 1;
            this.btnTop.Text = "1";
            this.btnTop.UseVisualStyleBackColor = true;
            // 
            // btnMiddle
            // 
            this.btnMiddle.Location = new System.Drawing.Point(934, 320);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(723, 199);
            this.btnMiddle.TabIndex = 2;
            this.btnMiddle.Text = "2";
            this.btnMiddle.UseVisualStyleBackColor = true;
            // 
            // btnBot
            // 
            this.btnBot.Location = new System.Drawing.Point(934, 599);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(723, 199);
            this.btnBot.TabIndex = 3;
            this.btnBot.Text = "3";
            this.btnBot.UseVisualStyleBackColor = true;
            // 
            // btnSignal2
            // 
            this.btnSignal2.Location = new System.Drawing.Point(62, 448);
            this.btnSignal2.Name = "btnSignal2";
            this.btnSignal2.Size = new System.Drawing.Size(723, 403);
            this.btnSignal2.TabIndex = 4;
            this.btnSignal2.Text = "신호";
            this.btnSignal2.UseVisualStyleBackColor = true;
            this.btnSignal2.Click += new System.EventHandler(this.btnSignal2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2153, 892);
            this.Controls.Add(this.btnSignal2);
            this.Controls.Add(this.btnBot);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnSignal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignal;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnSignal2;
    }
}

