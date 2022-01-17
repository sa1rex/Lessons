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
            double a;
            double b;
            double c;
            string operand;

            Console.WriteLine(" Вы запустили калькулятор ");

            Console.WriteLine(" Введите первое число ");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine(" Введите операнд ");

            operand = Console.ReadLine();

            Console.WriteLine(" Введите второе число ");

            b = int.Parse(Console.ReadLine());

            switch (operand)

            {
                case "/":

                    c = a / b;
                    Console.WriteLine(c);
                    break;

                case "-":

                    c = a - b;

                    Console.WriteLine(c);
                    break;
                    

                case "+":

                    c = a + b;
                    Console.WriteLine(c);
                    break;

                case "*":

                    c = a * b;
                    Console.WriteLine(c);
                    break;
            }

            




        }

    }

    }


