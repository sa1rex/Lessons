using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1.�����_����������_�������
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] myArray;                         //      ��������� �������� ���������� �������

            myArray = new int[2, 3];



            // ���������� ���������� �������

            /* 
              Random random = new Random();           //      ������� ���������� ��������� �����
             for (int i = 0; i < myArray.GetLength(0); i++)
             {
                 Console.WriteLine();

                 for (int j = 0; j < myArray.GetLength(1); j++)
                 {
                     myArray[i, j] =  random.Next(1000);  // � ������� ���������� ����� ���������� ������ ������� ������� � ��������� ��� ��������� ������
                 }
             }
             */

            // ����������� ������� � ����������

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine(" Type elements please ");

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                   myArray[i,j] = int.Parse(Console.ReadLine()); // ������ ��� ����� ����� �� ����� 
                }
            }


           
            int height = myArray.GetLength(0);
            int weidht = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int j = 0; j < weidht; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
