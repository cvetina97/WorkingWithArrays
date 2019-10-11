using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFocus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadacha9;
            Console.WriteLine("Please ,enter a number !");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];

                }
            }
            Console.WriteLine("The max value is : " + max);
            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    Console.Write("The indexes with max value are : " + i + " , ");
                }
            }

        }
    }
}
