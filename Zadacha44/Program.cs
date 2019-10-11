using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha44
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxN = int.Parse(Console.ReadLine());
            bool symmetric = true;
            bool is_simple = true;

            string binary = "";
            for (int i = 1; i < maxN; i++)
            {
                is_simple = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        is_simple = false;
                        break;
                    }

                }
                if (is_simple)
                {
                     symmetric = true;
                    Console.WriteLine(i);
                    binary = Convert.ToString(i, 2);
                    char[] array = binary.ToArray();
                    for (int k = 0; k <= array.Length / 2; k++)
                    {
                        if (array[k] != array[array.Length - k - 1])
                        {
                            symmetric = false;
                            break;
                        }
                    }
                    
                    Console.WriteLine(binary);
                    Console.WriteLine("Is symmetric? {0}", symmetric);

                }

            }

        }
    }
}

