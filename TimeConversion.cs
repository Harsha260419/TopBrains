using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter total seconds: ");
        if (int.TryParse(Console.ReadLine(), out int totalSeconds) && totalSeconds >= 0)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            string formatted = $"{minutes}:{seconds:D2}";
            Console.WriteLine(formatted);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
