using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    /// <summary>
    /// 委托和类一样，用户自定义的类型
    /// </summary>
    public delegate void PublishEventHandle();

    /// <summary>
    /// 发布者 ——老师
    /// Publisher —— Teacher
    /// 文章讲的很好：
    /// http://www.tracefact.net/CSharp-Programming/Delegates-and-Events-in-CSharp.aspx
    /// </summary>
    public class DelegateEventTeacher
    {
        //声明事件,事件看作是受限制的委托，只能用+= -=赋值
        public event PublishEventHandle OnOrderEvent;

        public PublishEventHandle DelegateHandle;
        public bool PublishInfo()
        {
            FileStream file = new FileStream(@"D:\test.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);//实现对字符串的写入
            writer.WriteLine("开始考试：" + DateTime.Now.ToLongTimeString());
            writer.Close();
            return true;
        }
        //事件触发
        public bool Issue()
        {
            if (OnOrderEvent != null)
            {
                OnOrderEvent();
                return true;
            }
            return false;
        }

        public bool DelegateIssue()
        {
            if (DelegateHandle != null)
            {
                DelegateHandle();
                return true;
            }
            return false;
        }
    }
}
