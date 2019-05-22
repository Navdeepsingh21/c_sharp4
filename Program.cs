using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("enter first number");
            a = int.Parse(Console.ReadLine());

            Console.Write("enter second number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a - b);
            Console.ReadLine();
        }
    }
}
