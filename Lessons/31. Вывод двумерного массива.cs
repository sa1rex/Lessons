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

            myArray = new int[5, 5]              //      Инициализируем массив, определяем место в памяти и присваиваем размерность и значения
            {
                {23,434,22,42,11},
                {7,86,34,97,12},
                {536,7,33,9,2344},
                {54,43,9,92,12},
                {12,67,999,45,62}

            };

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
        }
    }
}
