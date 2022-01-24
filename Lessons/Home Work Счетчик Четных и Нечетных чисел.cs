using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Program
    {

        /*
         * Цикл While
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Type first Value");
            int currentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Type second Value");
            int limit = int.Parse(Console.ReadLine());
            
            
            int even = 0;
            int odd = 0;

            int evenSum = 0;
            int oddSum = 0;

            while (currentCount <= limit)
                
            {
                if (currentCount % 2 == 0)
                {
                    even++;
                    evenSum = evenSum + currentCount;
                }

                else
                {
                    odd++;
                    oddSum = oddSum + currentCount;
                }


                currentCount++;

            }
            Console.WriteLine("count a even number " + even);
            Console.WriteLine("count a even odd number " + odd);
            Console.WriteLine("Sum a even number " + evenSum);
            Console.WriteLine("Sum a even odd number " + oddSum);
        }


    }

}

    


