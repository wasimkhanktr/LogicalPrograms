using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Unique Coupons you want to generate");
            int n = Convert.ToInt32(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            int totalRandomNo = 0;
            Random random = new Random();
            while (totalRandomNo < n)
            {
                int coupon = random.Next(1, 1000);
                Console.WriteLine(coupon);
                if (!numbers.Contains(coupon))
                {
                    totalRandomNo++;
                    numbers.Add(coupon);

                }
            }
            Console.WriteLine("The no of times random used in generating unique coupons is " + totalRandomNo);
        }
    }
}