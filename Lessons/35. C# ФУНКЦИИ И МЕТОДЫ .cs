using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {

        static int Sum(int value1, int value2)      // �������� ������������ ������ � ������������ ������ � ������������ ����������

        {
            /*
            int result = value1 * value2;           // ������� 1 ���������� ���� ������

            return result;
            */

            return value1 * value2;                 // ������� 2 ���������� ���� ������



        }


        static void Colds(int result)           // �������� ������������ ������ ��� ����������� ������ � ������������ ���������

        {
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;

                        
            c = Sum(a, b);      // ������������ ������ ������
            Colds(c);           // ������������ ������ ������
            Console.WriteLine("======= ");
                                    
        }
    }

}