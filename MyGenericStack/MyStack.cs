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
            T item = Peek();
            _list.Remove(item);

            return item;
        }

        public T Peek()
        {
            if (_list.Count < 1)
                throw new InvalidOperationException("Stack empty.");

            int index = _list.Count - 1;
            T item = _list[index];

            return item;
        }
    }
}
