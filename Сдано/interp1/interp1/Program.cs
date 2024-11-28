using System;

class Program
{
    static void Main()
    {
        string Federalnoe = "В";
        string Gosudarstcennoe = "году";
        int Budgetnoe = 12;
        string Obrazovatelnoe = "месяцев";
        char Uchrezhdenie = 'и';
        char Vysshego = 'в';
        string Obrazovaniya = "каждом";
        char Rossiyskiy = '–';
        string Universitet = "свои";
        string Transporta = "ягоды";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine($"{Federalnoe} {Gosudarstcennoe} {Budgetnoe} {Obrazovatelnoe}" +
            $" {Uchrezhdenie} {Vysshego} {Obrazovaniya} {Rossiyskiy} {Universitet} {Transporta}");
        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть окно...");
        Console.ReadKey(true);
    }
}
