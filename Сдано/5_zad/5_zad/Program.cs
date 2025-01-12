using System;

class Program
{
    // Главная точка входа в программу
    static void Main(string[] args)
    {
        // Объявление переменных для входных данных и расчётов
        double a, b, c, m, n, alfa, bet, z, eps = 0.001;
        bool FlgAccess = true; // Флаг для проверки корректности ввода

        // Запрос и ввод значения m с проверкой на корректность
        Console.Write("Введите число m: ");
        FlgAccess &= double.TryParse(Console.ReadLine(), out m); // Если ввод некорректен, флаг станет false
        Console.WriteLine();

        // Запрос и ввод значения n с проверкой на корректность
        Console.Write("Введите число n: ");
        FlgAccess &= double.TryParse(Console.ReadLine(), out n); // Если ввод некорректен, флаг станет false
        Console.WriteLine();

        // Запрос и ввод значения a с проверкой на корректность
        Console.Write("Введите число a: ");
        FlgAccess &= double.TryParse(Console.ReadLine(), out a); // Если ввод некорректен, флаг станет false
        Console.WriteLine();

        // Запрос и ввод значения b с проверкой на корректность
        Console.Write("Введите число b: ");
        FlgAccess &= double.TryParse(Console.ReadLine(), out b); // Если ввод некорректен, флаг станет false
        Console.WriteLine();

        // Запрос и ввод значения c с проверкой на корректность
        Console.Write("Введите число c: ");
        FlgAccess &= double.TryParse(Console.ReadLine(), out c); // Если ввод некорректен, флаг станет false
        Console.WriteLine();

        // Проверка на корректность ввода всех данных
        if (FlgAccess)
        {
            // Определение значения alfa в зависимости от условий
            if (m > n)
            {
                alfa = m; // Если m больше n, то alfa = m
            }
            else if (m == n)
            {
                alfa = n * Math.Cos(n); // Если m равно n, то alfa = n * cos(n)
            }
            else
            {
                alfa = n; // Если m меньше n, то alfa = n
            }

            // Определение значения bet в зависимости от условий
            if (m < 5)
            {
                bet = a; // Если m меньше 5, то bet = a
            }
            else if (m == 5)
            {
                bet = b; // Если m равно 5, то bet = b
            }
            else
            {
                bet = c; // Если m больше 5, то bet = c
            }

            // Проверка условия на значение косинуса и расчёт z
            if (Math.Abs(Math.Cos(b)) >= eps)
            {
                // Если |cos(b)| >= eps, то выполняется полное вычисление
                z = Math.Pow(alfa * alfa + bet, 1.0 / 3.0) + Math.Pow(Math.E, alfa) - Math.Cos(bet);
            }
            else
            {
                // Если условие не выполнено, то выполняется упрощённый расчёт
                z = Math.Pow(alfa * alfa + bet, 1.0 / 3.0) + Math.Pow(Math.E, alfa);
            }

            // Вывод результата на экран
            Console.WriteLine("Решение уравнения (Z): " + z);
        }
        else
        {
            // Если ввод некорректен, выводится сообщение об ошибке
            Console.WriteLine("Введены некорректные данные");
        }

        // Ожидание нажатия клавиши для завершения программы
        Console.ReadKey(true);
    }
}