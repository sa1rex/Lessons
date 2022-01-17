using System;
using System.Globalization;



namespace Lessons
{
    class Program
    {


        public static bool getTemp()
        {
            return false;
        }

        public static bool getCool()
        {
            return false;
        }


        static void Main(string[] args)
        {

            /*           Логические операторы
             *               
             * 
             *               &&   Сокращенная И    
             *               ||   Сокращенная ИЛИ
             *               &    И
             *               |    ИЛИ
             *               !    НЕ (унарный)
             * 
             */

            if (getTemp() && getCool())
            {

                Console.WriteLine(" CPU DAMAGE WARNING");
            }
            else
            {
                Console.WriteLine(" Danger Temp ");
            }





        }
    }
}
