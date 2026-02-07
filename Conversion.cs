using System;

public class Program
{
    public static void Main()
    {
        int feet = int.Parse(Console.ReadLine());
        if (feet >= 0 && feet <= 1000000)
        {
            double centimeters = Math.Round(feet * 30.48, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine(centimeters);
        }
    }
}
