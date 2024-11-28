using System;

class Program
{
    static void Main()
    {
        int sl0 = 7;
        string sl1 = "раз";
        string sl2 = ", ";
        int sl3 = 1;
        string sl4 = "от";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Выводимое константное сообщение...");
        Console.WriteLine("{0} {1} {4}мерь{2}{3} {1} {4}режь", sl0, sl1, sl2, sl3, sl4);
        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть окно...");
        Console.ReadKey(true);
    }
}
