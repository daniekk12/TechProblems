using BracketBalancer;

public class Program
{
    static void Main(string[] args)
    {
        var bracketBalancer = new BracketBalancer.BracketBalancer();
        Console.Write( bracketBalancer.IsBalanced("{[(  [])]}") );
    }
}