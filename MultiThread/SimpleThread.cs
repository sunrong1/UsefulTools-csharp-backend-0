using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    public class SimpleThread
    {
        public void ShowMessage()
        {
            string message = string.Format("Async threadId is :{0}",
                                            Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);

            for (int n = 0; n < 10; n++)
            {
                Thread.Sleep(500);
                Console.WriteLine("The number is:" + n.ToString());
            }
        }
        public void ShowMessageParam(object time)
        {
            string message = string.Format("Async threadId is :{0}",
                                            Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);
            string t = time as string;
            for (int n = 0; n < 10; n++)
            {
                Thread.Sleep(500);
                Console.WriteLine("The number is:" + n.ToString());
                Console.WriteLine("time is:" + t);
            }
        }
        public bool Show()
        {
            Thread show = new Thread(ShowMessage);
            show.Start();
            show.Abort();
            //show.Join();//等待异步线程结束
            return true;
        }
        public bool ShowParam()
        {
            Thread show = new Thread(ShowMessageParam);
            show.Start(DateTime.Now.ToString());
            show.Join();//等待异步线程结束
            return true;
        }
    }
}
