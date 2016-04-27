using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_DictionaryPractice2_02102016
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> bookLookUp = new Dictionary<int, string>();

            do
            {
                Console.Write("Enter the book ID and title, separated by a comma: ");
                string input = Console.ReadLine();
                if (input == "")
                    break;
                string[] inputArray = input.Split(',');
                int ID = int.Parse(inputArray[0]);
                string title = inputArray[1].Trim();
                bookLookUp.Add(ID, title);
            } while (true);

            Console.WriteLine();
            Console.WriteLine("The book IDs:");
            foreach(int key in bookLookUp.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            Console.WriteLine("The book titles:");
            foreach (string value in bookLookUp.Values)
            {
                Console.WriteLine(value);
            }

        }
    }
}
