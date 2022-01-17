Using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Program
    {

        /*
         * Условный оператонр Switch
         */

        static void Main(string[] args)
        {

            int a;
                      
            a = int.Parse(Console.ReadLine());

            switch (a)

            { 
            case 1:
                    Console.WriteLine(" Вы ввели 1 ");
                    break;
                    
            case 2:
                    Console.WriteLine(" Вы ввели 2 ");
              break;


                case 3:
                case 4: Console.WriteLine( "Вы ввели число 3 или 4 ");
                    break;

              default: Console.WriteLine(" Я не знаю что делать с этим числом ");
                break;
                    
                    
                    }

            }

        }
    }
}
