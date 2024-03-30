/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();//List实例，其中元素是IList<int>接口类型实例
        Array.Sort(nums);//从小到大先排序

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int n1 = nums[i];

            if (n1 > 0)
                break;

            if (i > 0 && n1 == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int n2 = nums[left];
                int n3 = nums[right];
                int sum = n1 + n2 + n3;

                if (sum > 0)
                {
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    result.Add(new List<int> { n1, n2, n3 });

                    while (left < right && nums[left] == n2)
                    {
                        left++;
                    }//对b去重

                    while (left < right && nums[right] == n3)
                    {
                        right--;
                    }//对c去重
                }
            }
        }

        return result;

    }
}
// @lc code=end

//本题用哈希法麻烦 设计元组的去重