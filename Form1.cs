using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stop_Watch
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        int hour = 0, min = 0, sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec==60)
            {
                sec = 0;
                min++;
                if(min==60)
                {
                    min = 0;
                    hour++;
                }
            }
            label1.Text = hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
        }
        private  void Stop(object sender,EventArgs e)
        {
            hour = 0;
            min = 0;
            sec = 0;
            label1.Text = "00:00:00";
            timer1.Stop();
         button1.Text = "Start 》";
            button1.BackColor = Color.Lime;

            timer1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled =!timer1.Enabled;
           if(timer1.Enabled)
            {
                button1.Text = "Pause □";
                button1.BackColor = Color.Orange;
            }
           else
            {
                button1.Text = "Start 》";
                button1.BackColor = Color.Lime;
            }

        }
    }
}
