using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_LinkedList
{
    public class LinkedList
    {
        private class ListItem
        {
            public object Item { get; }
            public ListItem Next { get; set; }

            public ListItem(object o)
            {
                Item = o;
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
        public object First {
            get {
                if (firstItem == null)
                { return null; }
                else { return firstItem.Item; }
            } }
        public object Last {
            get {
                if (lastItem == null)
                { return null; }
                else { return lastItem.Item; }
            } }
        public object Items(int index)
        {
            object item = FindIndex(index).Item;
            return item;
        }
        public void InsertFirst(object o)
        {
            ListItem newLI = new ListItem(o);
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
        public void InsertLast(object o)
        {
            ListItem newLI = new ListItem(o);
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
            //if (index >= Count || index < 0)
            //{
            //    throw new ArgumentOutOfRangeException("Der findes ikke objekter på plads "+ index);
            //}
            //else
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
                    oneBeforeCurrent = null;
                }
                itemCount--;
            }
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
    }
}
