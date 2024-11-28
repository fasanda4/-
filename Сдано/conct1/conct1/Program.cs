using System;

class Program
{
    static void Main()
    {
        string str1 = "Работа";
        char dash = '–';
        string str2 = "не волк, в лес не убежит, потому её, окаянную, делать и надо.";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Выводимое константное сообщение...");

        Console.WriteLine(str1 + " " + dash + " " + str2);
        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть окно...");
        Console.ReadKey(true);
    }
}

