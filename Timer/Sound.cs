using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Timer
{
    static class Sound
    {
        private static void doe()
        {
            Console.Beep(256 * 2, 250); // 도
        }

        private static void me()
        {
            Console.Beep(320 * 2, 250); // 미
        }
        private static void sol()
        {
            Console.Beep(384 * 2, 250); // 레
        }
        private static void Doe()
        {
            Console.Beep(256 * 4, 250); // 도
        }

        public static void Beep()
        {
            List<Thread> ListThread = new List<Thread>();
            Mutex mut = new Mutex();

            ListThread.Add(new Thread(doe));
            ListThread.Add(new Thread(me));
            ListThread.Add(new Thread(sol));
            ListThread.Add(new Thread(Doe));

            foreach (Thread thd in ListThread)
            {
                mut.WaitOne();
                Thread.Sleep(20);
                thd.Start();
                Thread.Sleep(20);
                mut.ReleaseMutex();
            }
            ListThread.Clear();
        }
    }
}
