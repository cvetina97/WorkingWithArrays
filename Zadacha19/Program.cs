using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha19
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double sum = 0;
            double average = 0;

            Console.WriteLine("Please , enter n ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int zero=0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    zero = i;
                    break;
                }
            }

            for (int i = zero; i < array.Length; i++)
            {
                
                if (array[i] >= 0)
                {
                    continue;
                }
                else
                {
                    sum += array[i];
                    counter++;
                }
                average = sum / counter;
            }
            Console.WriteLine("The sum of all negative numbers is {0} , their count is  {1} and average = {2}", sum, counter, average);
        }
    }
}
