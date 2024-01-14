/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int slowIndex=0;
        for (int fastIndex = 0; fastIndex < nums.Length; fastIndex++)
        {
            
            if (nums[fastIndex] == val)//相等情况下，只有快指针移动，慢指针不动，也不赋值
            {
                continue;
            }
            nums[slowIndex] = nums[fastIndex];
            slowIndex++;
        }
        return slowIndex;
        /*
        for (int fastIndex = 0; fastIndex < nums.Length; fastIndex++)
        {
            if (nums[fastIndex] ！= val)
            {
                nums[slowIndex] = nums[fastIndex];
                slowIndex++；
            }
        }
        */
    }
}
// @lc code=end

