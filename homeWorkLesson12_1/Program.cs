using System;

namespace homeWorkLesson12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0.0;

            var calculator = new Calculator();

            Console.WriteLine("Введите первое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак арифметической операции:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        result = calculator.Add(firstNumber, secondNumber);
                    }
                    break;
                case "-":
                    {
                        result = calculator.Sub(firstNumber, secondNumber);
                    }
                    break;
                case "*":
                    {
                        result = calculator.Mul(firstNumber, secondNumber);
                    }
                    break;
                case "/":
                    {
                        try
                        {
                            result = calculator.Div(firstNumber, secondNumber);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Нет такого арифметического знака!!!");
                    break;
            }

            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}
