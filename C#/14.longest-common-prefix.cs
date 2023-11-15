/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string s = "";
        bool stop = false;
        int minLength = strs[0].Length;
        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < minLength)
                minLength = strs[i].Length;
        }
        for (int i = 0; i < minLength; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j][i] != strs[j - 1][i])
                {
                    stop = true;
                    break;
                }
            }
            if (stop)
                break;
            s += strs[0][i];
        }
        return s;
    }
}
// @lc code=end

