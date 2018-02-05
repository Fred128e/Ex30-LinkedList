﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_LinkedList
{
    public class LinkedList<T>
    {
        private class ListItem
        {
            public T Item { get; }
            public ListItem Next { get; set; }

            public ListItem(T t)
            {
                Item = t;
                Next = null;
            }
            public override string ToString()
            {
                return Item.ToString();
            }
        }
        
        private ListItem lastItem = null;
        private ListItem firstItem = null;
        private int itemCount = 0;
        public int Count { get { return itemCount; } }
        public T First {
            get {
                T result = default(T);
                if (itemCount > 0)
                { result = firstItem.Item; }
                return result;
            } }
        public T Last {
            get
            {
                T result = default(T);
                if (itemCount > 0)
                { result = lastItem.Item; }
                return result;
            } }
        public object Items(int index)
        {
            object item = FindIndex(index).Item;
            return item;
        }
        private ListItem FindIndex(int index)
        {
            ListItem item = null;
            if (index < Count)
            {
                ListItem work = firstItem;
                if (index == 0)
                {
                    item = work;
                }
                else if (index > 0 && index != Count - 1)
                {
                    for (int i = 0; i <= index; i++)
                    {
                        item = work;
                        work = work.Next;
                    }
                }
                else
                {
                    item = lastItem;
                }
            }
            return item;
        }
        public void InsertFirst(T t)
        {
            ListItem newLI = new ListItem(t);
            if (Count == 0)
            {
                firstItem = newLI;
                lastItem = newLI;
                itemCount++;
            }
            else
            {
                ListItem currentFirst = firstItem;
                newLI.Next = currentFirst;
                firstItem = newLI;
                itemCount++;
            }
        }
        public void InsertLast(T t)
        {
            ListItem newLI = new ListItem(t);
            if (Count == 0)
            {
                firstItem = newLI;
                lastItem = newLI;
            }
            else
            {
                ListItem current = lastItem;
                current.Next = newLI;
                lastItem = newLI;
            }
            itemCount++;
        }
        public void RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Der findes ikke objekter på plads " + index);
            }
            else
            { 
                if (Count == 1)
                {
                    firstItem = null;
                    firstItem.Next = null;
                    lastItem = null;
                }
                if (Count >1 && index == 0)
                {
                    firstItem = FindIndex(1);
                }
                if (Count >1 && index >0 && index < Count-1)
                {
                    ListItem current = FindIndex(index);
                    ListItem oneBeforeCurrent = FindIndex(index - 1);
                    oneBeforeCurrent.Next = current.Next;
                }
                if (index == Count-1)
                {
                    ListItem oneBeforeCurrent = FindIndex(index - 1);
                    oneBeforeCurrent.Next = null;
                    lastItem = oneBeforeCurrent;
                }
                itemCount--;
            }
        }
        public override string ToString()
        {
            string tostring = "";
            ListItem current = firstItem;
            for (int i = 0; i<Count; i++)
            {
                tostring += current.ToString();
                current = current.Next;
                if (i != Count - 1)
                {
                    tostring += "|";
                }
            }
            return tostring;
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
