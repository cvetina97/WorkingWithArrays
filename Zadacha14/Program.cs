using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 6, 1, 0 };
            int[] B = { 1, 6, 7, 2 };
            int sum = 0;
            int product = 1;
            for (int i = 0; i < A.Length; i++)
            {
                product = A[i] * B[i];
                sum += product;
            }
            Console.WriteLine("The sum of all products is : " + sum);
        }
    }
}
