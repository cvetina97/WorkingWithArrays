using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please , enter n ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int element;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        element = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = element;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " , ");
            }
        }
    }
}
