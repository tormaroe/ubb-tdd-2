
namespace Ubb.Calculator;

public class Calculator
{
    public int Add(string v)
    {
        return string.IsNullOrWhiteSpace(v)
            ? 0
            : v.Split(',').Select(x => int.Parse(x.Trim())).Sum();
    }
}