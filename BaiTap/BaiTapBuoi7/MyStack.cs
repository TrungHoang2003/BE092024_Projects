using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi7
{
    public class MyStack<T>
    {
        public List<T> list = new List<T>();

        public void Push(T item)
        {
            list.Add(item);
        }
        public bool IsEmpty()
        {
            return list.Count == 0;
        }
        public T Pop()
        {
            if (IsEmpty())
                Console.WriteLine("Danh sach cua ban rong");
            T top = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return top;
        }

        public T Peak()
        {
            if (IsEmpty())
                Console.WriteLine("Danh sach cua ban rong");
            return list[list.Count - 1];
        }
    }
}
