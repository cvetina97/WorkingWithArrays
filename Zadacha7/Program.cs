using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n :");
            int n = int.Parse(Console.ReadLine());
            int counterBlond = 0;
            int counterOrange = 0;
            int counterBrown = 0;
            int counterBlack = 0;
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());

                switch (A[i])
                {
                    case 0:Console.WriteLine("The person is with blond hair!");
                        counterBlond++;
                        break;
                    case 1:
                        Console.WriteLine("The person is with orange hair!");
                        counterOrange++;
                        break;
                    case 2:
                        Console.WriteLine("The person is with brown hair!");
                        counterBrown++;
                        break;
                    case 3:
                        Console.WriteLine("The person is with black hair!");
                        counterBlack++;
                        break;
                    default: Console.WriteLine("You are wrong !There isn't such a person!");
                        break;
                }
            }

            Console.WriteLine("There are {0} people with blond hair , {1} with orange , {2} with brown and {3} with black hair !", counterBlond, counterOrange, counterBrown, counterBlack);

            
        }
    }
}
