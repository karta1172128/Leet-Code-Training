/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> left = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                left.Push(s[i]);
            else
            {
                if (left.Count < 1)
                    return false;
                if (!match(left.Pop(), s[i]))
                    return false;
            }
        }
        if (left.Count > 0)
            return false;
        return true;
    }
    private bool match(char a, char b)
    {
        string s = a.ToString() + b.ToString();
        if (s == "()" || s == ")(" || s == "[]" || s == "][" || s == "{}" || s == "}{")
            return true;
        return false;
    }
}
// @lc code=end

