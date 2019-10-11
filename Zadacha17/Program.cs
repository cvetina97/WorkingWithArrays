using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -4, 5, 6, -3, -7, 8, -3, -9, 1 };
            int positive;
            int negative;
            int counter = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > 0)
                {
                    positive = array[i];
                    if(array[i+1] < 0)
                    {
                        negative = array[i + 1];
                        counter++;
                    }
                    else
                    {
                        positive = array[i + 1];
                    }
                }
                else if(array[i] < 0)
                {
                    negative = array[i];
                    if(array[i+1] > 0)
                    {
                        positive = array[i + 1];
                        counter++;
                    }
                    else
                    {
                        negative = array[i + 1];
                    }
                }
                
            }
            Console.WriteLine("The couples with different signs are {0}", counter);
        }
    }
}
