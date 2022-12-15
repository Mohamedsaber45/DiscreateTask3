using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_perfect_number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter v");
            long v = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter num");
            for (int num = int.Parse(Console.ReadLine()); num <= v; num++)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {

                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == num)
                {
                    Console.WriteLine(num);
                }

            }
            Console.ReadKey();
        }
    }
}
