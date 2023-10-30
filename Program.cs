using System;

class Program
{
    // Driver Code
    public static void Main(String[] args)
    {
        var test = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        //"eat","tea","tan","ate","nat","bat"
        //"eat", "tea", "tan", "ate", "nat", "bat"
        var result = Solution.GroupAnagrams(test);
    }


}
//IList<IList<string>> result = new List<IList<string>>();
public class Solution
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> result = new List<IList<string>>();

        foreach(var word in strs)
        {
            if(result.Count == 0)
            {
                result.Add(new List<string>() { word });
                continue;
            }

            var isWordAdded = false;
            foreach(var setOfAnagrams in result)
            {
                if(isAnagrams(setOfAnagrams[0], word))
                {
                    setOfAnagrams.Add(word);
                    isWordAdded = true;
                    break;

                }
            }

            if (!isWordAdded)
            {
                result.Add(new List<string>() { word });
            }


        }

        return result;

        static bool isAnagrams(string old, string current)
        {
            if(old.Length != current.Length)
            {
                return false;
            }
            if(old == current)
            {
                return true;
            }
            var len = old.Length;
            for (int i = 0; i < len; i++)
            {
                if (old.Contains(current[i]))
                {
                    var index = old.IndexOf(current[i]);
                    old = old.Remove(index, 1);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}

