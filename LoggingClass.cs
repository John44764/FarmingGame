namespace LoggingClass;

public class Log
{
    public static void Debug(string debugMessage)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Debug: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(debugMessage);
    }
            
    public static void Error(string errorMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(errorMessage);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(":End Exception");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
            
    public static void Exeption(Exception exception)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Exception: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(exception);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(":End Exception");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}