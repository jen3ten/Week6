using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6_StreamReader_02092016
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"Answers2.txt";
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                Console.WriteLine("File {0} opened successfully.", fileName);
                using (writer)
                {
                    writer.WriteLine("some line");
                    //loop from 1 to 20 and write number to the line
                    for (int i = 1; i <= 20; i++)
                    {
                        writer.WriteLine(i);
                    }
                }
                //writer.Close();  //We used using(writer) instead of .Close() method 
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("Cannot file file {0}", fileName);
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch(IOException)
            {
                Console.Error.WriteLine("Cannot open the file {0}", fileName);
            }
        }
    }
}
