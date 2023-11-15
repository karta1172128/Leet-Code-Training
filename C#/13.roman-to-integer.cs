/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        int integer = 0;
        int[] romanInteger = { 1, 5, 10, 50, 100, 500, 1000 };
        char[] roman = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        int[] romanIndex = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < roman.Length; j++)
            {
                if (s[i] == roman[j])
                {
                    romanIndex[i] = j;
                    break;
                }
            }
        }
        int index = 0;
        while (index < romanIndex.Length)
        {
            if (romanIndex[index] % 2 == 0 && index != romanIndex.Length - 1)
            {
                if (romanIndex[index] + 1 == romanIndex[index + 1] || romanIndex[index] + 2 == romanIndex[index + 1])
                {
                    integer -= romanInteger[romanIndex[index]];
                    integer += romanInteger[romanIndex[index + 1]];
                    index += 2;
                    continue;
                }
            }
            integer += romanInteger[romanIndex[index]];
            index++;
        }
        return integer;
    }
}
// @lc code=end

