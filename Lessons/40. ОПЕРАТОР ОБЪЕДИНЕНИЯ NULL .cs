using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{

    internal class Program
    {
        // ОПЕРАТОР ОБЪЕДИНЕНИЯ NULL ??

        static void Main(string[] args)
        {
/*
            string str = "null";
            
            string result = str ?? "нет данных";

            Console.WriteLine(result);
*/

            string str = null;

            string result = str ?? string.Empty;
            Console.WriteLine( "Количество символом в строке " + result.Length);
            
        }
    }

}








