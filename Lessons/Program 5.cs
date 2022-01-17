using System;




namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;

            int a, b;

            Console.WriteLine("type number 1");

            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("type number 2");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Total " + result);

        }
    }
}
