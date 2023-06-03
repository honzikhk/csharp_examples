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
            List<int> my_list = new List<int> {25, -56, -88, 5, 10, 65, 584, 12, -120, 169 };
            int res = 0;

            for (int i = 0; i < my_list.Count; i += 2)
            {
                res += my_list[i];
            }
            Console.WriteLine(res);


            Console.ReadLine();

        }
    }
}