using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadacha8
            int n =int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];
            int[] D = new int[n];
            Console.WriteLine("The elements in A: ");
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements in B: ");
            for (int i = 0; i < n; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements in C: ");
            for (int i = 0; i < n; i++)
            {
                C[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements in D: ");
            for (int i = 0; i < n; i++)
            {
                D[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        for (int l = 0; l < n; l++)
                        {
                            if(((A[i] == B[j]) && (C[k] == D[l])))
                            {
                                Console.WriteLine(" " + A[i] + " " + B[j] + " " + C[k] + " " + D[l]);
                            }
                        }
                    }
                }
            }
        }
    }
}
