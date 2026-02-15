// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public class LibraryFineCalculator
{
    public static void Main(string[] args)
    {
        List<(char, int, char)> lateItems = new List<(char, int, char)>
        {
            ('B', 5, 'R'),
            ('B', 5, 'S'),
            ('D', 2, 'R'),
            ('D', 10, 'R'),
            ('J', 50, 'R'),
            ('J', 7, 'S')
        };

        foreach (var item in lateItems)
        {
            DisplayFine(item.Item2, item.Item3, item.Item1);
        }

    }


    static void DisplayFine(int days, char userType, char itemType)
    {
        string iType = GetItemType(itemType);
        string uType = GetUserType(userType);
        double fine = CalculateFine(days, userType, itemType);
        double fineRate = GetFineRate(itemType);
        Console.WriteLine("------------");
        Console.WriteLine($"item type: {iType}");
        Console.WriteLine($"user type: {uType}");
        Console.WriteLine($"days late: {days}");
        Console.WriteLine($"daily fine rate: {fineRate}");
        if (fine == 0.00)
        {
            Console.WriteLine("Within Grace Period");
        }
        else
        {
            Console.WriteLine($"fine: {fine}");
        }
        Console.WriteLine("------------");
    }


    static double CalculateFine(int days, char userType, char itemType)
    {
        if (days <= 3) return 0.00;

        double fineRate = GetFineRate(itemType);
        days -= 3;
        double fine = fineRate * days;

        double maxFine = 20.00;
        if (fine > maxFine)
        {
            fine = maxFine;
        }

        if (userType == 'S')
        {
            fine -= (fine * 0.50);
        }

        return Math.Round(fine, 2);
    }


    static string GetUserType(char type) => type switch
    {
        'S' => "Student",
        'R' => "Regular",
        _ => "Invalid"
    };


    static string GetItemType(char type) => type switch
    {
        'B' => "Book",
        'D' => "DVD",
        'J' => "Journal",
        _ => "Invalid"
    };


    static double GetFineRate(char type) => type switch
    {
        'B' => 0.50,
        'D' => 1.00,
        'J' => 0.25,
        _ => 0.00
    };
}