class Program
{
    public static void Main()
    {
        Lab01.Run();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Press any key to exit...");
        Console.ResetColor();

        Console.ReadKey();
    }
}