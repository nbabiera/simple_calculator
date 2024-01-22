using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TeleprompterConsole;

internal class Program
{
    static void Main(string[] args)
    {
        double fNum = 0;
        double sNum = 0;
        double res = 0;
        int opt = 0;
        string optVal = "";

        Console.WriteLine("----------------------- \n*  Simple Calculator  * \n-----------------------");
        Console.Write("Enter first number:");
        while (!double.TryParse(Console.ReadLine(), out fNum))
        {
            Console.Write("This is not valid input. Please enter a NUMBER: ");
        }

        Console.Write("Enter second number:");
        while (!double.TryParse(Console.ReadLine(), out sNum))
        {
            Console.Write("This is not valid input. Please enter a NUMBER: ");
        }

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");
        Console.Write("Enter the operation number (1-4): ");

            
        while(!int.TryParse(Console.ReadLine(), out opt))
        {
            Console.WriteLine("Choose a number only: ");
            Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");
            Console.Write("Enter the operation number (1-4): ");
        }

        switch (opt)
        {
            case 1:
                res = fNum + sNum;
                optVal = "Addition";
                break;
            case 2:
                res = fNum - sNum;
                optVal = "Subtraction";
                break;
            case 3:
                res = fNum * sNum;
                optVal = "Multiplication";
                break;
            case 4:
                while(sNum == 0)
                {
                    Console.WriteLine("Divisor cannot be equal to 0");
                    Console.Write("Please enter a NUMBER: ");

                    while (!double.TryParse(Console.ReadLine(), out sNum))
                    {
                        Console.Write("This is not valid input. Please enter a NUMBER: ");
                    }
                }
                res = fNum / sNum;
                optVal = "Division";
                break;
            default:
                break;
        }

        Console.WriteLine("Result of " + optVal + ": " + res.ToString());

        Main(null);

    }
}