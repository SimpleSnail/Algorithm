/*
 * @lc app=leetcode.cn id=18 lang=csharp
 *
 * [18] 四数之和
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        
        var result = new List<IList<int>>();//注意返回类型要一致
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i++)
        {
            long n1 = nums[i];
            if (i > 0 && n1 == nums[i - 1])
                continue;//剪枝，跳出本轮循环

            for (int j = i + 1; j < nums.Length - 2; j++)//仍是双指针 相对于三数之和加一层循环
            {
                long n2 = nums[j];
                if (j > i + 1 && n2 == nums[j - 1])//第一次不跳过，之后如果前一项相同就跳，记住比前不比后，比后会错跳本次符合条件的
                    continue;

                int left = j + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    long n3 = nums[left];
                    long n4 = nums[right];
                    long sum = n1 + n2 + n3 + n4;

                    if (sum > target)
                    {
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        //result.Add(new List<int> { n1, n2, n3, n4 });
                        result.Add(new List<int> { (int)n1, (int)n2, (int)n3, (int)n4 });//转化回int


                        while (left < right && nums[left] == n3)//对left去重
                        {
                            left++;
                        }

                        while (left < right && nums[right] == n4)//对right去重
                        {
                            right--;
                        }
                    }
                }
            }
        }

        return result;


    }
}
// @lc code=end

