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

            int count_of_pozitive = 0;
            int count_of_negative = 0;

            foreach (int item in my_list)
            {
                if (item > 0)
                {
                    count_of_pozitive += 1;
                }
                else if (item < 0)
                {
                    count_of_negative += 1;
                }
            }
            Console.WriteLine($"Count of pozitive numbers: {count_of_pozitive}");
            Console.WriteLine($"Count of negative numbers: {count_of_negative}");
            Console.ReadLine();
        }
    }
}
