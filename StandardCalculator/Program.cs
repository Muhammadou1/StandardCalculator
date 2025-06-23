using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace StandardCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Build a basic/standard calculation application that allows users to perform arithmetic operations 
             * such as Addition, Subtraction, Multiplication, and Division.
            */

            Console.WriteLine("Weclome to my calculator app");
            Console.WriteLine("----------------------------");
            Calculator calculator = new Calculator();
            calculator.GetCalculation();


        }
       
    }
}
