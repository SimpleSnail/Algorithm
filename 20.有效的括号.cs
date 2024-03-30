/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        if (s.Length%2 != 0) return false;
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
              stack.Push(')');  
            }
            else if(s[i] == '[')
            {
                stack.Push(']');
            }
            else if(s[i] == '{')
            {
                stack.Push('}');
            }
            //右边的括号数量大于左边的，还没遍历完栈空了 或者 遇到错误匹配的情况 字符串元素和栈顶元素不相同
            else if(stack.Count == 0 || stack.Pop() != s[i]) return false;
        }
        if(stack.Count > 0) return false;
        return true;
    }
}
// @lc code=end

