namespace MES
{
    partial class InventoryControl
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

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.cardTitle = new System.Windows.Forms.Label();
            this.cardTarget = new System.Windows.Forms.Label();
            this.cardActual = new System.Windows.Forms.Label();
            this.cardRate = new System.Windows.Forms.Label();
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(65)))), ((int)(((byte)(12)))));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(378, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "재고관리 현황 (Inventory Status)";
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.White;
            this.cardPanel.Controls.Add(this.cardRate);
            this.cardPanel.Controls.Add(this.cardActual);
            this.cardPanel.Controls.Add(this.cardTarget);
            this.cardPanel.Controls.Add(this.cardTitle);
            this.cardPanel.Location = new System.Drawing.Point(20, 70);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(540, 150);
            this.cardPanel.TabIndex = 1;
            // 
            // cardTitle
            // 
            this.cardTitle.AutoSize = true;
            this.cardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cardTitle.Location = new System.Drawing.Point(15, 15);
            this.cardTitle.Name = "cardTitle";
            this.cardTitle.Size = new System.Drawing.Size(186, 21);
            this.cardTitle.TabIndex = 0;
            this.cardTitle.Text = "주요 자재 재고 현황";
            // 
            // cardTarget
            // 
            this.cardTarget.AutoSize = true;
            this.cardTarget.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cardTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cardTarget.Location = new System.Drawing.Point(20, 50);
            this.cardTarget.Name = "cardTarget";
            this.cardTarget.Size = new System.Drawing.Size(148, 19);
            this.cardTarget.TabIndex = 1;
            this.cardTarget.Text = "• 웨이퍼 재고: 15,230 EA";
            // 
            // cardActual
            // 
            this.cardActual.AutoSize = true;
            this.cardActual.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cardActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cardActual.Location = new System.Drawing.Point(20, 80);
            this.cardActual.Name = "cardActual";
            this.cardActual.Size = new System.Drawing.Size(148, 19);
            this.cardActual.TabIndex = 2;
            this.cardActual.Text = "• 화학 약품(PR): 1,200 L";
            // 
            // cardRate
            // 
            this.cardRate.AutoSize = true;
            this.cardRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cardRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.cardRate.Location = new System.Drawing.Point(20, 110);
            this.cardRate.Name = "cardRate";
            this.cardRate.Size = new System.Drawing.Size(212, 19);
            this.cardRate.TabIndex = 3;
            this.cardRate.Text = "• 재고 상태: 적정 (안정 수준 유지)";
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(592, 450);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Label cardTitle;
        private System.Windows.Forms.Label cardTarget;
        private System.Windows.Forms.Label cardActual;
        private System.Windows.Forms.Label cardRate;
    }
}
