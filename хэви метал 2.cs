using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию: +, -, *, /");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
                break;
            default:
                Console.WriteLine("Ошибка: Неверная операция.");
                break;
        }
    }
}
