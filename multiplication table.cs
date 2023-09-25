using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Multiplication Table:");

            //for(int i=1;i<=10;i++)
            //{
            //    for(int j=1;j<=10;j++)
            //    {
            //        Console.WriteLine($" {i}*{j} = {i * j}");
            //     //   Console.WriteLine(i * j = answer);

            //    }

            //} Console.ReadKey();

            Console.Write("Calculator:");
            Console.WriteLine("Write first number:");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write second number:");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter operation");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case '+':
                    Console.WriteLine(number1 + number2);
                    break;
                case '-':
                    Console.WriteLine(number1 - number2);
                    break;
                case '*':
                    Console.WriteLine(number1 * number2);
                    break;
                case '/':
                    Console.WriteLine(number1 / number2);
                    break;
            } Console.ReadKey();
        } 
    }
}
