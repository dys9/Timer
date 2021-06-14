using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace Timer
{
    class TempState
    {
        #region Member Variable
        private int _timeState;
        public int timeState
        {
            get { return _timeState; }
            set { _timeState = value; }
        }

        private int _workTime;
        public int workTime
        {
            get { return _workTime; }
            set { _workTime = value; }
        }

        private int _shortRestTime;
        public int shortRestTime
        {
            get { return _shortRestTime; }
            set { _shortRestTime = value; }
        }

        private int _shortCount;
        public int shortCount
        {
            get { return _shortCount; }
            set { _shortCount = value; }
        }

        private int _longRestTime;
        public int longRestTime
        {
            get { return _longRestTime; }
            set { _longRestTime = value; }
        }

        private int _numCycle;
        public int numCycle
        {
            get { return _numCycle; }
            set { _numCycle = value; }
        }

        private Mutex _mut;
        public Mutex mut
        {
            get { return _mut; }
            set { _mut = value; }
        }

        private bool _mutFlag;
        public bool mutFlag
        {
            get { return _mutFlag; }
            set { _mutFlag = value; }
        }
        #endregion

        private int remainTime = 0;
        private Label Timelabel;
        private Label Cyclelabel;

        public TempState(int state, int worktime, int shorttime, int shortcount, int longtime, Label label, Label Cycle, Mutex mut)
        {
            this.timeState = state;
            this.workTime = worktime;
            this.shortRestTime = shorttime;
            this.shortCount = shortcount;
            this.longRestTime = longtime;
            this.numCycle = 0;
            this.Timelabel = label;
            this.Cyclelabel = Cycle;
            this.mut = mut;

            this.workTime = 10;
            this.remainTime = 10;
        }

        public void run()
        {
            while (true)
            {
                if (!mutFlag)
                {
                    remainTime--;
                    Thread.Sleep(1000);
                    Timelabel.Text = Form1.getTimeString(remainTime);

                    if (remainTime == 0)
                    {
                        if (shortCount > 1)  // 짧은 쉬는 시간의 수가 1 이상일 경우
                        {
                            for (int i = 0; i < shortCount; i++) // 짧은 쉬는 시간의 수 만큼
                            {
                                remainTime = shortRestTime; // 쉬는 시간 정의
                                while (remainTime > 0) // 쉬는 시간이 끝나는 동안
                                {
                                    remainTime--;
                                    Thread.Sleep(1000);
                                    Timelabel.Text = Form1.getTimeString(remainTime);
                                }

                                numCycle++;
                                Cyclelabel.Text = numCycle.ToString();

                                remainTime = workTime;

                                while (remainTime > 0)
                                {
                                    remainTime--;
                                    Thread.Sleep(1000);
                                    Timelabel.Text = Form1.getTimeString(remainTime);
                                }
                            }
                        }

                        remainTime = longRestTime;

                        while (remainTime > 0)
                        {
                            remainTime--;
                            Thread.Sleep(1000);
                            Timelabel.Text = Form1.getTimeString(remainTime);
                        }

                        numCycle++;
                        Cyclelabel.Text = numCycle.ToString();
                        remainTime = workTime;
                    }
                }
                else
                {
                }
            }

        }
    }
}
