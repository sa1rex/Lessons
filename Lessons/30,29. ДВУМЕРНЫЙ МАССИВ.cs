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
         * 3 C# 101 Searching Strings
        */

        static void Main(string[] args)
        {

            // ��������� �������

            // ��������� ������������� ������

            int[,] myArray;                         //      ��������� �������� ���������� �������

            myArray = new int[3, 5]              //      �������������� ������, ���������� ����� � ������ � ����������� ����������� � ��������
            {
                {23,434,22,42,11},
                {7,86,34,97,12},
                {536,7,33,9,2344}
            };
                           

            myArray[0, 4] = 77;                     //      ����������� �������� ������� � 1-� ������ � 5-� ������� 
                                                          
            Console.WriteLine(myArray[0,4]);        //      ������� �������� �������
            Console.WriteLine(myArray[2, 4]);       //      ������� �������� �������
        }
    }

             
        
         
}          
           
           









