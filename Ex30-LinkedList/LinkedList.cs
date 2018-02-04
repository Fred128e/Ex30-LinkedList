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
            object item = null;
            if (index < Count)
            {
                ListItem work = firstItem; ;
                for (int i = 0; i <= index; i++)
                {
                    item = work.Item;
                    work = work.Next;
                }
            }
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
            if (index > Count || index < 0) { throw new ArgumentOutOfRangeException("Der findes ikke objekter på plads "+ index); }
            if (index < Count)
            {
                if (index == 0 && Count == 1)
                {
                    firstItem = null;
                    firstItem.Next = null;

                }
                if (Count > 0 && index > 0 && index < Count - 1)
                {
                    ListItem workItem = null;

                    ListItem itemBeforeIndex = firstItem;
                    ListItem itemOnIndex = firstItem;
                    for (int i = 0; i <= index; i++)
                    {
                        workItem = itemOnIndex;
                        itemOnIndex = itemOnIndex.Next;
                    }
                    for (int i = 0; i < index; i++)
                    {
                        itemBeforeIndex = itemBeforeIndex.Next;
                    }
                    itemBeforeIndex.Next = workItem.Next;

                }
                if (index == Count-1 && index != 0)
                {
                    ListItem secondToLastItem = firstItem;
                    ListItem toBecomeLastItem = null;
                    for (int i = 0; i < Count-2; i++)
                    {
                        toBecomeLastItem = secondToLastItem.Next;
                        secondToLastItem = secondToLastItem.Next;
                    }
                    lastItem = toBecomeLastItem;
                    lastItem.Next = null;
                    
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
            }
            return tostring;
        }
    }
}
