namespace BeautyForestAgent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTray = new System.Windows.Forms.Button();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.clsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.폼보이기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.clsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautyForestAgent.Properties.Resources.demo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "(주)미림스쿨 - Beauty Forest Agent v0.1 by 3113 이유정";
            // 
            // btnTray
            // 
            this.btnTray.Location = new System.Drawing.Point(702, 254);
            this.btnTray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTray.Name = "btnTray";
            this.btnTray.Size = new System.Drawing.Size(30, 18);
            this.btnTray.TabIndex = 2;
            this.btnTray.Text = "▼";
            this.btnTray.UseVisualStyleBackColor = true;
            // 
            // nIcon
            // 
            this.nIcon.ContextMenuStrip = this.clsStrip;
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "notifyIcon1";
            // 
            // clsStrip
            // 
            this.clsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼보이기ToolStripMenuItem,
            this.종료하기ToolStripMenuItem});
            this.clsStrip.Name = "clsStrip";
            this.clsStrip.Size = new System.Drawing.Size(127, 48);
            // 
            // 폼보이기ToolStripMenuItem
            // 
            this.폼보이기ToolStripMenuItem.Name = "폼보이기ToolStripMenuItem";
            this.폼보이기ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.폼보이기ToolStripMenuItem.Text = "폼 보이기";
            // 
            // 종료하기ToolStripMenuItem
            // 
            this.종료하기ToolStripMenuItem.Name = "종료하기ToolStripMenuItem";
            this.종료하기ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.종료하기ToolStripMenuItem.Text = "종료하기";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 279);
            this.Controls.Add(this.btnTray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beauty Forest Agent v0.1 by 3113 이유정";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.clsStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTray;
        private System.Windows.Forms.NotifyIcon nIcon;
        private System.Windows.Forms.ContextMenuStrip clsStrip;
        private System.Windows.Forms.ToolStripMenuItem 폼보이기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료하기ToolStripMenuItem;
    }
}

