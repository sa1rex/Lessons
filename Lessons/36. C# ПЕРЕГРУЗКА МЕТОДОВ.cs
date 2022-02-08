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
        // Перегрузка методов
        static int Sum(int a, int b, int c)
        {

            return a + b + c;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum (double a, double b)

        {
            return a + b;
        }

      static void Main(string[] args)
        {

            Console.WriteLine(Sum(3,4,2));
            
        }
    }

}
 