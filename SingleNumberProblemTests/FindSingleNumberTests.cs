using SingleNumber;
using SingleNumberAlgorithm;

namespace SingleNumberTests;

public class FindSingleNumberTests
{
    private ISingleNumberFinder _singleNumberFinder;
    [SetUp]
    public void Setup()
    {
        _singleNumberFinder = new SingleNumberFinder();
    }
    
    [Test]
    public void SingleNumber_ShouldReturn1()
    {
        int[] nums = { 1 };

        int result = _singleNumberFinder.FindSingleNumber(nums);

        int expected = 1;
        
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void SingleNumber_ShouldReturn2()
    {
        int[] nums = { 4, 1, 4, 1, 2 };

        int result = _singleNumberFinder.FindSingleNumber((nums));

        int expected = 2;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void SingleNumber_ShouldReturn3()
    {
        int[] nums = { 2, 2, 3 };

        int result = _singleNumberFinder.FindSingleNumber((nums));

        int expected = 3;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void SingleNumber_ShouldReturnNegative4()
    {
        int[] nums = { -1, -1, -3, -3, -2, -2, -4 };

        int result = _singleNumberFinder.FindSingleNumber((nums));

        int expected = -4;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void SingleNumber_ShouldReturnZero()
    {
        int[] nums = { 0, 1, 2, 1, 2 };

        int result = _singleNumberFinder.FindSingleNumber((nums));

        int expected = 0;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void SingleNumber_ShouldReturnAHundred()
    {
        int[] nums = { 5, 5, 10, 10, 20, 20, 30, 30, 40, 40, 50, 50, 60, 60, 70, 70, 80, 80, 90, 90, 100 };

        int result = _singleNumberFinder.FindSingleNumber((nums));

        int expected = 100;
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void SingleNumber_ShouldReturnNegative5()
    {
        int[] nums = { -10, -10, -5, -3, -3, -1, -1, -2, -2 };

        int result = _singleNumberFinder.FindSingleNumber((nums));

        int expected = -5;
        Assert.That(expected, Is.EqualTo(result));
    }
    
    [Test]
    public void SingleNumber_ArrayWithPairs_ShouldReturnReturnZero()
    {
        int[] nums = { 1, 1, 2, 2 };
        
        Assert.Throws<InvalidOperationException>(() => _singleNumberFinder.FindSingleNumber((nums)));
    }
    
    [Test]
    public void SingleNumber_EmptyArray_ShouldThrowError()
    {
        int[] nums = { };
        
        Assert.Throws<InvalidOperationException>(() => _singleNumberFinder.FindSingleNumber((nums)));
    }
}
