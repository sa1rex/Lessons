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
            int limit = int.Parse(Console.ReadLine());
            
            int count = 0;
            int even = 0;
            int odd = 0;

            while (count < limit)
                
             { 
                                      
                    count++;

                if (count % 2 == 0)

                {
                    even++;
                    Console.WriteLine(count + " is a even number " + even);
                }
                else
                {
                    odd++;
                    Console.WriteLine(count + " is a odd number " + odd);
                }
            }


        }


    }

}

    


