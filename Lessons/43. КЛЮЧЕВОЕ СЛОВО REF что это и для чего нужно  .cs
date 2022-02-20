using System;
using System.Net;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{


    //  КЛЮЧЕВОЕ СЛОВО REF C# | C# ref что это и для чего нужно 

    /* // Передача ссылочного параметра
        class Program
        {
           


            static void Foo (ref int value) // ссылаемся на параметр из метода Main
            {

              value = -5;

            }


            static void Bar (int[] args)
            {


            }

            static void Main (string[] args)
            {

                int a = 2;

                Foo (ref a); // вызываем метод Foo с сылочным параметром

                Console.WriteLine(a);

            }
         }
            */


    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 



    // применение REF при создании структур

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






    // ссылочные локальные переменные
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

            ref int b = ref arr[0]; // подключение ссылки между переменной и элементом массива

            b = 5; // изменение элемента массива через переменную

            Console.WriteLine(b);

        }

    }
    */

    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 


    // возвращаемые ссылочные значения

    class Program

    {

        static ref int Foo(int[] numbers)

        {
            return ref numbers[0];

        }


        static void Main(string[] args)
        {

            int[] arr = { 2, 6, 1 }; 

            
           ref int b = ref Foo(arr); // связываем переменную b с возвращаем значением метода Foo

            b = -5;

        }

    }
     



}


 