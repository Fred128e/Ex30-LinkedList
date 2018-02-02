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
                if (firstItem != null)
                { return firstItem.Item; }
                else { return null; }
            } }
        public object Last {
            get {
                if (lastItem != null)
                { return lastItem.Item; }
                else { return null; }
            } }
        public object Items(int index)
        {
            ListItem work = null;
            if (index < Count)
            {
                work = firstItem; ;
                for (int i = 0; i < index; i++)
                {
                    work = work.Next;
                }
            }
            object o = work as object;
            return o;
        }
        public void InsertFirst(object o)
        {

        }
        public void InsertLast(object o)
        {
            ListItem newLI = new ListItem(o);
            if (Count == 0)
            {
                firstItem = newLI;
                lastItem = newLI;
                itemCount++;
            } else
            {
                ListItem currentLast = lastItem;
                currentLast.Next = newLI;
                lastItem = newLI;
                itemCount++;
            }

        }
        public void RemoveAt(object o)
        {

        }
        public override string ToString()
        {
            string tostring = "";
            ListItem current = firstItem;
            for (int i = 0; i<Count; i++)
            {
                tostring += current.ToString();
                current = current.Next;
            }
            return tostring;
        }
    }
}
