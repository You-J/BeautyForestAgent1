using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormChange(bool visible)
        {
            this.Visible = visible;
            this.nTray.Visible = !visible;
        }


        

        private void BtnTray_Click(object sender, EventArgs e)
        {
            FormChange(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            FormChange(false);
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChange(true);
        }

        private void 종료하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nTray.Visible = false;
            Application.ExitThread();  // 어플리케이션 쓰레드 완전 종료

        }

        private void NTray_DoubleClick(object sender, EventArgs e)
        {
            FormChange(true);
        }
    }
}
