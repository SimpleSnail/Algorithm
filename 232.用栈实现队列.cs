/*
 * @lc app=leetcode.cn id=232 lang=csharp
 *
 * [232] 用栈实现队列
 */

// @lc code=start
public class MyQueue 
{

    
    Stack<int> inStack;
    Stack<int> outStack;

    //构造函数
    public MyQueue()
    {
        inStack = new Stack<int>();
        outStack = new Stack<int>();
    }

    
    public void Push(int x) 
    {
        inStack.Push(x);
    }
    
    public int Pop() 
    {
        dumpstackIn();
        return outStack.Pop();
    }
    
    public int Peek() 
    {
        dumpstackIn();
        return outStack.Peek();
    }
    
    public bool Empty() 
    {
        return inStack.Count == 0 && outStack.Count == 0;
    }
        // 处理方法：
    // 如果outStack为空，那么将inStack中的元素全部放到outStack中
    private void dumpstackIn()
    {
        if (outStack.Count != 0) return; //如果输出栈等于空，检查输入栈，若不为空
        while(inStack.Count != 0){//把所有输入栈元素打进输出栈
            outStack.Push(inStack.Pop());
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

