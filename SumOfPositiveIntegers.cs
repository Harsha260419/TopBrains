using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        string[] parts = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
            nums[i] = int.Parse(parts[i]);

        long sum = 0;

        foreach (int num in nums){
            if (num == 0) break;
            if (num < 0) continue;
            sum += num;
        }

        Console.WriteLine(sum);
    }
}
