/*
 * @lc app=leetcode.cn id=344 lang=csharp
 *
 * [344] 反转字符串
 */

// @lc code=start
public class Solution {
    public void ReverseString(char[] s) {
        int l = 0;
        int r = s.Length-1;
        while (l < r)
        {
            (s[l],s[r]) = (s[r],s[l]);
            l++;
            r--;
        }
    }
}
// @lc code=end

