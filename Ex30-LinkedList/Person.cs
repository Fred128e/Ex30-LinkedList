using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_LinkedList
{
    public enum Gender { Male, Female }

    public class Person : IComparable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public int CompareTo(object obj)
        {
            int result = 0;
            Person compareObj = obj as Person;
            if(this.FullName == compareObj.FullName)
            {
                result = 1;
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Id}: {FullName} ({Gender}), {Age} years";
        }
    }

}
