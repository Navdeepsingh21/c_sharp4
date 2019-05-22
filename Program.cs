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
            string operation;
            Console.Write("enter 1st number");
            a = int.Parse(Console.ReadLine());

            Console.Write("enter operator");
            operation = Console.ReadLine();

            Console.Write("enter 2nd number");
            b = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;
                default:
                    Console.WriteLine("wrong character");
                    break;

            }
;
        }
    }
}
