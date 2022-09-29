using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string> { "exit", "greet", "sum", "divide", "swap"};

            menu(options);
        }

        private static void menu(List<string> options)
        {
            int option = 1;
            while (option != 0)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("");
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i}: {options[i]}");
                }
                Console.Write("Enter the number you would like to select: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (option)
                {
                    case 1:
                        greet();
                        break;
                    case 2:
                        sum();
                        break;
                    case 3:
                        divide();
                        break;
                    case 4:
                        swap();
                        break;
                }
            }
            Console.WriteLine("Exiting... See you soon!");
        }

        private static void swap()
        {
            Console.WriteLine("Enter two numbers to be swapped:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"{number1} {number2}");
        }

        private static void divide()
        {
            Console.WriteLine("Enter two numbers:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int divided = number1 / number2;
            Console.WriteLine($"{number1} divided by {number2} is {divided}.");
        }

        private static void sum()
        {
            Console.WriteLine("Enter two numbers:  ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
        }

        private static void greet()
        {
            Console.WriteLine("What's your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}
