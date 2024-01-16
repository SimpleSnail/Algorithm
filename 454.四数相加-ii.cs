/*
 * @lc app=leetcode.cn id=454 lang=csharp
 *
 * [454] 四数相加 II
 */

// @lc code=start
public class Solution 
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) 
    {
        Dictionary<int,int> dic = new Dictionary<int, int> ();
        foreach (var i in nums1)
        {
            foreach (var j in nums2)
            {
                int sum = i+j;
                if (dic.ContainsKey(sum))dic[sum]++;//两数之和出现次数加一
                else
                {
                    dic.Add(sum,1);
                }
            }
        }
        int res = 0;
        foreach (var a in nums3)
        {
            foreach (var b in nums4)
            {
                
                if (dic.ContainsKey(-a-b))
                {
                    res += dic[-a-b];
                }
            }
        }
        return res;
    }
}
// @lc code=end

