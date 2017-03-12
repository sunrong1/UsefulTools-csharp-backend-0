using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    /// <summary>
    /// 订阅者——小明
    /// Subscriber ---XiaoMing
    /// </summary>
    public class DelegateXiaoMing
    {
        public static void TestInfo()
        {
            FileStream file = new FileStream(@"D:\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);//实现对字符串的写入
            writer.WriteLine("小明开始考试：" + DateTime.Now.ToLongTimeString());
            writer.Close();
        }
    }
}
