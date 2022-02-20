using System;
using System.Net;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{


    //  �������� ����� REF C# | C# ref ��� ��� � ��� ���� ����� 

    /* // �������� ���������� ���������
        class Program
        {
           


            static void Foo (ref int value) // ��������� �� �������� �� ������ Main
            {

              value = -5;

            }


            static void Bar (int[] args)
            {


            }

            static void Main (string[] args)
            {

                int a = 2;

                Foo (ref a); // �������� ����� Foo � �������� ����������

                Console.WriteLine(a);

            }
         }
            */


    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 



    // ���������� REF ��� �������� ��������

    /*
    struct MyStruct
        {

            public int a;
            public double b;
            public float c;

        }

    class Program
    {

        static void Foo (ref MyStruct myStruct)

        { 
        
        myStruct.a = -5;
        
        }

        static void Main(string[] args)

        { 
        
        MyStruct myStruct = new MyStruct();
        
        Foo (ref myStruct);

        }
    

    }

     */



    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>






    // ��������� ��������� ����������
    /*
    class Program

    {

        static ref int Foo(int[] numbers)

        {
            return ref numbers[0];

        }


        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3 };

            ref int b = ref arr[0]; // ����������� ������ ����� ���������� � ��������� �������

            b = 5; // ��������� �������� ������� ����� ����������

            Console.WriteLine(b);

        }

    }
    */

    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 


    // ������������ ��������� ��������

    class Program

    {

        static ref int Foo(int[] numbers)

        {
            return ref numbers[0];

        }


        static void Main(string[] args)
        {

            int[] arr = { 2, 6, 1 }; 

            
           ref int b = ref Foo(arr); // ��������� ���������� b � ���������� ��������� ������ Foo

            b = -5;

        }

    }
     



}


 