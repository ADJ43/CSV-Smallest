using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int retry = 1;

            while (retry > 0)
            {

                List<int> myList = new List<int>();
                Console.WriteLine("Please write a list of numbers comma separated");

                string input = Console.ReadLine();
                Console.WriteLine(input);
                var separetedInput = input.Split(',');
                Console.WriteLine(input);
                if (separetedInput.Length >= 5)
                {
                    retry = 0;
                    foreach (string s in separetedInput)
                    {
                        myList.Add(int.Parse(s));
                    }
                    myList.Sort();
                    Console.WriteLine($"{myList[0]}{myList[1]}{myList[2]}");
                }
                
            }
        }
    }
}
