/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        Array.Sort(nums);
        int length = 1;
        int i = 0, j = 1;
        while (j < nums.Length)
        {
            if (nums[i] == nums[j])
                j++;
            else
            {
                length++;
                nums[i + 1] = nums[j];
                i++;
                j++;
            }
        }
        return length;
    }
}
// @lc code=end

