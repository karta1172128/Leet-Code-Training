/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] merge = nums1.Concat(nums2).ToArray();
        Array.Sort(merge);
        if (merge.Length % 2 == 0)
        {
            return (double)(merge[merge.Length / 2] + merge[merge.Length / 2 - 1]) / 2;
        }
        else
            return merge[(merge.Length - 1) / 2];
    }
}
// @lc code=end

