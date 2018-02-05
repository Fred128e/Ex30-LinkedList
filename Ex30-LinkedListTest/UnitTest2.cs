using System;
using System.Text;
//using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex30_LinkedList;

namespace Ex30_LinkedListTest
{
    [TestClass]
    public class UnitTest2
    {
        // Instantiating 25 test persons
        Person p1 = new Person { Id = 1, FirstName = "Farrand", LastName = "Semkins", Gender = Gender.Female, Age = 77 };
        Person p2 = new Person { Id = 2, FirstName = "Trev", LastName = "Quail", Gender = Gender.Male, Age = 84 };
        Person p3 = new Person { Id = 3, FirstName = "Dani", LastName = "Ballister", Gender = Gender.Female, Age = 76 };
        Person p4 = new Person { Id = 4, FirstName = "Hyacinthie", LastName = "Mish", Gender = Gender.Female, Age = 70 };
        Person p5 = new Person { Id = 5, FirstName = "Jarib", LastName = "Boustred", Gender = Gender.Male, Age = 32 };
        Person p6 = new Person { Id = 6, FirstName = "Erl", LastName = "Meeson", Gender = Gender.Male, Age = 62 };
        Person p7 = new Person { Id = 7, FirstName = "Aile", LastName = "Highman", Gender = Gender.Female, Age = 79 };
        Person p8 = new Person { Id = 8, FirstName = "Rheta", LastName = "Battelle", Gender = Gender.Female, Age = 42 };
        Person p9 = new Person { Id = 9, FirstName = "Olimpia", LastName = "Foulsham", Gender = Gender.Female, Age = 60 };
        Person p10 = new Person { Id = 10, FirstName = "Dagny", LastName = "Ilchenko", Gender = Gender.Male, Age = 34 };
        Person p11 = new Person { Id = 11, FirstName = "Davis", LastName = "Gilbride", Gender = Gender.Male, Age = 46 };
        Person p12 = new Person { Id = 12, FirstName = "Kamillah", LastName = "Bahls", Gender = Gender.Female, Age = 24 };
        Person p13 = new Person { Id = 13, FirstName = "Flore", LastName = "Ansley", Gender = Gender.Female, Age = 89 };
        Person p14 = new Person { Id = 14, FirstName = "Glad", LastName = "Clowser", Gender = Gender.Female, Age = 48 };
        Person p15 = new Person { Id = 15, FirstName = "Christian", LastName = "Congram", Gender = Gender.Female, Age = 33 };
        Person p16 = new Person { Id = 16, FirstName = "Tore", LastName = "Saggs", Gender = Gender.Male, Age = 28 };
        Person p17 = new Person { Id = 17, FirstName = "Vevay", LastName = "Klezmski", Gender = Gender.Female, Age = 43 };
        Person p18 = new Person { Id = 18, FirstName = "Bren", LastName = "Merrikin", Gender = Gender.Female, Age = 46 };
        Person p19 = new Person { Id = 19, FirstName = "Benoit", LastName = "Filler", Gender = Gender.Male, Age = 16 };
        Person p20 = new Person { Id = 20, FirstName = "Lucien", LastName = "Bottrell", Gender = Gender.Male, Age = 41 };
        Person p21 = new Person { Id = 21, FirstName = "Emmy", LastName = "Pechell", Gender = Gender.Male, Age = 61 };
        Person p22 = new Person { Id = 22, FirstName = "Merle", LastName = "Bennet", Gender = Gender.Female, Age = 42 };
        Person p23 = new Person { Id = 23, FirstName = "Solomon", LastName = "Sarrell", Gender = Gender.Male, Age = 61 };
        Person p24 = new Person { Id = 24, FirstName = "Shurlock", LastName = "Shreenan", Gender = Gender.Male, Age = 84 };
        Person p25 = new Person { Id = 25, FirstName = "Chadd", LastName = "Hanney", Gender = Gender.Male, Age = 80 };

        [TestInitialize]
        public void Initialize()
        {
        }
        [TestMethod]
        public void TestGenericDividedElementTypes()
        {
            // ** int list test *********
            LinkedList<int> listInt = new LinkedList<int>();

            // Test for empty int list
            //Assert.AreEqual(null, listInt.First);
            //Assert.AreEqual(null, listInt.Last);
            Assert.AreEqual(0, listInt.Count);

            // Insert ints and test
            listInt.InsertLast(105);
            listInt.InsertLast(45);
            listInt.InsertLast(11);
            listInt.InsertLast(3);

            Assert.AreEqual(105, listInt.First);
            Assert.AreEqual(3, listInt.Last);
            Assert.AreEqual(4, listInt.Count);
            Assert.AreEqual(105, listInt.Items(0));
            Assert.AreEqual(45, listInt.Items(1));
            Assert.AreEqual(11, listInt.Items(2));
            Assert.AreEqual(3, listInt.Items(3));

            // Sort int list and test
            listInt.Sort();
            Assert.AreEqual(3, listInt.Items(0));
            Assert.AreEqual(11, listInt.Items(1));
            Assert.AreEqual(45, listInt.Items(2));
            Assert.AreEqual(105, listInt.Items(3));

            // ** string list test **********
            LinkedList<string> listString = new LinkedList<string>();

            // Insert strings and test
            listString.InsertLast("Hello World!");
            listString.InsertLast("This is a ");
            listString.InsertLast("test of ");
            listString.InsertLast("LinkedList<string>");

            Assert.AreEqual("Hello World!", listString.First);
            Assert.AreEqual("LinkedList<string>", listString.Last);
            Assert.AreEqual(4, listString.Count);
            Assert.AreEqual("Hello World!", listString.Items(0));
            Assert.AreEqual("This is a ", listString.Items(1));
            Assert.AreEqual("test of ", listString.Items(2));
            Assert.AreEqual("LinkedList<string>", listString.Items(3));

            // Sort string list and test
            //listString.Sort();
            //Assert.AreEqual("Hello World!", listString.Items(0));
            //Assert.AreEqual("LinkedList<string>", listString.Items(1));
            //Assert.AreEqual("test of ", listString.Items(2));
            //Assert.AreEqual("This is a ", listString.Items(3));

            // ** decimal list test ***********
            LinkedList<decimal> listDecimal = new LinkedList<decimal>();

            // Insert decimals and test
            listDecimal.InsertLast(3.1415m); // Pi
            listDecimal.InsertLast(1.4142m); // square root of 2
            listDecimal.InsertLast(2.7182m); // e (Euler)
            listDecimal.InsertLast(1.6180m); // Golden ratio

            Assert.AreEqual(3.1415m, listDecimal.First);
            Assert.AreEqual(1.6180m, listDecimal.Last);
            Assert.AreEqual(4, listDecimal.Count);
            Assert.AreEqual(3.1415m, listDecimal.Items(0));
            Assert.AreEqual(1.4142m, listDecimal.Items(1));
            Assert.AreEqual(2.7182m, listDecimal.Items(2));
            Assert.AreEqual(1.6180m, listDecimal.Items(3));

            // Sort decimal list and test
            //listDecimal.Sort();
            //Assert.AreEqual(1.4142m, listDecimal.Items(0));
            //Assert.AreEqual(1.6180m, listDecimal.Items(1));
            //Assert.AreEqual(2.7182m, listDecimal.Items(2));
            //Assert.AreEqual(3.1415m, listDecimal.Items(3));
        }
        [TestMethod]
        public void TestGenericEmptyLinkedList()
        {
            LinkedList<Person> list = new LinkedList<Person>();

            Assert.AreEqual(null, list.First);
            Assert.AreEqual(null, list.Last);
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestGenericInsertLast()
        {
            LinkedList<Person> list = new LinkedList<Person>();
            list.InsertLast(p1);  // p1
            list.InsertLast(p7);  // p1,p7
            list.InsertLast(p13); // p1,p7,p13

            Assert.AreEqual(p1, list.First);
            Assert.AreEqual(p13, list.Last);
            Assert.AreEqual(3, list.Count);

            Assert.AreEqual(p1, list.Items(0));
            Assert.AreEqual(p7, list.Items(1));
            Assert.AreEqual(p13, list.Items(2));
        }
        [TestMethod]
        public void TestGenericInsertFirst()
        {
            LinkedList<Person> list = new LinkedList<Person>();
            list.InsertFirst(p5);  // p5
            list.InsertFirst(p21); // p21,p5
            list.InsertFirst(p9);  // p9,p21,p5
            list.InsertFirst(p24); // p24,p9,p21,p5

            Assert.AreEqual(p24, list.First);
            Assert.AreEqual(p5, list.Last);
            Assert.AreEqual(4, list.Count);

            Assert.AreEqual(p24, list.Items(0));
            Assert.AreEqual(p9, list.Items(1));
            Assert.AreEqual(p21, list.Items(2));
            Assert.AreEqual(p5, list.Items(3));
        }
        [TestMethod]
        public void TestGenericMixedInserts()
        {
            LinkedList<Person> list = new LinkedList<Person>();
            list.InsertFirst(p3); // p3
            list.InsertLast(p22); // p3,p22
            list.InsertFirst(p9); // p9,p3,p22
            list.InsertFirst(p1); // p1,p9,p3,p22
            list.InsertLast(p24); // p1,p9,p3,p22,p24
            list.InsertFirst(p5); // p5,p1,p9,p3,p22,p24
            list.InsertLast(p16); // p5,p1,p9,p3,p22,p24,p16

            Assert.AreEqual(p5, list.First);
            Assert.AreEqual(p16, list.Last);
            Assert.AreEqual(7, list.Count);

            Assert.AreEqual(p5, list.Items(0));
            Assert.AreEqual(p1, list.Items(1));
            Assert.AreEqual(p9, list.Items(2));
            Assert.AreEqual(p3, list.Items(3));
            Assert.AreEqual(p22, list.Items(4));
            Assert.AreEqual(p24, list.Items(5));
            Assert.AreEqual(p16, list.Items(6));
        }
        [TestMethod]
        public void TestGenericRemoves()
        {
            LinkedList<Person> list = new LinkedList<Person>();
            list.InsertFirst(p5);  // p5
            list.InsertFirst(p21); // p21,p5
            list.InsertFirst(p9);  // p9,p21,p5
            list.InsertFirst(p24); // p24,p9,p21,p5
            list.RemoveAt(2);      // p24,p9,p5

            Assert.AreEqual(p24, list.First);
            Assert.AreEqual(p5, list.Last);
            Assert.AreEqual(3, list.Count);

            Assert.AreEqual(p24, list.Items(0));
            Assert.AreEqual(p9, list.Items(1));
            Assert.AreEqual(p5, list.Items(2));
        }
        [TestMethod]
        public void TestGenericMixedInsertsAndRemoves()
        {
            LinkedList<Person> list = new LinkedList<Person>();
            list.InsertFirst(p3); // p3
            list.InsertLast(p22); // p3,p22
            list.InsertFirst(p9); // p9,p3,p22
            list.RemoveAt(0);     // p3,p22
            list.InsertFirst(p1); // p1,p3,p22
            list.InsertLast(p24); // p1,p3,p22,p24
            list.InsertFirst(p5); // p5,p1,p3,p22,p24
            list.RemoveAt(4);     // p5,p1,p3,p22
            list.InsertLast(p16); // p5,p1,p3,p22,p16
            list.RemoveAt(2);     // p5,p1,p22,p16

            Assert.AreEqual(p5, list.First);
            Assert.AreEqual(p16, list.Last);
            Assert.AreEqual(4, list.Count);

            Assert.AreEqual(p5, list.Items(0));
            Assert.AreEqual(p1, list.Items(1));
            Assert.AreEqual(p22, list.Items(2));
            Assert.AreEqual(p16, list.Items(3));
            Assert.AreEqual("5: Jarib Boustred (Male), 32 years|1: Farrand Semkins (Female), 77 years|22: Merle Bennet (Female), 42 years|16: Tore Saggs (Male), 28 years", list.ToString());
        }

        //[TestMethod]
        //public void TestGenericMixedElementTypes()
        //{
        //    LinkedList<Person> list = new LinkedList<Person>();
        //    list.InsertLast(3);
        //    list.InsertLast("Hello World");
        //    list.InsertLast(p5);
        //    list.InsertLast(0.256);

        //    Assert.AreEqual(3, list.First);
        //    Assert.AreEqual(0.256, list.Last);
        //    Assert.AreEqual(4, list.Count);

        //    Assert.AreEqual(3, list.Items(0));
        //    Assert.AreEqual("Hello World", list.Items(1));
        //    Assert.AreEqual(p5, list.Items(2));
        //    Assert.AreEqual(0.256, list.Items(3));
        //}
    }
}
