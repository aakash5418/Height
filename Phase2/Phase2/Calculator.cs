using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2
{
    public class Calculator
    {
        public static void display()
        {
            do
            {
                try
                {
                    double num1 = 0;
                    double num2 = 0;
                    double result = 0;

                    Console.WriteLine(" Calculator Program");

                    Console.WriteLine("\t Enter a Number 1: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t Enter a Number2: ");
                    num2 = double.Parse(Console.ReadLine());



                    Console.WriteLine("Enter Your Option:");
                    Console.WriteLine("\t + :Addition");
                    Console.WriteLine("\t - : Subtraction");
                    Console.WriteLine("\t * : Multiplication");
                    Console.WriteLine("\t / : Division");
                    Console.WriteLine("\t % : Modules");

                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Your result :{num1} + {num2} = " + result);
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Your result :{num1} - {num2} = " + result);
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Your result :{num1} * {num2} = " + result);
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"Your result :{num1} / {num2} = " + result);
                            break;
                        case "%":
                            result = num1 % num2;
                            Console.WriteLine($"Your result :{num1} % {num2} = " + result);
                            break;
                        default:
                            Console.WriteLine("invalid opition");
                            break;
                    }
                    Console.WriteLine(" \n Would You Like to Continue ? (Y = yes,N = no):");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please Enter Valid Input");
                    display();
                }
            }
            while (string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(" \t Thank You");
            Console.ReadKey();


        }
    }
}
