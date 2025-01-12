using System;

class Program
{
    static void Main()
    {
        // Установка фона и цвета текста
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("Общая часть: Исследование функций модуля Math");
        Console.WriteLine("****************************************************");

        double x = 0, y = 0;

        // Ввод значения x с повторным запросом при ошибке
        while (true)
        {
            Console.Write("Введите значение x: ");
            if (double.TryParse(Console.ReadLine(), out x))
                break; // Если ввод корректен, выходим из цикла
            else
                Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
        }

        // Ввод значения y с повторным запросом при ошибке
        while (true)
        {
            Console.Write("Введите значение y: ");
            if (double.TryParse(Console.ReadLine(), out y))
                break; // Если ввод корректен, выходим из цикла
            else
                Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
        }

        Console.WriteLine("****************************************************");
        Console.WriteLine("\n--- Результаты вычислений ---");

        // Решения
        double abs = Math.Abs(x);
        double sin = Math.Sin(x);
        double cos = Math.Cos(x);
        double tan = Math.Tan(x);
        string acos = (x >= -1 && x <= 1 ? Math.Acos(x).ToString() : "Ошибка! Некорректные данные.");
        string asin = (x >= -1 && x <= 1 ? Math.Asin(x).ToString() : "Ошибка! Некорректные данные.");
        double atan = Math.Atan(x);
        double atan2 = Math.Atan2(x, y);
        long bigMul = Math.BigMul((int)x, (int)y);
        double ceiling = Math.Ceiling(x);
        double floor = Math.Floor(x);
        string sqrt = (x >= 0 ? Math.Sqrt(x).ToString() : "Ошибка! Некорректные данные.");
        string log = (x > 0 ? Math.Log(x).ToString() : "Ошибка! Некорректные данные.");
        string log10 = (x > 0 ? Math.Log10(x).ToString() : "Ошибка! Некорректные данные.");
        double exp = Math.Exp(x);
        double max = Math.Max(x, y);
        double min = Math.Min(x, y);
        double pow = Math.Pow(x, y);
        double round = Math.Round(x);
        int sign = Math.Sign(x);
        double sinh = Math.Sinh(x);
        double cosh = Math.Cosh(x);
        double tanh = Math.Tanh(x);
        double truncate = Math.Truncate(x);

        // Вывод
        Console.WriteLine($"Модуль числа: Math.Abs({x}) = {abs}");
        Console.WriteLine($"Синус: Math.Sin({x}) = {sin}");
        Console.WriteLine($"Косинус: Math.Cos({x}) = {cos}");
        Console.WriteLine($"Тангенс: Math.Tan({x}) = {tan}");
        Console.WriteLine($"Арккосинус: Math.Acos({x}) = {acos}");
        Console.WriteLine($"Арксинус: Math.Asin({x}) = {asin}");
        Console.WriteLine($"Арктангенс: Math.Atan({x}) = {atan}");
        Console.WriteLine($"Функция Atan2: Math.Atan2({x}, {y}) = {atan2}");
        Console.WriteLine($"Большое умножение: Math.BigMul({x}, {y}) = {bigMul}");
        Console.WriteLine($"Округление вверх: Math.Ceiling({x}) = {ceiling}");
        Console.WriteLine($"Округление вниз: Math.Floor({x}) = {floor}");
        Console.WriteLine($"Квадратный корень: Math.Sqrt({x}) = {sqrt}");
        Console.WriteLine($"Логарифм по основанию e: Math.Log({x}) = {log}");
        Console.WriteLine($"Логарифм по основанию 10: Math.Log10({x}) = {log10}");
        Console.WriteLine($"Экспонента: Math.Exp({x}) = {exp}");
        Console.WriteLine($"Максимум (x, y): Math.Max({x}, {y}) = {max}");
        Console.WriteLine($"Минимум (x, y): Math.Min({x}, {y}) = {min}");
        Console.WriteLine($"Число PI: Math.PI = {Math.PI}");
        Console.WriteLine($"Число E: Math.E = {Math.E}");
        Console.WriteLine($"Возведение в степень: Math.Pow({x}, {y}) = {pow}");
        Console.WriteLine($"Округление: Math.Round({x}) = {round}");
        Console.WriteLine($"Знак числа: Math.Sign({x}) = {sign}");
        Console.WriteLine($"Гиперболический синус: Math.Sinh({x}) = {sinh}");
        Console.WriteLine($"Гиперболический косинус: Math.Cosh({x}) = {cosh}");
        Console.WriteLine($"Гиперболический тангенс: Math.Tanh({x}) = {tanh}");
        Console.WriteLine($"Отбрасывание дробной части: Math.Truncate({x}) = {truncate}");

        Console.WriteLine("****************************************************");
        Console.WriteLine("\n--- Конец выполнения общей части ---");
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
