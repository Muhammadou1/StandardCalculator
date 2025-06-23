using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StandardCalculator
{
    public class Calculator
    {
        //history of all calculated numbers
        //infinit loop to calculate all the numbers 
        // add number and subtract to undo 
        // continouesly add numbers 
        public void GetCalculation()
        {
            double num1;
            double num2;

            // Enter numbers in console
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Choose from options
            Console.WriteLine("Choose from the following option to calculate number");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Enter (+) if you wish to add numbers");
            Console.WriteLine("Enter (-) if you wish to subtract numbers");
            Console.WriteLine("Enter (*) if you wish to multiply numbers");
            Console.WriteLine("Enter (/) if you wish to divide numbers");

            // Use a switch statement to display results
            string result = Console.ReadLine();
            switch (result)
            {
                case "+":
                    Console.WriteLine($"Result of {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Result of {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Result of {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a different number");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Result of {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            
            

        }
    }
}
