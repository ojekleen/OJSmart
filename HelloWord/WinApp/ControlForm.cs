using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private delegate void InvokeDelegate(int i);

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(Start);
            thread.Start();
        }

        private void Start()
        {
            if (this.lblShow.InvokeRequired)
            {
                InvokeDelegate invDelegate = new InvokeDelegate(SetText);

                for (int i = 0; i < 100; i++)
                {
                    this.Invoke(invDelegate, new object[] { i });
                    TimeSpan ts = new TimeSpan(0, 0, 1);
                    System.Threading.Thread.Sleep(ts);
                }
            }
        }

        private void SetText(int i)
        {
            this.lblShow.Text = string.Format("处理条数：{0}", i);
        }
    }
}
