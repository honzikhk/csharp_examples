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
            void Write_text(string my_text, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(my_text);
                }
            }
            Write_text("Hi!", 5);
            Console.ReadLine();
        }
    }
}
