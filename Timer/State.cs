using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Timer
{
    #region Class State
    class State
    {
        #region Member Variable
        private int _TimeState;
        public int TimeState
        {
            get { return _TimeState; }
            set { _TimeState = value; }
        }

        private int _Time;
        public int Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        private int _RemainTime;
        public int RemainTime
        {
            get { return _RemainTime; }
            set { _RemainTime = value; }
        }

        private int _Count;
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        private Label Timelabel;
        #endregion


        public State(int TimeState, int Time, int RemainTime, int Count, Label t)
        {
            this.TimeState = TimeState;
            this.Time = Time;
            this.RemainTime = RemainTime;
            this.Count = Count;

            this.Timelabel = t;
        }

        public void Run()
        {
            while (this.Time > 0)
            {
                Thread.Sleep(1000);
                this.Time--;
                Timelabel.Text = Form1.getTimeString(RemainTime);
            }
        }


    }
    #endregion
}
