using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class TimeKeeper
    {
        int second;
        Thread timeKeeperThread;
        private bool _timeOut;

        public bool TimeOut { get => _timeOut; }
        public TimeKeeper(int _second)
        {
            second = _second;
            _timeOut = false;
        }
        public void Start()
        {
            timeKeeperThread = new Thread(SecondSleep);

        }
        public void SecondSleep()
        {
            for (int i = 0; i < second; i++)
            {
                Thread.Sleep(1000);
            }
            _timeOut = true;
        }

        public void Stop()
        {
            if (timeKeeperThread.IsAlive)
            {
                timeKeeperThread.Abort();
            }
        }
    }
}
