using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    public class SimpleThreadPool
    {
        public bool RunThreadPool()
        {
            ThreadPool.SetMaxThreads(100,100);
            ThreadMessage("MainThread");
            ThreadPool.QueueUserWorkItem(new WaitCallback(AsyncCallback));
            Thread.Sleep(1000);
            return true;
        }

        void AsyncCallback(object state)
        {
            Thread.Sleep(200);
            ThreadMessage("AsyncCallback");
            Console.WriteLine("Async thread do work!");
        }
        //显示线程现状
        void ThreadMessage(string data)
        {
            string message = string.Format("{0}\n  CurrentThreadId is {1}",
                 data, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);
        }
    }
}
