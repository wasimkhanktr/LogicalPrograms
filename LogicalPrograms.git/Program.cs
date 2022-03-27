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
            Console.WriteLine("Enter the value of Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
                Console.WriteLine("Perfect No");
            else
                Console.WriteLine("Not Perfect No");
        }
    }
}