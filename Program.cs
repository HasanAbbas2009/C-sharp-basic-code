using System;
namespace CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Selct the operation by serial number");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Sutraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            char keyChar = Console.ReadKey().KeyChar;
            char calc = keyChar;
            
            switch (calc)
            {
                case '1':
                    Console.WriteLine(a + b);
                    break;
                case '2':
                    Console.WriteLine(a - b);
                    break;
                case '3':
                    Console.WriteLine(a * b);
                    break;
                case '4':
                    Console.WriteLine(a / b);
                    break;
            }
        }
    }
}
