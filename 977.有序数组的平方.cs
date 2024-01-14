/*
 * @lc app=leetcode.cn id=977 lang=csharp
 *
 * [977] 有序数组的平方
 */

// @lc code=start
public class Solution {
    public int[] SortedSquares(int[] nums) {
        int i=0;//左指针
        int j=nums.Length-1;//右边指针
        int[] newnum = new int[nums.Length];
        int k = nums.Length-1;
        while (i<=j)
        {
            if (nums[i]*nums[i]<nums[j]*nums[j])
            {
                newnum[k] = nums[j]*nums[j];
                j--;
            }
            else
            {
                newnum[k] = nums[i]*nums[i];
                i++;
            }
            k--;
        }
        return newnum;

    }
}
// @lc code=end

