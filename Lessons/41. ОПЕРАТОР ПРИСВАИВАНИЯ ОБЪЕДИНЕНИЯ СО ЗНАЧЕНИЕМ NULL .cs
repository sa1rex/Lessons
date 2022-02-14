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
        //  ÎÏÅĞÀÒÎĞ ÏĞÈÑÂÀÈÂÀÍÈß ÎÁÚÅÄÈÍÅÍÈß ÑÎ ÇÍÀ×ÅÍÈÅÌ NULL ??=


        /*
                static void Main(string[] args)
                {
                    string str = null;

                    string result = str ??= "default string";

                    Console.WriteLine("how many characters in the word " + result.Length);
        */

        static int[] GetArray()
        {

            int[] myArray = null;

            return myArray;

        }
        static void Main(string[] args)
        {

            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine(" how many characters in this" + myArray.Length);

        }



        }

      
    }

}
 