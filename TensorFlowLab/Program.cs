class Program
{
    public static void Main()
    {
        Lab02.Run();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
        Console.ResetColor();

        Console.ReadKey();
    }
}