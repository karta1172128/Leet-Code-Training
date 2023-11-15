/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
public class Solution
{
    public int MyAtoi(string s)
    {
        bool isNumStart = false;
        Char[] chars = s.ToCharArray();
        s = "";
        bool positive = true;
        bool sign = false;
        int num = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (!isNumStart)
            {
                if ((int)chars[i] >= 48 && (int)chars[i] <= 57)
                {
                    isNumStart = true;
                    if ((int)chars[i] != 48)
                    {
                        s += chars[i];
                        num++;
                    }
                }
                else if ((chars[i] != '+' && chars[i] != '-' && chars[i] != ' ') || chars[i] == '.')
                    return 0;
                else if (chars[i] == '-')
                    positive = !positive;
                if (!sign)
                {
                    if (chars[i] == '-' || chars[i] == '+')
                        sign = true;
                }
                else if (!((int)chars[i] >= 48 && (int)chars[i] <= 57))
                    return 0;
            }
            else if ((int)chars[i] >= 48 && (int)chars[i] <= 57)
            {
                if ((int)chars[i] == 48 && num < 1)
                    continue;
                num++;
                if (num > 10)
                    if (positive)
                        return int.MaxValue;
                    else
                        return int.MinValue;
                s += chars[i];
            }
            else
                break;
        }
        if (s == "")
            return 0;
        chars = s.ToCharArray();
        int value;
        if (num == 10)
        {
            s = "";
            int first = int.Parse(chars[9].ToString());
            for (int i = 0; i < 9; i++)
                s += chars[i];
            value = int.Parse(s);
            if (positive)
            {
                if (value > int.MaxValue / 10)
                    value = int.MaxValue;
                else if (value < int.MaxValue / 10 || first < int.MaxValue % 10)
                    value = value * 10 + first;
                else
                    value = int.MaxValue;
            }
            else
            {
                if (value > MathF.Abs(int.MinValue / 10))
                    value = int.MinValue;
                else if (value < MathF.Abs(int.MinValue / 10) || first < MathF.Abs(int.MinValue % 10))
                    value = -1 * (value * 10 + first);
                else
                    value = int.MinValue;
            }
        }
        else
        {
            if (positive)
                value = int.Parse(s);
            else
                value = int.Parse(s) * -1;
        }
        return (int)value;
    }
}
// @lc code=end

