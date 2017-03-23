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
                Thread.Sleep(300);
                Console.WriteLine("The number is:" + n.ToString());
            }
        }
        public bool Show()
        {
            Thread show = new Thread(ShowMessage);
            show.Start();
            Thread.Sleep(2000);
            return true;
        }
    }
}
