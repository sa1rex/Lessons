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
         * вложенный цикл 
        */

        static void Main(string[] args)
        {
            // Домашнее задания нарисовать треугольники

            Console.WriteLine("Type height triangle");
            int height = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < i; j++)

                {
                    
                    Console.Write("#");
                }

                Console.WriteLine();
            }





        }
    }

}



    




    


