/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l=0;
        int r= nums.Length;
        int mid;
        while (l<r)
        {
            mid = (r-l)/2+l;
            if(nums[mid] == target )
            {
                return mid;
            }
            else if(nums[mid]>target)
            {
                r=mid;
            }
            else if(nums[mid]<target)
            {
                l=mid+1;
            }
        }
        return r;//return l也行
    }
}//或者用二分搜索的左侧边界法
// @lc code=end

