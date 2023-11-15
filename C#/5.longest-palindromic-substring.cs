/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution
{
    public string LongestPalindrome(string s)
    {
        char[] chars = s.ToCharArray();
        if (chars.Length < 2)
            return s;
        int max = 0, indexHead = 0, indexEnd = 0;
        for (int i = 0; i < chars.Length - 1; i++)
        {
            int left = i, right = i;
            if (chars.Length - i - 1 <= max / 2)
                break;
            while (right < chars.Length - 1 && chars[right] == chars[right + 1])
                right++;
            while (right < chars.Length - 1 && left > 0 && chars[right + 1] == chars[left - 1])
            {
                right++;
                left--;
            }
            if (max < right - left + 1)
            {
                max = right - left + 1;
                indexHead = left;
                indexEnd = right;
            }
        }
        string lp = "";
        for (int i = indexHead; i < indexEnd + 1; i++)
            lp += chars[i];
        return lp;
    }
}
// @lc code=end

