using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    static class CouponProgram
    {
        static char[] code = "ghhhhhhhhsgvhasvuagfvassfvajsvf651648946512dasfasfasfasa".ToCharArray();
        public static void CouponNumbers()
        {
            Console.Write("Enter number coupon code length: ");

            int number = Convert.ToInt32(Console.ReadLine());
            StringBuilder str = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                int position = random.Next(0, code.Length);
                str.Append(code[position]);
            }

            Console.WriteLine("\n\nCoupon Code:  " + str);
        }
    }
}