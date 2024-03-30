/*
 * @lc app=leetcode.cn id=347 lang=csharp
 *
 * [347] 前 K 个高频元素
 */

// @lc code=start
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //哈希表统计元素出现频率
        Dictionary<int,int> dic = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i], 1);
            }
        }

        //优先队列-从小到大排列
        PriorityQueue<int,int> pq = new();//C#9.0语法
        foreach(var num in dic)
        {
            pq.Enqueue(num.Key, num.Value);
            //保留k个元素，小的弹出
            if(pq.Count > k){
                pq.Dequeue();
            }
        }
        //倒装存进数组
        int[] res = new int[k];
        for(int i = k - 1; i >= 0; i--){
            res[i] = pq.Dequeue();
        }
        return res;

    }
}
// @lc code=end

