using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public static class PerfectNumber
    {
        public static void PerfectNumProgram()
        {
            int num, a, sum = 0;

            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            a = num;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
                if ( sum == a )
                {
                    Console.WriteLine("The Number is a Perfect Number");
                    
                }
                else
                {
                    Console.WriteLine("The Number is Not a Perfect Number");
                    
                }
        }


        
    }
}
