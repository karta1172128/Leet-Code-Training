/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] Zigzag Conversion
 */

// @lc code=start
public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows < 2)
            return s;
        char[] chars = s.ToCharArray();
        int size = numRows * 2 - 2;
        string zigzag = "";
        for (int i = 0; i < numRows; i++)
        {
            for (int j = i; j < chars.Length; j += size)
            {
                zigzag += chars[j];
                if (i == 0 || i == numRows - 1)
                    continue;
                int pos = j + (numRows - 1 - i) * 2;
                if (pos < chars.Length)
                    zigzag += chars[pos];
            }
        }
        return zigzag;
    }
}
// @lc code=end

