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
         * Цикл Do While
         */

        static void Main(string[] args)
        {

            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            do
            {

                count++;
                Console.WriteLine(count);

            } while (count < limit);
            


            

        }


    }

}

    


