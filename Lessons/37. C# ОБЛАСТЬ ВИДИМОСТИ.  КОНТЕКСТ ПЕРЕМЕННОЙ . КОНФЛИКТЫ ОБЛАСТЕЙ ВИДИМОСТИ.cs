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
        
        
        static int b = 11; // Объявление переменной на уровне класса


        // ОБЛАСТЬ ВИДИМОСТИ | КОНТЕКСТ ПЕРЕМЕННОЙ | КОНФЛИКТЫ ОБЛАСТЕЙ ВИДИМОСТИ

        static void Main(string[] args)
        {

            int a = 3; // объявление переменной в контексте метода и класса

            Console.WriteLine(b); // вызов переменной уровня класса которая вне области видимости методов
            

            for (int i = 0; i < 10; i++)
            {
                a++; // вызов ранее объявленной переменной вне контекста данного цикла


            }

           // i++;   переменная вызвана вне контекста и является ошибкой кода
        }
    }

}
 