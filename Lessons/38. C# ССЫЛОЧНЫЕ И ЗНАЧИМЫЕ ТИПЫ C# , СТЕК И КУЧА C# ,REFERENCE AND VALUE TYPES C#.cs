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
        //  ��������� (REFERENCE TYPES) � �������� (VALUE TYPES) ���� C#
        // ���� (STEAK) � ���� (HEAP)



            // ������ ������ HEAP

        static void Foo ( int[] value)
        {
            value[0] = 5;

        }



        static void Main(string[] args)
        {

            int[] a = new int[1];
            a[0] = 1;

            Foo(a);

            Console.WriteLine(a[0]);

        }

        // ������ ������ STEAK

        /*
         * static void Foo ( int value)
        {
            value = 5;

        }



        static void Main(string[] args)
        {

            
            a = 1;

            Foo(a);

            Console.WriteLine(a);

        }
         */
    }

}
 