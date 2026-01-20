using System;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        string result = Evaluate(expression);
        Console.WriteLine(result);
    }

    static string Evaluate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ');
        if (parts.Length != 3)
            return "Error:InvalidExpression";

        string aStr = parts[0];
        string op = parts[1];
        string bStr = parts[2];

        if (op != "+" && op != "-" && op != "*" && op != "/")
            return "Error:UnknownOperator";

        if (!int.TryParse(aStr, out int a) || !int.TryParse(bStr, out int b))
            return "Error:InvalidNumber";

        if (op == "/" && b == 0)
            return "Error:DivideByZero";

        int result;
        switch (op)
        {
            case "+":
                result = a + b;
                break;
            case "-":
                result = a - b;
                break;
            case "*":
                result = a * b;
                break;
            case "/":
                result = a / b;
                break;
            default:
                return "Error:UnknownOperator";
        }

        return result.ToString();
    }
}
