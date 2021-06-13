using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Timer
{
    public partial class Form1 : Form
    {
        enum TimeState { Work, Short, Long };

        int formState = -1;
        int remainTime = 0;
        int workTime = 0;
        int shortRestTime = 0;
        int shortCount = 0;
        int longRestTime = 0;
        int numCycle = 0;

        bool isCounting = false;
        bool isExit = false;

        //State Work;
        //Thread WorkThread;
        //Mutex mut = new Mutex();

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int n, int m);
        
        public Form1()
        {
            InitializeComponent();

            int hour = Int32.Parse(DateTime.Now.ToString("hh"));
            int minute = Int32.Parse(DateTime.Now.ToString("mm"));

            this.Load += TrayIcon_Load;
            
            btnStart.BackColor = Color.PaleGreen;
            일시정지ToolStripMenuItem.BackColor = Color.PaleGreen;
            일시정지ToolStripMenuItem.Text = "시작";

            numWork.Value = 40;
            numShortRest.Value = 5;
            numShortCount.Value = 2;
            numLongRest.Value = 20;

            workTime = Decimal.ToInt32(numWork.Value)           * 60; // * 60
            shortRestTime = Decimal.ToInt32(numShortRest.Value) * 60;
            shortCount = Decimal.ToInt32(numShortCount.Value)   * 60;
            longRestTime = Decimal.ToInt32(numLongRest.Value)   * 60;

            //Work = new State((int)TimeState.Work, 100, shortRestTime, shortCount, longRestTime, strRestTime, strCycle, mut);
            //WorkThread = new Thread(Work.run);

            workTime = 10;
            shortRestTime = 5;
            shortCount = 2;
            longRestTime = 10;

            remainTime = workTime;

            MessageBox.Show(
                string.Format(
                $"WorkTime : {workTime}\n" +
                $"ShortTime : {shortRestTime}\n" +
                $"ShortCount : {shortCount}\n" +
                $"LongTime : {longRestTime}\n" +
                $"remainTime : {remainTime}"
            ));
        }

        public void TrayIcon_Load(object sender, EventArgs e)
        {
            trayIcon.ContextMenuStrip = ctMenu;
        }

        private void start_OR_pause()
        {
            if (!isCounting)
            {
                btnStart.Text = "일시정지";
                btnStart.BackColor = Color.PaleVioletRed;

                일시정지ToolStripMenuItem.Text = "일시정지";
                일시정지ToolStripMenuItem.BackColor = Color.PaleVioletRed;

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                isCounting = true;

                formState = (int) TimeState.Work;

                //if (!WorkThread.IsAlive)
                //{
                //    Work.mutFlag = false;
                //    WorkThread.Start();
                //}
                //else if (WorkThread.IsAlive)
                //{
                //    Work.mutFlag = false;
                //}

            }
            else if (isCounting)
            {
                btnStart.Text = "시작";
                btnStart.BackColor = Color.PaleGreen;

                일시정지ToolStripMenuItem.Text = "시작";
                일시정지ToolStripMenuItem.BackColor = Color.PaleGreen;

                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                isCounting = false;

                //Work.mutFlag = true;
            }
        }

        public static string getTimeString(int t)
        {
            int h = t / 3600;
            int m = t / 60;
            int s = t % 60;

            return string.Format($"{h}:{m}:{s}");
        }

        private void endBeep()
        {
            Beep(256 * 2, 200); // 도
            Beep(320 * 2, 200); // 미
            Beep(384 * 2, 200); // 레
            Beep(256 * 4, 200); // 도
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start_OR_pause();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        #region 입력 변경 이벤트
        private void numWork_ValueChanged(object sender, EventArgs e)
        {
            workTime = Decimal.ToInt32(numWork.Value) * 60;
        }

        private void numShortRest_ValueChanged(object sender, EventArgs e)
        {
            shortRestTime = Decimal.ToInt32(numShortRest.Value) * 60;

        }

        private void numShortCount_ValueChanged(object sender, EventArgs e)
        {
            shortCount = Decimal.ToInt32(numShortCount.Value) * 60;

            if (numShortCount.Value == 0)
            {
                numShortRest.Value = 0;
                shortRestTime = 0;
                numShortRest.Enabled = false;
            }
            else
            {
                numShortRest.Enabled = true;
            }
        }

        private void numLongRest_ValueChanged(object sender, EventArgs e)
        {
            longRestTime = Decimal.ToInt32(numLongRest.Value) * 60;
        }
        #endregion

        private void 전체화면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowIcon = true;
        }

        private void 일시정지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_OR_pause();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Wanna close this Program?","Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isExit = true;
                
                //WorkThread.Abort();
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            { }
            else
            {
                this.Visible = false;
                this.ShowIcon = false;

                trayIcon.Visible = true;
                e.Cancel = true;
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowIcon = true;
        }
    }
}