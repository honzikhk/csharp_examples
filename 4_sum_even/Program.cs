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
            List<int> numbers = new List<int>();
            Console.WriteLine("How many numbers do you want add? ");
            int count_of_numbers = Convert.ToInt16(Console.ReadLine());
            int counter = 0;        // why i cannot use i in for loop?

            for (int i = 0; i < count_of_numbers; i++)

            {
                Console.WriteLine("write {0}. number to add: ", counter + 1);
                int user_input = Convert.ToInt16(Console.ReadLine());

                if (user_input % 2 != 0 && user_input > 10)
                {

                    numbers.Add(user_input);
                }
                // Do i have to always use "else"?
                counter++;
            }
            Console.WriteLine(string.Join("; ", numbers));
            Console.WriteLine("Sum of your even numbers greather then 10 is: {0}.", numbers.Sum());




            Console.ReadLine();
        }
    }
}