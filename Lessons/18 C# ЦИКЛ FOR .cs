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
         * Цикл For Особенности
         * несколько переменных
         * цикл for в обратном порядке
         * несколько условий
         */

        static void Main(string[] args)
        {
            

            for (int i = 0, j = 10 ; i <= 10 && j >= 1; i++, j--)
            {
                Console.WriteLine(" Cycle i " +i);
                Console.WriteLine(" Cycle J " + j);
            }
        }


    }

}

    


