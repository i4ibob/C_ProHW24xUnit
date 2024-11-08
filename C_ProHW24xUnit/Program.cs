using C_ProHW24xUnit;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1: Сложение");
                Console.WriteLine("2: Вычитание");
                Console.WriteLine("3: Умножение");
                Console.WriteLine("4: Деление");
                Console.WriteLine("5: Среднее значение");
                Console.WriteLine("0: Выход");
                Console.Write("Ваш выбор: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите два числа для сложения:");
                        int addA = ReadInt("Число 1: ");
                        int addB = ReadInt("Число 2: ");
                        Console.WriteLine($"Результат: {calculator.Add(addA, addB)}\n");
                        break;

                    case 2:
                        Console.WriteLine("Введите два числа для вычитания:");
                        int subA = ReadInt("Число 1: ");
                        int subB = ReadInt("Число 2: ");
                        Console.WriteLine($"Результат: {calculator.Subtract(subA, subB)}\n");
                        break;

                    case 3:
                        Console.WriteLine("Введите два числа для умножения:");
                        int mulA = ReadInt("Число 1: ");
                        int mulB = ReadInt("Число 2: ");
                        Console.WriteLine($"Результат: {calculator.Multiply(mulA, mulB)}\n");
                        break;

                    case 4:
                        Console.WriteLine("Введите два числа для деления:");
                        int divA = ReadInt("Число 1: ");
                        int divB = ReadInt("Число 2: ");
                        try
                        {
                            Console.WriteLine($"Результат: {calculator.Divide(divA, divB)}\n");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}\n");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Введите числа для вычисления среднего значения (через запятую):");
                        var numbers = ReadIntArray();
                        try
                        {
                            Console.WriteLine($"Среднее значение: {calculator.CalculateAverage(numbers)}\n");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}\n");
                        }
                        break;

                    case 0:
                        keepRunning = false;
                        Console.WriteLine("Выход...");
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.\n");
                        break;
                }
            }
        }
        static int ReadInt(string message)
        {
            Console.Write(message);
            int number; 

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                Console.Write(message);
            }
            return number;
        }

        static int[] ReadIntArray()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    var numbers = Array.ConvertAll(input.Split(','), int.Parse);
                    return numbers;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа, разделенные запятыми.");
                }
            }
        }
    }
}
