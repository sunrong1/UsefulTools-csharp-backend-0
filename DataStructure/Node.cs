namespace DataStructure
{
    /// <summary>
    /// 链表，head --> A ---->B--->null
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        public T Data
        {
            get => data;
            set => data = value;
        }

        public Node<T> Next
        {
            get => next;
            set => next = value;
        }

        //构造函数
        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }

        public Node(T val)
        {
            data = val;
            next = null;
        }

        public Node()
        {
            data = default(T);//获取T的默认值，引用类型null,值类型0
            next = null;
        }
    }
}
