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
        private readonly object locker = new object();
        int showTimes = 10;//线程间的共享数据时造成复杂度的主因
        public void ShowMessage()
        {
            Console.WriteLine("Async threadId is :{0}"+ Thread.CurrentThread.ManagedThreadId);
            for (int n = 0; n < 10; n++)
            {
                Thread.Sleep(500);
                Console.WriteLine("The number is:" + showTimes--);
                ;
            }


            //i指向同一内存地址，线程启动的顺序差异，线程调用时，i值会改变
            for (int i = 0; i < 10; i++)
            {
                new Thread(() => Console.Write(i)).Start();
            }



            for (int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread(() => Console.Write(temp)).Start();
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
                Thread.Sleep(500);//线程阻塞或者挂起时，不消息CPU资源
                Console.WriteLine("The number is:" + n.ToString());
                Console.WriteLine("time is:" + t);
                showTimes--;
            }
        }
        public bool Show()
        {
            Thread show = new Thread(ShowMessage);
            show.Priority = ThreadPriority.Normal;//线程优先级
            show.IsBackground = false;//
            show.Name = "SHOW";
            show.Start();
            show.Join();
            
            //show.Join();//等待异步线程结束
            return true;
        }
        public bool ShowParam()
        {
            Thread show = new Thread(ShowMessageParam);
            show.Start(DateTime.Now.ToString());
            Thread show2 = new Thread(ShowMessage);
            show2.Start();

            show.Join();//等待异步线程结束
            return true;
        }
    }
}
