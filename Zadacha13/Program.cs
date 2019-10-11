using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int b = 6;
            int min=int.MaxValue;
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > b && A[i]<= min)
                {
                    min = A[i];
                    Console.WriteLine("Element {0} with min value, which is bigger than b is {1} : ", i, min);
                }
            }
        }
    }
}
