using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// Mark ALLEN Weiss || Structures and Algorithm Analysis in C
    /// 链表的相关实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListHead<T> where T : IComparable
    {
        private Node<T> head;

        public Node<T> Head
        {
            get
            {
                return head;
            }

            set
            {
                head = value;
            }
        }

        /// <summary>
        /// 表头 == 头结点
        /// </summary>
        public LinkedListHead()
        {
            head = new Node<T>();//创建带有头结点的空链表
        }


        public bool IsEmpty()
        {
            return head.Next == null;
        }
        public bool IsLast(Node<T> P, LinkedListHead<T> L)
        {
            if (P != null)
            {
                return P.Next == null;
            }
            return false;
        }

        public int Length()
        {
            int num = 0;
            if (head.Next == null)
            {
                return 0;
            }
            Node<T> p = head.Next;

            while (p != null)
            {
                p = p.Next;
                num++;
            }
            return num;
        }

        /// <summary>
        /// 查找方法
        /// </summary>
        /// <param name="findData"></param>
        /// <returns></returns>
        public Node<T> Find(T findData)
        {
            if (head.Next == null)
            {
                return null;
            }
            Node<T> P = head.Next;
            while (P != null && findData.CompareTo(P.Data) != 0)
            {
                P = P.Next;
            }
            return P;
        }

        /// <summary>
        /// 添加方法
        /// </summary>
        /// <param name="item"></param>
        public void Append(T item)
        {
            //[item][null]
            Node<T> addNode = new Node<T>(item);
            if (head == null)
            {
                return;
            }
            //临时变量p
            Node<T> p = new Node<T>();
            p = head;

            while (p.Next != null)
            {
                p = p.Next;
            }

            p.Next = addNode;
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        public void DeleteList()
        {
            head.Next = null;
        }

        /// <summary>
        /// 删除第一次出现的数据
        /// </summary>
        /// <param name="delData">删除的数据</param>
        /// <returns></returns>
        public bool Delete(T delData)
        {
            if (head.Next == null)
            {
                return false;
            }
            Node<T> p = new Node<T>();
            Node<T> pBefore = new Node<T>();
            p = head.Next;
            pBefore = head;
            while (p != null)
            {
                if (delData.CompareTo(p.Data) == 0)
                {
                    if (p.Next == null) //最后一个结点
                    {
                        p = null;
                        return true;
                    }
                    else
                    {
                        pBefore.Next = p.Next;
                        return true;
                    }
                }
                pBefore = p;
                p = p.Next;
            }
            return false;
        }



    }
}
