using System;

class Program
{
    static void Main(string[] args)
    {
        // Объявление переменных
        int n, fact1 = 1, fact2 = 1, f1 = 2, f2 = 0, yDegree = 0, xDegree = 1, tgDegree = 1;
        double x, y, eps = 0.001, e = 0; // eps - пороговая точность для проверки синуса/косинуса
        bool flg1, flg2, flg3; // Флаги для проверки корректности ввода

        // Ввод данных пользователем
        Console.Write("Введите x: ");
        flg1 = Double.TryParse(Console.ReadLine(), out x); // Проверка, является ли введенное значение числом
        Console.Write("Введите y: ");
        flg2 = Double.TryParse(Console.ReadLine(), out y); // Аналогичная проверка для y
        Console.Write("Введите кол-во элементов ряда: ");
        flg3 = Int32.TryParse(Console.ReadLine(), out n); // Проверка для целочисленного ввода

        // Проверка корректности ввода
        if (flg1 && flg2 && flg3) // Убедимся, что все значения введены корректно
        {
            // Проверка, что значение Math.Cos(y) достаточно далеко от нуля
            flg1 = Math.Abs(Math.Cos(y)) >= eps;
            if (flg1)
            {
                // Проверка, что значение Math.Sin(y) достаточно далеко от нуля
                flg2 = Math.Abs(Math.Sin(y)) >= eps;
                if (flg2)
                {
                    // Основной цикл расчета значений ряда
                    for (int i = 1; i <= n; i++)
                    {
                        // Инкремент вспомогательных переменных
                        f1++;
                        f2 += 2;
                        yDegree += 2;
                        xDegree *= 2;
                        tgDegree++;

                        // Расчет факториалов для текущего элемента ряда
                        for (int j = 1; j <= f1; j++)
                        {
                            fact1 *= j;
                        }
                        for (int g = 1; g <= f2; g++)
                        {
                            fact2 *= g;
                        }

                        // Вычисление текущего элемента ряда в зависимости от номера i
                        if (i % 4 == 1)
                        {
                            e += (Math.Pow(y, yDegree) + Math.Sin(fact1)) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
                        }
                        else if (i % 4 == 2)
                        {
                            e -= (Math.Pow(y, yDegree) + Math.Cos(fact1)) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
                        }
                        else if (i % 4 == 3)
                        {
                            e += (Math.Pow(y, yDegree) + Math.Tan(fact1)) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
                        }
                        else if (i % 4 == 0)
                        {
                            e -= (Math.Pow(y, yDegree) + (Math.Cos(fact1) / Math.Sin(fact1))) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
                        }

                        // Сброс значений факториалов для следующей итерации
                        fact1 = 1;
                        fact2 = 1;
                    }

                    // Вывод результата
                    Console.WriteLine($"e = {e}");
                }
                else
                {
                    // Сообщение об ошибке при недопустимом значении Math.Sin(y)
                    Console.WriteLine("Невозможно решить задачу: значение синуса y слишком мало.");
                }
            }
            else
            {
                // Сообщение об ошибке при недопустимом значении Math.Cos(y)
                Console.WriteLine("Невозможно решить задачу: значение косинуса y слишком мало.");
            }
        }
        else
        {
            // Сообщение об ошибке при некорректном вводе данных
            Console.WriteLine("Введены некорректные данные. Пожалуйста, повторите ввод.");
        }

        // Задержка перед завершением программы
        Console.ReadKey(true);
    }
}
