using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в простой калькулятор!");
            Console.WriteLine("========================================");

            bool continueCalculation = true;

            while (continueCalculation)
            {
                try
                {
                    // Ввод первого числа
                    Console.Write("\nВведите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // Ввод оператора
                    Console.Write("Введите оператор (+, -, *, /): ");
                    char operation = Convert.ToChar(Console.ReadLine());

                    // Ввод второго числа
                    Console.Write("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;
                    bool validOperation = true;

                    // Выполнение операции
                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                Console.WriteLine("Ошибка: деление на ноль невозможно!");
                                validOperation = false;
                            }
                            else
                            {
                                result = num1 / num2;
                            }
                            break;
                        default:
                            Console.WriteLine("Ошибка: неверный оператор!");
                            validOperation = false;
                            break;
                    }

                    // Вывод результата, если операция была корректной
                    if (validOperation)
                    {
                        Console.WriteLine($"\nРезультат: {num1} {operation} {num2} = {result}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено некорректное число!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }

                // Проверка, хочет ли пользователь продолжить
                Console.Write("\nХотите выполнить еще одно вычисление? (да/нет): ");
                string response = Console.ReadLine().ToLower();

                if (response != "да" && response != "д" && response != "yes" && response != "y")
                {
                    continueCalculation = false;
                }
            }

            Console.WriteLine("\nСпасибо за использование калькулятора! Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}