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
         * Домашнее заданиме
         * 
         *  1) заполнить массив с клавиатуры
            2) вывести массив в обратном порядке
            3) найти сумму четных чисел в массиве	
            4) найти наименьшее число в массиве
        */

        static void Main(string[] args)
        {

            // 1) заполнить массив с клавиатуры

            /* int[] myArray = 
                {
                int.Parse(Console.ReadLine()), // ввод ячеек массива  № 1
                int.Parse(Console.ReadLine()), // ввод ячеек массива  № 2
                int.Parse(Console.ReadLine()), // ввод ячеек массива  № 3
                int.Parse(Console.ReadLine())  // ввод ячеек массива  № 4
                };
            Console.Clear();
            Console.WriteLine("Type ENTER");

            Console.ReadLine();
            for (int i = 0; i < myArray.Length; i++) // цикл на вывод всего массива
            {
                Console.WriteLine(myArray[i]);
            }
            */

            // 2) вывести массив в обратном порядке

            int[] myArray = new int[5] { 11, 2, 77, 5, 7 };

            for (int i = 4; i < myArray.Length; i--)
            {
                Console.WriteLine(myArray[i]);
            }


        }
    }

}











