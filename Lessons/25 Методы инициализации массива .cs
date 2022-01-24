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
         * Вывод массива
        */

        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 8, 12, 48 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
            
        }
    }

}











