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
         * 3 C# 101 Searching Strings
        */

        static void Main(string[] args)
        {

            // ДВУМЕРНЫЕ МАССИВЫ

            // Двумерный прямоугольный массив

            int[,] myArray;                         //      Объявляем название двумерного массива

            myArray = new int[3, 5]              //      Инициализируем массив, определяем место в памяти и присваиваем размерность и значения
            {
                {23,434,22,42,11},
                {7,86,34,97,12},
                {536,7,33,9,2344}
            };
                           

            myArray[0, 4] = 77;                     //      Присваиваем значение индекса в 1-й строке и 5-й колонке 
                                                          
            Console.WriteLine(myArray[0,4]);        //      Выводим значение индекса
            Console.WriteLine(myArray[2, 4]);       //      Выводим значение индекса
        }
    }

             
        
         
}          
           
           









