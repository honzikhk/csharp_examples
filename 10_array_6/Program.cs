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
            List<int> my_list = new List<int> { 25, -56, -88, 5, 10, 65, 584, 12, -120, 169 };
            int count_of_even = 0;
            int count_of_odd = 0;

            foreach (int item in my_list)
            {
                if (item % 2 == 0)
                {
                    count_of_even += 1;
                }
                else
                {
                    count_of_odd += 1;
                }
            }
            Console.WriteLine($"Count of even numbers: {count_of_even}");
            Console.WriteLine($"Count of odd numbers: {count_of_odd}");
            Console.ReadLine();
        }
    }
}
