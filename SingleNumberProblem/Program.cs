using SingleNumber;
using SingleNumberAlgorithm;

internal class Program
{
    static void Main(string[] args)
    {
        var singleNum = new SingleNumberFinder();
        Console.WriteLine(singleNum.FindSingleNumber( new []{1, 2, 2, 3, 1,3,4,4}));
    }
}