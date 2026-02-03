using System;
using NUnit.Framework;

[TestFixture] 
public class UnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        Program account = new Program(100m);
        account.Deposit(50m);

        Assert.AreEqual(150m, account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Program account = new Program(100m);

        var ex = Assert.Throws<Exception>(() => account.Deposit(-20m));

        Assert.AreEqual("Deposit amount cannot be negative", ex.Message);
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        Program account = new Program(200m);
        account.Withdraw(50m);

        Assert.AreEqual(150m, account.Balance);
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Program account = new Program(100m);

        var ex = Assert.Throws<Exception>(() => account.Withdraw(150m));

        Assert.AreEqual("Insufficient funds.", ex.Message);
    }
}

public class Program
{
    public decimal Balance { get; private set; }

    // Constructor
    public Program(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Deposit amount cannot be negative");
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Insufficient funds.");
        }

        Balance -= amount;
    }

    public static void Main(string[] args)
    {
        Program account = new Program(1000m);

        account.Deposit(500m);
        Console.WriteLine("Balance after deposit: " + account.Balance);

        account.Withdraw(300m);
        Console.WriteLine("Balance after withdrawal: " + account.Balance);
    }
}
