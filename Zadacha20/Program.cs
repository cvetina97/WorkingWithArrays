using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 6, 10, 8, 20 };
            int[] B = { 4, 5, 20, 99, 663 };
            int product = 1;
            for (int i = 0; i < A.Length; i++)
            {
                while (B[i] != 0)
                {
                    int oldB = B[i];
                    B[i] = A[i] % B[i];
                    A[i] = oldB;
                }
                product *= A[i];
            }
            Console.Write("GCD={0}", product);

            
           
           

        }
    }
}
