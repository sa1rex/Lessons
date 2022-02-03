using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {

        static int Sum(int value1, int value2)      // создание статического метода с возвращением данных и присваивание параметров

        {
            /*
            int result = value1 * value2;           // вариант 1 объявление тела метода

            return result;
            */

            return value1 * value2;                 // вариант 2 объявление тела метода



        }


        static void Colds(int result)           // создание статического метода без возвращения данных и присваивание параметра

        {
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;

                        
            c = Sum(a, b);      // присваивание данных методу
            Colds(c);           // присваивание данных методу
            Console.WriteLine("======= ");
                                    
        }
    }

}