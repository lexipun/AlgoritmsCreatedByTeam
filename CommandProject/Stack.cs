

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandProject
{
    
    class Stack<T>
        where T: class
    {
        List<T> list = new List<T>();
        public void Push(T element)
        {
            list.Add(element);
        }

        public T Pop()
        {
            if (list.Count() == 0)
                throw new Exception("The stack is empty");

            var popElement = list.Last();
            list.RemoveAt(list.Count - 1);
            return popElement;
        }




        public void PushRange(List<T> elements)
        {

            list.AddRange(elements);
        }
    }
}

