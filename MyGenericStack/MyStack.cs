using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericStack
{
    public class MyStack<T>
    {
        List<T> _list = new List<T>();

        public int Count 
        { 
            get 
            {
                return _list.Count;
            }
        }

        public void Push(T item)
        {
            _list.Add(item);
        }

        public T Pop()
        {
            int index = _list.Count - 1;
            T item = _list[index];
            _list.RemoveAt(index);

            return item;
        }

        public T Peek()
        {
            int index = _list.Count - 1;
            T item = _list[index];

            return item;
        }
    }
}
