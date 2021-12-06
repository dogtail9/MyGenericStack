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
    }
}
