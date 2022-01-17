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
         * Условный оператонр Switch
         */

        static void Main(string[] args)
        {



            string b = Console.ReadLine();

            switch (b)


            {
                case "+":

                    Console.WriteLine("Вы ввели плюс");

                    break;

                case "-":

                    Console.WriteLine("Вы ввели минус");

                    break;

                default:
                    Console.WriteLine(" Я не знаю что делать с этим символом ");
                    break;

            }

        }

    }
}

