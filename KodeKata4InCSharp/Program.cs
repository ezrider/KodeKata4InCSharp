using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KodeKata4InCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string startupPath = Environment.CurrentDirectory;
            Console.WriteLine("currennt directory {0}", startupPath);
            string text = System.IO.File.ReadAllText(@"C:\Users\Mike\Documents\Projects\KodeKata4InCSharp\Data\weather.dat");

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Mike\Documents\Projects\KodeKata4InCSharp\Data\weather.dat");
            List<string> newlines = new List<string>(lines);

            int count = 0;
            foreach (string line in lines)
            {
                if (lines[count].Length == 0)
                {
                    newlines.RemoveAt(count);
                    Console.WriteLine("line length is {0} and {1}", line.Length, lines[count].Length);
                    count++;
                }

                // try with linq

                //            goodlines = lines.Where((val,idx) => Length != 0).ToArray();

                // now we can work with our new lines to check the data integrity


                string[] line3words = Regex.Split(lines[2], @"\W+");
                foreach (string word in line3words)
                {
                    Console.WriteLine("{0}", word);
                }


                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
            }
        }
    }
}
