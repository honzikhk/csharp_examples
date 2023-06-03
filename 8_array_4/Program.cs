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
            
            Console.WriteLine("Max value of the list: {0}", my_list.Max());
            Console.WriteLine("Min value of the list: {0}", my_list.Min());
            Console.WriteLine($"Max value of the list: {my_list.Max()}");
            Console.WriteLine($"Min value of the list: {my_list.Min()}");

            int max_value = my_list[0];
            int min_value = my_list[0];


            foreach (var item in my_list)
            {
                if (item > max_value)
                {
                    max_value = item;
                }
                if (item < min_value)
                {
                    min_value = item;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Max value by foreach: {max_value}.");
            Console.WriteLine($"Min value by foreach: {min_value}.");

            Console.ReadLine();
        }
    }
}
