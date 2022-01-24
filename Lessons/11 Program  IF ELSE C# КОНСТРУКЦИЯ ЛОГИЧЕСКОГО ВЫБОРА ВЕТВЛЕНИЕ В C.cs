using System;
using System.Globalization;



namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isInfected = true;

            if (isInfected)
            {
                Console.WriteLine("Virus Detected !!!");
            }

                        else
            {
                Console.WriteLine("All fine !");
            }



            int a;

            Console.WriteLine(" checker 5. type number ");

            a = int.Parse(Console.ReadLine());

            if (a == 5)
            {

                Console.WriteLine("Succesfull !!!");
            }

            else
            {
                Console.WriteLine("Fail");
            }


            int b;

            Console.WriteLine(" Velue validation ");

            b = int.Parse(Console.ReadLine());

            if (b % 2 == 0)
            {

                Console.WriteLine("Succesfull !!!");
            }

            else
            {
                Console.WriteLine("Fail");
            }





        }
    }
}
