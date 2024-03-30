/*
 * @lc app=leetcode.cn id=1047 lang=csharp
 *
 * [1047] 删除字符串中的所有相邻重复项
 */

// @lc code=start
public class Solution {
    public string RemoveDuplicates(string s) {
        StringBuilder res = new StringBuilder();
        foreach (var c in s)
        {
            if(res.Length > 0 && res[res.Length-1] == c)
            {
                //当前字符和栈顶字符相同，则弹出栈顶的
                res.Remove(res.Length-1,1);//起始位置和字符数
            }
            else
            {
                res.Append(c);
            }
        }
        return res.ToString();
        //String是不可变类，StringBuilder是可变类。 string本身是不可改变的，它只能赋值一次，每一次内容发生改变，都会生成一个新的对象，然后原有的对象引用新的对象，而每一次生成新对象都会对系统性能产生影响，这会降低. NET编译器的工作效率。
    }
}
//也可以用双指针法
// @lc code=end

