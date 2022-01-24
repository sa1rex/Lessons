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



            /* 
             *
             * 
             int[] myArray = 
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

            /*

            int[] myArray = new int[5] { 11, 2, 77, 5, 7 }; // объяляем индексы массивы

          

            for (int i = myArray.Length - 1; i >= 0; i--)// задаём длину массиву и корректируем порядковое число
                                                         //выставляем условие и логику цикла


            {
                Console.WriteLine(myArray[i]); // выводим массив в обратном порядке на консоль
            }
            
             
            */




            // 3) найти сумму четных чисел в массиве

            /*
             
            int[] myArray =  Enumerable.Range(1, 10).ToArray(); // заполняем индексы массива числами с 1 по 10
            int oddsum = 0;
            Console.WriteLine("Array lenght = " + myArray.Length + "\n\n\n\n ");
            

            for (int i = 0; i < myArray.Length; i++) // внешний цикл перебора массива
            {
                Console.WriteLine(myArray[i]);

                if (myArray[i] % 2 == 0) // внутренний цикл проверки четноти индекса массива
                {

                }
                else
                {
                    oddsum = myArray[i] + oddsum; }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("sum of odd numbers = " + oddsum);
            

            */

            // 4) найти наименьшее число в массиве

             int[] myArray = { 24, 1, 435, 54, 6 }; // назначаем индексы значениями


            // Метод 1

            /*
               Array.Sort(myArray);        // Сортируем индексы
               Array.Reverse(myArray);     // Реверсируем сортировку

            foreach (int value in myArray) // инициализируем нетипизированные переменные индексам
             Console.WriteLine(value); 
             */

            // Метод 2

            int min = myArray[0];
                        

            for (int i = 1; i < myArray.Length; i++) // перебор всех елементов массива
            {
                if (myArray[i] < min)

                    min = myArray[i];
            }

            Console.WriteLine(min);


            // Модфицированные версии решений от преподавателя

            // 1m) заполнить массив с клавиатуры

            /*
             * 
             Console.WriteLine("Input Count Elements in this Array Data");
            int countArray = int.Parse(Console.ReadLine());
           

            int[] myArray = new int[countArray];

            Console.WriteLine("Input Array Value the Elements");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine( "Output Array Data");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

             */

        }
    }

}











