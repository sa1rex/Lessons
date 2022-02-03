using System;
using System.Net;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {

        /*
                *              1.	Написать функцию которая выводит на экран строку. 
                 *              Символы из которых состоит строка и их количество вводятся пользователем.
                 * 

               static void Main(string[] args)
                {

                    int a = int.Parse(Console.ReadLine());

                    for (int i = a; i > 0; i--)
                    {
                        stringMeth();
                    }
                }



                static void stringMeth()
                {
                    Console.WriteLine("!");
                }

                */

        // 1.1

        /*

        static void Tiper(string symbol, uint countsymb)
        {


            for (uint i = countsymb; i > 0; i--)
            {
                Console.Write(symbol);
            }
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("type symbol");
            string symbol = Console.ReadLine();

            Console.WriteLine("type countsymb");
            uint countsymb = uint.Parse(Console.ReadLine());

            Tiper(symbol, countsymb);

        }
        */
        /*
                // 2.Написать метод для поиска индекса элемента массива (тип элементов в массиве -int), 
                // метод должен вернуть индекс первого найденного элемента (если он будет найден).


                static void Main(string[] args)
                   {


                    findArray();


                }

                static void findArray()
                {
                    int[] myArray =
                    {
                        2,5,14,164,123,132,553,32,1,4,6
                    };
                    Console.WriteLine(myArray[0]);
                }
                */

        // 2.1
        /*
                static int IndexOf (int[] array, int count)
                {

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == count)
                        {
                            return i;
                        }

                    }
                    return -1;
                }
                static void Main(string[] args)
                {
                    int[] myArray = { 2, 23, 25, 4, 134 };

                    int result = IndexOf(myArray, 134);

                    Console.WriteLine(result);
                }
                */

        // 3. Метод генерации массива с случайными числами

        static int[] GetRandomArray(uint lenght, int minValue, int maxValue)

        {
            int[] myArray = new int[lenght];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;

        }

            static void Main(string[] args)
        {

            int[] myArray = GetRandomArray(5, 5, 20);

        }
    }

}
 