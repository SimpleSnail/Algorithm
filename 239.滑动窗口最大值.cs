/*
 * @lc app=leetcode.cn id=239 lang=csharp
 *
 * [239] 滑动窗口最大值
 */

// @lc code=start
class myDequeue{
        private LinkedList<int> linkedList = new LinkedList<int>();

        public void Enqueue(int n){//压入队列

            while(linkedList.Count > 0 && linkedList.Last.Value < n)//元素大于等于队尾
            {
                linkedList.RemoveLast();//弹出队尾所有小于该链表元素的队列元素
            }
            linkedList.AddLast(n);//添加到队尾
        }

        public int Max()
        {
            return linkedList.First.Value;//返回双向链表的第一个元素的值
        }

        public void Dequeue(int n)
        {
            if(linkedList.First.Value == n)
            {
                linkedList.RemoveFirst();
            }   
        }
    }


public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        myDequeue window = new myDequeue();
        List<int> res = new List<int>();
        //单独处理前k个
        for(int i = 0; i < k; i++){
            window.Enqueue(nums[i]);
        }
        res.Add(window.Max());//List中加上当前窗口最大值
        for(int i = k; i < nums.Length; i++){
            window.Dequeue(nums[i-k]);
            window.Enqueue(nums[i]);//如果离开窗口的元素是最大值，就将其弹出
            res.Add(window.Max());
        }

        return res.ToArray();

    }
}
// @lc code=end

