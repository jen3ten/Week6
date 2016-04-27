using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6_ListsPractice_02092016
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> birthYears = new List<int> { 1975, 2000, 1999, 1998, 1960, 1965, 1980, 1991, 2004, 1982 };
            int counter = 0;
            foreach (int year in birthYears)
            {
                counter++;
                Console.WriteLine("Student {0} was born in {1}", counter, year);
            }
            birthYears.Add(1955);
            birthYears.Add(1987);
            birthYears.Add(1992);
            birthYears.Add(1972);
            Console.WriteLine("Now the list has {0} elements.", birthYears.Count);

            List<string> studentNames = new List<string> { "Jacob", "Mary", "Jen", "Imari" };
            studentNames.Add("Cadale");
            studentNames.Add("Kim");
            studentNames.Add("Sirahn");
            studentNames.Add("Cameron");
            studentNames.Add("Krista");

            StreamWriter names = new StreamWriter("StudentNames02092016.txt");
            foreach (string student in studentNames)
            {
                names.WriteLine(student);
                Console.WriteLine(student);
            }
            names.Close();

            Console.WriteLine("There are {0} students.", studentNames.Count);
            //studentNames.Clear();
            //Console.WriteLine("I cleared the list. Now there are {0} students.", studentNames.Count);

            int[] numArray = { 23, 45, 34 };
            List<int> numList = new List<int>(numArray);
            Console.WriteLine("There are {0} elements in the number list.", numList.Count);

            List<int> numList2 = numArray.ToList();
            Console.WriteLine("There are {0} elements in the second number list.", numList2.Count);
             
            string[] strArray = { "me", "you", "it", "dog", "cat" };
            List<string> strList = new List<string>(strArray);
            Console.WriteLine("There are {0} elements in the string list.", strList.Count);

            int[] numArrayConverted = numList.ToArray();
            Console.WriteLine("There are {0} elements in the int array to list to array conversion.", numArrayConverted.Length);

            string[] strArrayConverted = strList.ToArray();
            Console.WriteLine("There are {0} elements in the string array to list to array conversion.", strArrayConverted.Length);

            //Practice these methods that can be used with lists
            //list.Add()  adds an element to the list
            //list.Clear() clears the list
            //list.Insert() inserts an element at a position you specify

            //list.Contains()

            //list.Remove() removes a specific item by name, but only the first one
            studentNames.Remove("Jen");
            Console.WriteLine("I just removed 'Jen' from student list.");

            //list.RemoveAt() removes an item by index
            studentNames.RemoveAt(0);
            Console.WriteLine("I just removed element 0 from student list.");

            //list.IndexOf() returns an integer value of the index of the element, or -1 if it doesn't exist
            int element = numList.IndexOf(23);
            Console.WriteLine("The index of 23 is {0}", element);
            element = numList.IndexOf(99);
            Console.WriteLine("The index of 99 is {0}", element);

            //list.Sort()
            studentNames.Sort();
            Console.WriteLine("The student names list has been sorted.");
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
 