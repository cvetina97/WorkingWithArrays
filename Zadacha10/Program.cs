using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadacha10
            Console.WriteLine("Please , enter a number!");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            double min = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            { 
                double absolute = Math.Abs(array[i]);
                if(absolute < min)
                {
                    min = absolute;
                }
            }
            Console.WriteLine("The element with min absolute value is : " + min);

            for (int i = 0; i < n; i++)
            {
                double element = Math.Abs(array[i]);
                if (element == min)
                {
                    Console.Write("The indexes with min absolute value are : " + i + " , ");
                }
            }
        }
    }
}
