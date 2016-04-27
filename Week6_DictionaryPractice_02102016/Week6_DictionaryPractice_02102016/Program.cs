using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_DictionaryPractice_02102016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good method to add entries later
            //Dictionary<string, int> people = new Dictionary<string, int>();
            //people.Add("John", 34);     //Add() method has semicolon at end
            //people.Add("Mary", 23);
            //people.Add("Joe", 56);
            //people.Add("Amy", 72);
            //string firstName = "John";
            //Console.WriteLine(people[firstName]);

            ////Good method if you want to enter information when you initialize
            //Dictionary<string, int> zoo = new Dictionary<string, int>() //no semicolon here
            //{
            //    {"Lions",7},    //entries separated by commas
            //    {"Bears",5},
            //    {"Seals",3},
            //    {"Flamingos",24}
            //};  //semicolon at end of curly braces

            //if(zoo.ContainsKey("Lions"))
            //{
            //    int value = zoo["Lions"];
            //    Console.WriteLine(value);
            //}

            //int value2;
            //if(zoo.TryGetValue("Wolves", out value2))
            //{
            //    Console.WriteLine(value2);
            //}
            //else
            //{
            //    Console.WriteLine("This animal is not in the dictionary.");
            //}

            //Console.WriteLine();

            Dictionary<string, string> nameAge = new Dictionary<string, string>();
            do
            {
                Console.Write("Please enter a name (or <enter> to end): ");
                string name = Console.ReadLine();
                if (name == "")
                    break;
                Console.Write("Please enter {0}'s age (or <enter> to end): ", name);
                string age = Console.ReadLine();
                if (age == "")
                    break;
                nameAge.Add(name, age);
            } while (true);

            string ageValue;
            Console.Write("Please enter a name and I will look it up: ");
            string nameKey = Console.ReadLine();
            if (nameAge.TryGetValue(nameKey,out ageValue))
            {
                Console.WriteLine("I found {0}, who is {1} years old.", nameKey, ageValue);
            }
            else
            {
                Console.WriteLine("The name does not exist.");
            }

            foreach(KeyValuePair<string, string> pair in nameAge)
            {
                Console.WriteLine("Name: {0}\tAge: {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();

            foreach(string key in nameAge.Keys)
            {
                Console.WriteLine("Name: {0}", key);
            }
            Console.WriteLine();

            foreach(string value in nameAge.Values)
            {
                Console.WriteLine("Age: {0}", value);
            }

        }
    }
}
