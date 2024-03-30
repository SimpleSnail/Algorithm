/*
 * @lc app=leetcode.cn id=150 lang=csharp
 *
 * [150] 逆波兰表达式求值
 */

// @lc code=start
public class Solution {
public int EvalRPN(string[] tokens) 
{
    int num;
    Stack<int> stack = new Stack<int>();
    foreach(string s in tokens)
    {
        if(int.TryParse(s, out num))//将字符串转换成整数，并存储在num中
        //也可以把加减乘除放前面 这样就不用判断是否为数字了
        {
            stack.Push(num);
        }
        else
        {
            //取出两个数
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            switch (s)
            {
                case "+":
                    stack.Push(num1 + num2);
                    break;
                case "-":
                    stack.Push(num2 - num1);
                    break;
                case "*":
                    stack.Push(num1 * num2);
                    break;
                case "/":
                    stack.Push(num2 / num1);
                    break;
                default:
                    break;
            }
        }
    }
    return stack.Pop(); //出栈最后剩下的元素
    }
}
//逆波兰表达式相当于是二叉树中的后序遍历。 可以把运算符作为中间节点，按照后序遍历的规则画出一个二叉树
// @lc code=end

