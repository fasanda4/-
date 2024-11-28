using System;

class Program
{
    static void Main()
    {
        string text = "Ок$зался, выс?хшее, ш$гали, покр$снели, ск?льзить, ц$рит, вып$дает";
        text = text.Replace('$', 'а');
        text = text.Replace('?', 'о');
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Выводимое константное сообщение...");
        Console.WriteLine(text);
        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть окно...");
        Console.ReadKey(true);
    }
}
