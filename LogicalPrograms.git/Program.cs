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
            int[] a = new int[n];
            a[0] = 0;
            a[1] = 1;
            Console.Write("0 1 ");
            for (int i = 2; i < n; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
                Console.Write(a[i] + " ");
            }
        }
    }
}