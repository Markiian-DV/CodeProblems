// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void Main()
    {
        var a = new []{ "()()()()", "()()(())", "()(()())", "()((()))", "()(())()", "(()()())", "(()(()))", "((()()))", "(((())))", "((())())", "(()())()", "((()))()", "(())()()" };
        var b = new[] { "(((())))", "((()()))", "((())())", "((()))()", "(()(()))", "(()()())", "(()())()", "(())(())", "(())()()", "()((()))", "()(()())", "()(())()", "()()(())", "()()()()" };

        //"()()()()","()()(())","()(()())","()((()))","()(())()","(()()())","(()(()))","((()()))","(((())))","((())())","(()())()","((()))()","(())()()" --out[ut

        //"(((())))","((()()))","((())())","((()))()","(()(()))","(()()())","(()())()","(())(())","(())()()","()((()))","()(()())","()(())()","()()(())","()()()()" --expected
        var r = GenerateParenthesis(5);
    }

    public static IList<string> GenerateParenthesis(int n)
    {
        if(n == 1)
        {
            return new string[] { "()" };
        }
        else
        {
            var prev = GenerateParenthesis(n - 1);
            var result = prev.Select(x => $"({x})")
                             .Concat(prev.Select(x => $"(){x}"))
                             .Concat(prev.Select(x => $"{x}()"));
            return result.Distinct().ToList();
        }
    }
}

