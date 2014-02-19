using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueList.Queue
{
    public class myQueue
    {
        protected object[] items;
        protected int start, end;
        public myQueue(int capacity)
        {
            items = new object[capacity + 1];
            start = end = 0;
        }
        public bool isEmpty()
        {
            return start == end;
        }
        public void push(object o)
        {
            int n = (start + 1) % items.Length;
            if (n != end)
                items[start = n] = o;
        }
        public object pop()
        {
            if (isEmpty())
                return null;

            end = (end + 1) % items.Length;

            object o = items[end];

            items[end] = null;

            return o;
        }
    }
}
