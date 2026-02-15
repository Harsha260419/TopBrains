using System;
using System.Collections.Generic;

class ParkingFeeCalculator 
{
    static void Main() 
    {
        Console.WriteLine("=== PARKING FEE CALCULATOR ===\n");

        var records = new List<(char Type, double Hours)> 
        {
            ('C', 2.5),
            ('C', 12.0),
            ('M', 4.0),
            ('T', 6.5),
            ('C', 0.25),
            ('M', 10.0)
        };

        foreach (var (type, hours) in records) 
        {
            ShowReceipt(type, hours);
            Console.WriteLine(new string('-', 25));
        }
    }

    static void ShowReceipt(char type, double hours) 
    {
        double rate = GetRate(type);
        double cap = GetMax(type);
        double total = Calculate(hours, rate, cap);

        Console.WriteLine($"Vehicle: {GetName(type)}");
        Console.WriteLine($"Duration: {hours:F2} hrs");
        Console.WriteLine($"Rate: ${rate:F2}/hr");
        Console.WriteLine($"Total: ${total:F2}");
    }

    static double Calculate(double hours, double rate, double max) 
    {
        if (hours <= 0.5) return 0;

        double fee = (hours - 0.5) * rate;
        
        if (fee > max) fee = max;

        if (hours > 8) 
        {
            fee -= (max * 0.1);
        }

        return Math.Max(0, fee);
    }

    static double GetRate(char type) => type switch {
        'C' => 3.0,
        'M' => 2.0,
        'T' => 5.0,
        _ => 0
    };

    static double GetMax(char type) => type switch {
        'C' => 25.0,
        'M' => 15.0,
        'T' => 40.0,
        _ => 0
    };

    static string GetName(char type) => type switch {
        'C' => "Car",
        'M' => "Motorcycle",
        'T' => "Truck",
        _ => "Other"
    };
}
