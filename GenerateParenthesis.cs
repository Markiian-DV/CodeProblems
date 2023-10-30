namespace codeProblems
{
    //https://leetcode.com/problems/generate-parentheses/
    public static class GenerateParenthesisSolution
    {
        public static IList<string> Solution(int n)
        {
            var res = new List<string>();

            GenerateParenthesis(n * 2, 0, true, "", res, 0, 0);
            return res.Distinct().ToList();
        }

        public static void GenerateParenthesis(int maxIteration, int iteration, bool left, string tmpResult, List<string> results, int leftCount, int rightCount)
        {
            if (leftCount < rightCount)
            {
                return;
            }

            if (iteration == maxIteration)
            {
                if (leftCount == rightCount)
                {
                    results.Add(tmpResult);
                }
                return;
            }

            if (left)
            {
                tmpResult += "(";
                leftCount++;
            }
            else
            {
                tmpResult += ")";
                rightCount++;
            }

            GenerateParenthesis(maxIteration, iteration + 1, true, tmpResult, results, leftCount, rightCount);
            GenerateParenthesis(maxIteration, iteration + 1, false, tmpResult, results, leftCount, rightCount);
        }
    }
}
