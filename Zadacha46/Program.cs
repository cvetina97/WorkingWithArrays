using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, -3, 0, -6, 8, -15, -2 };
            int temp = 0;
            int left =0;
            int right = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0)
                {
                    right++;
                }
                else
                {
                    left++;
                }
            }
            for (int i = 0; i < left; i++)
            {
                if (A[i] < 0)
                {
                    for (int j = A.Length-1; j >= left-1; j--)
                    {
                        if (A[j] > 0)
                        {
                            temp = A[i];
                            A[i] = A[j];
                            A[j] = temp;
                            break;
                        }
                    }
                    //for (int l = 0; l < A.Length; l++)
                    //{
                    //    Console.Write(A[l] + " , ");
                    //}
                    //Console.WriteLine();
                    //Console.WriteLine();
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " , ");
            }
            Console.ReadLine();

        }
    }
}
