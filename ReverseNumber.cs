using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReverseNumber
    {
        public static void ReverseNumProgram()
        {
            int number, reverse = 0;

            Console.WriteLine("Enter a Number :");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Reverse of entered Number is : " + reverse);
        }
    }
}