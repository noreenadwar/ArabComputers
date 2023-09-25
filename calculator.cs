using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //Console.Write("Calculator:");
            //Console.WriteLine("Write first number:");
            //double number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write second number:");
            //double number2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter operation");
            //char ch = char.Parse(Console.ReadLine());
            //switch (ch)
            //{
            //    case '+':
            //        Console.WriteLine(number1 + number2);
            //        break;
            //    case '-':
            //        Console.WriteLine(number1 - number2);
            //        break;
            //    case '*':
            //        Console.WriteLine(number1 * number2);
            //        break;
            //    case '/':
            //        Console.WriteLine(number1 / number2);
            //        break;
            //} Console.ReadKey();
            Console.WriteLine("Please enter your student name:");
            Console.ReadLine();
            Console.WriteLine("Please enter your C# Result:");
            int result= int.Parse(Console.ReadLine());
            if (result >= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Grade: A");
            }
            else if (90 <= result && result >= 80)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Grade: B");
            }
            else if (80 < result && result >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Grade: C");
            }
            else if (60 > result && result >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Grade: D");
            }
            else if (result < 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Grade: F");
            }
            Console.ReadKey();





        } 
    }
}
