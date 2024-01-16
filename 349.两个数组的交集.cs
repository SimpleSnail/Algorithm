/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */

// @lc code=start
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        if(nums1 == null || nums1.Length == 0 || nums2 == null || nums2.Length == 0) return new int[0];
        HashSet<int> hashSet1 = Insert(nums1);
        HashSet<int> hashSet2 = Insert(nums2);
        
//C# HashSet无重复性、无序性，使用哈希表实现
        HashSet<int> Insert(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
             foreach (var num in nums)
            {
                hash.Add(num);
            }
            return hash;
        }
        hashSet1.IntersectWith(hashSet2);//取交集
        return hashSet1.ToArray();


    }
}
// @lc code=end

