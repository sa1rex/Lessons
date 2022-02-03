using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1.ВЫВОД_ДВУМЕРНОГО_МАССИВА
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] myArray;                         //      Объявляем название двумерного массива

            myArray = new int[2, 3];



            // Заполнение рандомными числами

            /* 
              Random random = new Random();           //      Создаем переменную случайных чисел
             for (int i = 0; i < myArray.GetLength(0); i++)
             {
                 Console.WriteLine();

                 for (int j = 0; j < myArray.GetLength(1); j++)
                 {
                     myArray[i, j] =  random.Next(1000);  // с помощью вложенного цикла перебираем каждый элемент массива и заполняем его рандомным числом
                 }
             }
             */

            // Заполенение массива с клавиатуры

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine(" Type elements please ");

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                   myArray[i,j] = int.Parse(Console.ReadLine()); // меняем тип ввода даных на цифры 
                }
            }


           
            int height = myArray.GetLength(0);
            int weidht = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int j = 0; j < weidht; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
