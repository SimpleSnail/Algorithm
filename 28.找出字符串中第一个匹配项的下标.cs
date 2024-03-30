/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 找出字符串中第一个匹配项的下标
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        int i = 0; 
        int j = 0;
        int[] next = GetNext(needle);

        while (i < haystack.Length && j < needle.Length)
        {
            if (j == -1 || haystack[i] == needle[j]) 
            {
                i++;
                j++;
            }
            else 
                j = next[j];
        }

        if (j == needle.Length)
           return i - j;
        else 
           return -1;
    }

    private int[] GetNext(string needle)
    {
        int[] next = new int[needle.Length];
        next[0] = -1;
        int i = 0, j = -1;

        while (i < needle.Length - 1)
        {
            if (j == -1 || needle[i] == needle[j])
            {
                i++;
                j++;
                next[i] = j;
            }
            else
                j = next[j];
        }

        return next;
    }
}
// @lc code=end

