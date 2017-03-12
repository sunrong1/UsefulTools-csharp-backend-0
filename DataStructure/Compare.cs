using System;

namespace DataStructure
{
    //Compare<T>是泛型类，T为类型参数
    public class Compare<T> where T : IComparable
    {
        //使用泛型实现的比较方法
        public static int CompareGeneric(T t1, T t2)
        {
            if (t1.CompareTo(t2) > 0)
            {
                return 1;
            }
            else if (t1.CompareTo(t2) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
