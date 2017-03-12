using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    /// <summary>
    /// Teacher's Subscriber
    /// </summary>
    public class DelegateJoy
    {
        public static void TestInfo()
        {
            FileStream file = new FileStream(@"D:\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);//实现对字符串的写入
            writer.WriteLine($"Joy start to Test：{DateTime.Now.ToLongTimeString()}");
            writer.Close();
        }
    }
}
