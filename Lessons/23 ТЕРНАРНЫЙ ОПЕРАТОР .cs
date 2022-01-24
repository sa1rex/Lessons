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

            int[] myArray;

            myArray = new int[10];

            myArray[0] = 9;
            myArray[1] = 8;
            myArray[2] = 7;

            int a = myArray[0];
            int b = myArray[1];
            int c = myArray[2];

            int z = (a + b) * c;

            
             Console.WriteLine(z);
            Console.WriteLine(myArray.Length);

        }
    }

}











