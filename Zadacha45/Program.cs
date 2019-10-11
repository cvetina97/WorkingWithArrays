using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha45
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int[] array = { 5, 10, 3, 8, 20, 7 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Number " + array[i] + " before change ! ");
                if (array[i] < m)
                {
                    array[i] = array[i] * 2;
                }
                else if (array[i] == m)
                {
                    array[i] = -array[i];
                }
                else
                {
                    array[i] = array[i] - 1;
                }
                Console.WriteLine("Number " + array[i] + " after change ! ");
            }

            
        }
    }
}
