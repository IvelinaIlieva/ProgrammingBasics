using System;

namespace T06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            //calculations:
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(result % 2 == 0 ? $"{num1} + {num2} = {result} - even" : $"{num1} + {num2} = {result} - odd");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result % 2 == 0 ? $"{num1} - {num2} = {result} - even" : $"{num1} - {num2} = {result} - odd");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result % 2 == 0 ? $"{num1} * {num2} = {result} - even" : $"{num1} * {num2} = {result} - odd");
                    break;
                case "/":
                    result = (double)num1 / (double)num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    break;
            }
        }
    }
}
