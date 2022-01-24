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
         * Инициализация массива
        */

        static void Main(string[] args)
        {

           
            // Метод инициализации массива № 1
            int[] my2Array;
            my2Array =  new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(my2Array[0]);

            // Метод инициализации массива № 2
            int[] my3Array = new int[5] {0, 1, 2, 3, 4};
            Console.WriteLine(my3Array[4]);

            // Метод инициализации массива № 3
            int[] my4Array = { 21, 32, 34, 45 };
            Console.WriteLine(my4Array[2]);

            // Метод инициализации массива № 4
            int[] my5Array = Enumerable.Range(2, 5).ToArray();
            Console.WriteLine(my5Array[2]);

            // Метод инициализации массива № 5
            int[] my6Array = Enumerable.Repeat(7, 10).ToArray();
            Console.WriteLine(my6Array[2]);
        }
    }

}











