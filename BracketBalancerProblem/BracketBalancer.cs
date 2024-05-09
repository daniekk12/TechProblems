using System.Text.RegularExpressions;

namespace BracketBalancer;

public class BracketBalancer : IBracketBalancer
{ 
    public bool IsBalanced(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return true;
        }
        input = input.Replace(" ", "");
        if (!ContainsOnlyBrackets(input))
        {
            return false;
        }
        if (input.Length % 2 != 0)
        {
            return false;
        }
        Stack<char> temp = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1 && !IsOrderRespected(input[i], input[i + 1]))
            {
                return false;
            }
        
            if (IsOpeningBracket(input[i]))
            {
                temp.Push(input[i]);
                continue;
            }

            if (temp.Count == 0)
            {
                return false; 
            }
            
            char lastChar = temp.Pop();
            if (!IsMatchingBrackets(lastChar, input[i]))
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsOrderRespected(char lastChar, char nextChar)
    {
        var bracketsOrder = new Dictionary<char, int>
        {
            {'{', 1},
            {'[', 3},
            {'(', 5}
        };
        
        if (bracketsOrder.TryGetValue(nextChar, out int nextCharOrder) && bracketsOrder.TryGetValue(lastChar, out int lastCharOrder))
        {
            return bracketsOrder[lastChar] < bracketsOrder[nextChar];
        }
        return true;
    }



    private static bool IsOpeningBracket(char c)
    {
        if ( c == '{' || c == '[' || c == '(')
        {
            return true;
        }
        return false;
    }

    private static bool IsMatchingBrackets(char open, char close)
    {
        if (open == '{' && close == '}')
        {
            return true;
        }
        if (open == '[' && close == ']')
        {
            return true;
        }
        if (open == '(' && close == ')')
        {
            return true;
        }
        return false;
    }
    private static bool ContainsOnlyBrackets(string input)
    {
        foreach (char c in input)
        {
            if (c != '{' && c != '}' && c != '[' && c != ']' && c != '(' && c != ')')
            {
                return false;
            }
        }
        return true;
    }

}