/*
 * @lc app=leetcode.cn id=541 lang=csharp
 *
 * [541] 反转字符串 II
 */

// @lc code=start
// public class Solution {
//     public string ReverseStr(string s, int k) {
//         char[] array= s.ToCharArray();
//         for (int i = 0; i < array.Length; i+=2*k)
//         {
//             ReverseString(array,i , i + k-1<array.Length-1?i+k-1:array.Length-1);
//             //注意i+k要减一
//         }
//         return new string(array);//不能用ToString 会返回类型名称，要用string类构造函数
//     }
//     public void ReverseString(char[] s,int l,int r) {

//         while (l < r)
//         {
//             (s[l],s[r]) = (s[r],s[l]);
//             l++;
//             r--;
//         }
//     }
// }
public class Solution
{
    public string ReverseStr(string s, int k)
    {
        Span<char> span = s.ToCharArray().AsSpan();
        for (int i = 0; i < span.Length; i += 2 * k)
        {
            span[i + k < span.Length ? i..(i + k) : i..].Reverse();
        }
        return span.ToString();
    }
}
// @lc code=end

