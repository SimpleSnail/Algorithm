/*
 * @lc app=leetcode.cn id=704 lang=csharp
 *
 * [704] 二分查找
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length;
        int mid;
        while (l<r)
        {
            mid=(r-l)/2+l;
            if (nums[mid]==target)
            {
                return mid;
            }
            else if(nums[mid]<target)
            {
                l=mid+1;
            }
            else
            {
                r=mid;
            }
        }
        return -1;
    }
    
}
// @lc code=end

