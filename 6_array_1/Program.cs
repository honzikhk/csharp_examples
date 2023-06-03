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
            // List<int> my_array_2 = new List<int>();       // last right way to create a list :)
            List<int> my_array = new List<int> {124, 56, 88, 0, 0, 65, 584, 0, 0, 6};
            int res = 0;

            foreach (int el in my_array)
            {
                if (el == 0) 
                { 
                    res += 1; 
                }

            }
            Console.WriteLine(res);




            Console.ReadLine();
        }
    }
}