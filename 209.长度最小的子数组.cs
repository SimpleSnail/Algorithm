/*
 * @lc app=leetcode.cn id=209 lang=csharp
 *
 * [209] 长度最小的子数组
 */

// @lc code=start
/// <summary>
/// 只用一个for循环，如果循环起始位置，会陷入双重for循环
/// 滑动窗口，窗口内为满足条件的最小连续子数组
/// </summary>
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left=0;
        int sum=0;
        int result=int.MaxValue;//因为要统计最小值，初始选个最大的
        int currentlength=0;
        for (int right = 0; right < nums.Length; right++)
        {
            sum+=nums[right];
            while (sum>=target)
            {
                currentlength = right-left+1;
                result = result<currentlength?result:currentlength;
                sum -= nums[left];
                left++;
            }
        }
        return result<int.MaxValue?result:0;
    }
}
// @lc code=end
