/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int need = target-nums[i];
            if (dictionary.ContainsKey(need))//最后加上&&dictionary[need]!=i
            {
                return new int[]{dictionary[need],i};
            }
            else
            {
                dictionary[nums[i]] = i;
                //dictionary.Add(nums[i],i);
            }
        }
        return new int[]{0,0};
    }
}
// @lc code=end

