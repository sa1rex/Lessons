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
         * Работа с массивами
        */

        static void Main(string[] args)
        {

            int[] myArray = { 2, 6, 242, 23, 231, 86, 2321, 32 };

            // int result1 = myArray.Min();         //          -        нахождение минимального элемента массива

            // int result2 = myArray.Max();         //          -        нахождение максимального элемента массива

            // int result3 = myArray.Sum();         //          -        нахождение суммы элементов массива

            // int result4 = myArray.Where( i => i % 2 == 0).Sum(); //-     нахождение суммы всех четных элементов массива

            // int result5 = myArray.Where( i => i % 2 == 0).Min(); //-     нахождение минимальный четный элемент массива

            // int[] result6 = myArray.Distinct().ToArray();        //-     копирование элементов с массива myArray в result6

            // int[] result7 = myArray.OrderBy(i => i).ToArray();   //-     копирование с сортировкой по возрастанию элементов с массива myArray в result7

            // int[] result8 = myArray.OrderByDescending(i => i).ToArray();   //-     копирование с сортировкой по убыванию элементов с массива myArray в result7

            // int result9 = Array.Sort(myArray); // - сортировка массива через вызов метода класса

            // int result10 = Array.Find(myArray, i => i < 70); // - поиск чисел в массиве через условие делегата и вызов метода класса


            Console.WriteLine();
        }
    }

}











