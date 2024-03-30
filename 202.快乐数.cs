/*
 * @lc app=leetcode.cn id=202 lang=csharp
 *
 * [202] 快乐数
 */

// @lc code=start
public class Solution 
{
    public bool IsHappy(int n) 
    {
        HashSet<int> hashSet = new HashSet<int>();
        while (n != 1 && !hashSet.Contains(n))//不等于1
        {
            hashSet.Add(n);//先随便加一个，然后先计算和再看是否包含
            n = GetSum(n);//新的和如果在HashSet中出现过就退出循环
        }
        return n == 1;//可能为退出循环或者包含重复的退出循环
    }
    int GetSum(int a)
    {
        int sum = 0;
        while(a > 0)
        {
            sum += (a%10)*(a%10);
            a = a/10;
        }
        return sum;
    }
}
// @lc code=end

