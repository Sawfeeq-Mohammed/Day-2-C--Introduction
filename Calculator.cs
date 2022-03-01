using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyirstConsole
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = int.Parse(Console.ReadLine());

            String operation;
            Console.WriteLine("Enter the operation to perform:");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "add":
                    {
                        Console.WriteLine(num1 + num2);
                        break;
                    }
                case "sub":
                    {
                        Console.WriteLine(num1 - num2);
                        break;
                    }
                case "div":
                    {
                        Console.WriteLine(num1 / num2);
                        break;
                    }
                case "mul":
                    {
                        Console.WriteLine(num1 * num2);
                        break;
                    }
                case "mod":
                    {
                        Console.WriteLine(num1 % num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid operation");
                        break;
                       
                    }

            }


            
            
            
            Console.ReadLine();

        }
    }
}
