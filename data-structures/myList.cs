using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueList.List
{
    public class myList
    {
        protected object[] items;
        protected int start, end, len;
        public myList(int capacity)
        {
            items = new object[capacity];

            start = end = len = 0;
        }

        public bool isEmpty()
        {
            return len == 0;
        }
        public bool isFull()
        {
            return len >= items.Length;
        }
        public int size()
        {
            return len;
        }
        public void insert(object o)
        {
            if (len < items.Length)
            {
                items[start = (start + 1) % items.Length] = o;
                len++;
            }
        }
        public void insertEnd(object o)
        {
            if (len < items.Length)
            {
                items[end] = o;

                end = (end + items.Length - 1) % items.Length;

                len++;
            }
        }

        public object remove()
        {

            if (isEmpty())
                return null;

            len--;

            object o = items[start];

            items[start] = null;

            start = (start + items.Length - 1) % items.Length;

            return o;
        }
        public object removeEnd()
        {

            if (isEmpty())
                return null;

            len--;

            end = (end + 1) % items.Length;

            object o = items[end];

            items[end] = null;

            return o;
        }

        public object peek(int offset)
        {

            if (offset >= len)
                return null;
            return items[(end + offset + 1) % items.Length];
        }

        private bool search(object itemToSearch, out int position)
        {
            bool isFound = false;
            position = -1;

            for (int counter = 0; counter < items.Length; counter++)
            {
                if (items[counter] == itemToSearch)
                {
                    position = counter;
                    isFound = true;
                    break;
                }
            }

            return isFound;
        } 
    }
}
