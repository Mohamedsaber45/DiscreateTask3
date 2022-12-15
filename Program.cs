using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_prime_number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            for (int num = 5; num <= 100; num++)
            {
                int count = 0;
                for (int p = 1; p < num; p++)
                {

                    if (num % p == 0)
                    {
                        count += 1;

                    }
                }
                if (count < 2)
                {
                    Console.WriteLine(num);

                }

            }
            Console.ReadKey();
        }
    }
}
