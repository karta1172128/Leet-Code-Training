/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        int orin = x, convert = 0;
        while (x > 0)
        {
            convert = 10 * convert + x % 10;
            x /= 10;
        }
        if (orin == convert)
            return true;
        else
            return false;
    }
}
// @lc code=end

