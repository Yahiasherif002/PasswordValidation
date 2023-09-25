using System;
using System.Linq;

internal class Program
{
    static bool IsPasswordValid(string password)
    {
        return password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(IsPasswordValid("Hello123@"));
        Console.WriteLine(IsPasswordValid("hello123@"));
        Console.WriteLine(IsPasswordValid("HELLO123@"));
        Console.WriteLine(IsPasswordValid("Hello123"));
        Console.WriteLine(IsPasswordValid("Hello@"));



    }
}