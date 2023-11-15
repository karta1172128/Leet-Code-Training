/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        char[] chars = s.ToCharArray();
        List<char> reg = new List<char>();
        int max = 0, index = 0;
        while (index < chars.Length)
        {
            if (reg.Count > 0)
            {
                if (reg.Contains(chars[index]))
                {
                    if (max < reg.Count)
                        max = reg.Count;
                    reg.Clear();
                    index = reg.IndexOf(chars[index]) + 1;
                    continue;
                }
            }
            reg.Add(chars[index]);
            index++;
        }
        if (max < reg.Count)
            max = reg.Count;
        reg.Clear();
        return max;
    }
}
// @lc code=end

