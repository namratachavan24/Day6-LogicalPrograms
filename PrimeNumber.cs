using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNumber
    {
        public static void PrimeNumberProgram()
        {
            Console.WriteLine("Enter the Number: \n");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
}
