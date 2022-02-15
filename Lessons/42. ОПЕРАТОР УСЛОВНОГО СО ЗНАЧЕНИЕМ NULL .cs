using System;
using System.Net;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{


    class Program
    {
        //  ОПЕРАТОР УСЛОВНОГО СО ЗНАЧЕНИЕМ NULL ?.


       

        static int[] GetArray()
        {

             int[] myArray = null;

            // int[] myArray = {2, 3, 4};

            return myArray;

        }
        static void Main(string[] args)
        {

            int[] myArray = GetArray();

         
            Console.WriteLine("Sum elements in this array  " + (myArray?.Sum() ?? 0 )); // применение оператора ?? и ?. 
         // Console.WriteLine("Sum elements in this array  " + myArray?.Sum()); // применение оператора ?.

        }



        }

      
    }


 