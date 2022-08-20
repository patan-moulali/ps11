using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput second integer");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("check if both are positive");
            Console.WriteLine((x > 0 && y > 0) || (x > 0 && y > 0));

            Console.ReadLine();
        }
    }
}
