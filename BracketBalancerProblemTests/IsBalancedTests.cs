using BracketBalancer;

namespace BracketBalanceTests;

public class Tests
{
    private IBracketBalancer _bracketBalancerR;

    [SetUp]
    public void Setup()
    {
        _bracketBalancerR = new BracketBalancer.BracketBalancer();
    }

    [Test]
    public void IsBalanced_BalancedInput_ReturnsTrue()
    {
        string balancedInput = "{[()]}";

        bool result = _bracketBalancerR.IsBalanced(balancedInput);

        Assert.IsTrue(result);
    }

    [Test]
    public void IsBalanced_UnbalancedInput_ReturnsFalse()
    {
        string unbalancedInput = "{[(])}";

        bool result = _bracketBalancerR.IsBalanced(unbalancedInput);

        Assert.IsFalse(result);
    }

    [Test]
    public void IsBalanced_EmptyInput_ReturnsTrue()
    {
        string emptyInput = "";

        bool result = _bracketBalancerR.IsBalanced(emptyInput);

        Assert.IsTrue(result);
    }

    [Test]
    public void IsBalanced_BalancedInputWithSpace_ReturnsTrue()
    {
        string balancedInput = "{[(  )]}";

        bool result = _bracketBalancerR.IsBalanced(balancedInput);

        Assert.IsTrue(result);
    }

    [Test]
    public void IsBalanced_UnbalancedInputWithLetter_ReturnsFalse()
    {
        string unbalancedInput = "{[(a)]}";

        bool result = _bracketBalancerR.IsBalanced(unbalancedInput);

        Assert.IsFalse(result);
    }

    [Test]
    public void IsBalanced_UnbalancedWithJustClosingBracket_ReturnsFalse()
    {
        string unbalancedInput = "}])";

        bool result = _bracketBalancerR.IsBalanced(unbalancedInput);

        Assert.IsFalse(result);
    }

    [Test]
    public void IsBalanced_UnbalancedInputWithWrongOrder_ReturnsFalse()
    {
        string unbalancedInput = "{[)]}";

        bool result = _bracketBalancerR.IsBalanced(unbalancedInput);

        Assert.IsFalse(result);
    }
    
    [Test]
    public void IsBalanced_UnbalancedInputWithExtraOpeningBrackets_ReturnsFalse()
    {
        string unbalancedInput = "{[(())}";

        bool result = _bracketBalancerR.IsBalanced(unbalancedInput);

        Assert.IsFalse(result);
    }

    [Test]
    public void IsBalanced_UnbalancedInputWithExtraClosingBrackets_ReturnsFalse()
    {
        string unbalancedInput = "{[()])}";

        bool result = _bracketBalancerR.IsBalanced(unbalancedInput);

        Assert.IsFalse(result);
    }
}