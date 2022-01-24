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

            // Тернарный оператор
            /*  Пример - 1
             
             * bool accesAllowed;
            string storePassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            accesAllowed = storePassword == enteredPassword ? accesAllowed = true : accesAllowed = false;

            Console.WriteLine(accesAllowed);

            */

            //  Пример - 2

            int value = int.Parse(Console.ReadLine());
            bool result = true;
            bool resultf = false;
            value = value < 0 ? result : resultf;

            Console.WriteLine(value);






        }
    }

}



    




    


