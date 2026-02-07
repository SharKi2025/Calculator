
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите 1ое число");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2ое число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                if (num2 == 0)
                        throw new DivideByZeroException("Деление на ноль запрещено");
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    throw new InvalidOperationException("Неверная операция");
            }

            Console.WriteLine($"Результат операции: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод числа");
        }
    }
}