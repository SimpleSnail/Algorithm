/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 */

// @lc code=start
public class MyStack {
    Queue<int> queue1;
    Queue<int> queue2;
   

    public MyStack() 
    {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }
    
    public void Push(int x) 
    {
        queue1.Enqueue(x);
    }
    
    public int Pop() 
    {
        if(queue1.Count != 0){
            int count1 =  queue1.Count-1;
            for (int i = 0; i < count1; i++)
            {
                queue2.Enqueue(queue1.Dequeue());
            }

            int j = queue1.Dequeue();
            int count2 =  queue2.Count;
            for (int i = 0; i < count2; i++)
            {
                queue1.Enqueue(queue2.Dequeue());
            }
            return j;
        }
        else return -1;
    }
    
    public int Top() 
    {
        if(queue1.Count != 0)
        {
            int count1 =  queue1.Count-1;
            for (int i = 0; i < count1; i++)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            int j = queue1.Peek();
            
            queue2.Enqueue(queue1.Dequeue());
            (queue1,queue2) = (queue2,queue1);
            
            return j;
        }
        else return -1;
    }
    
    public bool Empty() {
        return queue1.Count == 0;
    }
}


/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

