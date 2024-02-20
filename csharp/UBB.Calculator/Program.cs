namespace Ubb.Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(new Calculator().Add(string.Join(" ", args)));
    }
}
