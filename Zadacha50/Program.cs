using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha50
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            int[] A = { 5, 6, 10, 25, 113 };
            int[] B = new int[A.Length + 1];
            int temp=0;
            for (int i = 0; i < A.Length; i++)
            {
                if (q < A[i])
                {
                    temp = i;
                    break;
                }
                else if (q == A[i])
                {
                    temp = i;
                    break;
                }
                else if(q > A[A.Length - 1])
                {
                    temp = A.Length;
                    break;
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (temp == i)
                {
                    B[i] = q;
                }
                else if (temp > i)
                {
                    B[i] = A[i];
                }
                else if (temp < i)
                {
                    B[i] = A[i-1];
                }
                Console.WriteLine(B[i]);
            }
        }
    }
}
