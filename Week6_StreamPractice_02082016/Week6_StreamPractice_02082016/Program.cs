using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6_StreamPractice_02082016
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("test.txt");
            ////Read the file here...
            //string fileName = "C:\\Temp\\work\\test.txt";
            //string theSamefileName = @"C:\Temp\work\test.txt";  //@ symbol says treat text in quotes as literal
            //reader.Close();

            //Using File class
            File.WriteAllText("sample.txt", "Hello, this is some text I am writing.");
            string fileContents = File.ReadAllText("sample.txt");
            Console.WriteLine("Text has been written- here are the file contents- " + fileContents);
            string[] arrayOfInformation = new string[2];
            arrayOfInformation[0] = "Heres the first line of the array of information.";
            arrayOfInformation[1] = "Heres the second line of the array of information.";
            File.WriteAllLines("sample.txt", arrayOfInformation);
            fileContents = File.ReadAllText("sample.txt");
            Console.WriteLine("Two lines have been written - here are the file contents- " + fileContents);

            //StreamReader reader = new StreamReader("sample.txt"); //relative path, because we saved it with .exe file in bin\debug
            /*StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\sample2.txt"); //absolute path
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }

                Console.WriteLine();
                reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\sample2.txt"); //absolute path
                line = reader.ReadToEnd();
                Console.WriteLine(line);
            }*/

            //Sentence rearrange version 1
            /*StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\sentences.txt");  //absolute path
            using (reader)
            {
                string line1 = reader.ReadLine();
                string line2 = reader.ReadLine();
                string line3 = reader.ReadLine();

                string[] line1Array = line1.Split(',');
                string[] line2Array = line2.Split(',');
                string[] line3Array = line3.Split(',');

                string[] newLine1Array = { line1Array[0], line2Array[0], line3Array[0]};
                string[] newLine2Array = { line1Array[1], line2Array[1], line3Array[1]};
                string[] newLine3Array = { line1Array[2], line2Array[2], line3Array[2]};

                StringBuilder line = new StringBuilder();
                foreach (string word in newLine1Array)
                {
                    line.Append(word);
                    line.Append(" ");
                }
                string newLine1 = line.ToString();
                Console.WriteLine(newLine1);

                line.Clear();
                foreach (string word in newLine2Array)
                {
                    line.Append(word);
                    line.Append(" ");
                }
                string newLine2 = line.ToString();
                Console.WriteLine(newLine2);

                line.Clear();
                foreach (string word in newLine3Array)
                {
                    line.Append(word);
                    line.Append(" ");
                }
                string newLine3 = line.ToString();
                Console.WriteLine(newLine3);

            }*/

            //Sentence rearrange version 2, using loops
            /*StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\sentences.txt");  //absolute path
            using (reader)
            {
                string line = "";
                int index = 0;
                string[,] newLineArray = new string[3, 3];

                do
                {
                    string line = reader.ReadLine();
                    string[] lineArray = line.Split(',');
                    for (int i = 0; i < 3; i++)
                    {
                        newLineArray[index,i] = lineArray[i];
                    }
                    index++;
                    StringBuilder line = new StringBuilder();
                    foreach (string word in newLine1Array)
                    {
                        line.Append(word);
                        line.Append(" ");
                    }
                    string newLine1 = line.ToString();
                    Console.WriteLine(newLine1);

                    line.Clear();
                    foreach (string word in newLine2Array)
                    {
                        line.Append(word);
                        line.Append(" ");
                    }
                    string newLine2 = line.ToString();
                    Console.WriteLine(newLine2);

                    line.Clear();
                    foreach (string word in newLine3Array)
                    {
                        line.Append(word);
                        line.Append(" ");
                    }
                    string newLine3 = line.ToString();
                    Console.WriteLine(newLine3);

                } while (line != null);

            }*/


        }
    }
}
