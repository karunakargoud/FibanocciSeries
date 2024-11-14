using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibanocciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3;
            Console.WriteLine("Enter a series");
            int range=int.Parse(Console.ReadLine());
            Console.Write(num1 + " ");
            Console.Write(num2+" ");
            for (int i = 0; i < range-1; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
                Console.WriteLine();
            
        }
    }
}
