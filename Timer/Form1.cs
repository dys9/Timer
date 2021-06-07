using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Timer
{
    public partial class Form1 : Form
    {
        int restTime = 0;
        bool isCounting = false;

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int n, int m);
        
        public Form1()
        {
            InitializeComponent();

            int hour = Int32.Parse(DateTime.Now.ToString("hh"));
            int minute = Int32.Parse(DateTime.Now.ToString("mm"));

            numWork.Value = 40;
            numShortRest.Value = 5;
            numShortCount.Value = 2;
            numLongRest.Value = 20;

            restTime = Decimal.ToInt32(numWork.Value) * 60;
            restTime = 1;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isCounting)
            {
                btnStart.Text = "일시정지";
                timer.Tick += Timer_Tick;

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                isCounting = true;

                timer.Interval = (int)1000;
                timer.Start();
            }
            else if (isCounting)
            {
                btnStart.Text = "시작";

                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                isCounting = false;

                timer.Tick -= Timer_Tick;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            restTime--;

            int h = restTime / 3600;
            int m = restTime / 60;
            int s = restTime % 60;

            strRestTime.Text = string.Format($"{h}:{m}:{s}");

            if (restTime == 0)
            {
                Beep(256*2, 200); // 도
                Beep(320*2, 200); // 미
                Beep(384*2, 200); // 레
                Beep(256*4, 200); // 도
            }
        }

        private void numWork_ValueChanged(object sender, EventArgs e)
        {
            restTime = Decimal.ToInt32(numWork.Value) * 60;
        }
    }
}
