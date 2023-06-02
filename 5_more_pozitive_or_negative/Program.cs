using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calc
    {
        static void Main(string[] args)
        {
            List<int> pozitive = new List<int>(0);
            List<int> negative = new List<int>(0);
            int end = 1;
            Console.WriteLine("For exit put 0");


            while (end != 0)
            {
                Console.WriteLine("Write a number: ");
                int user_input = Convert.ToInt32(Console.ReadLine());

                if (user_input > 0)
                {
                    pozitive.Add(user_input);
                }
                else if (user_input < 0)
                {
                    negative.Add(user_input);
                }
                else if (user_input == 0)
                {
                    end = 0;        // or break?
                }
                if (pozitive.Count > negative.Count)
                {
                    Console.WriteLine("Count of pozitive numbers is greater.");
                }
                if (pozitive.Count < negative.Count)
                {
                    Console.WriteLine("Count of negative numbers is greater.");
                }
                if (pozitive.Count == negative.Count)
                {
                    Console.WriteLine("Count of pozitive and negative numbers is equal.");
                }
            }




            Console.ReadLine();
        }
    }
}