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
         * ключевое слоа break 
         */

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
           
        }


    }

}

    


