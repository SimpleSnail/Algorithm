/*
 * @lc app=leetcode.cn id=142 lang=csharp
 *
 * [142] 环形链表 II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode slow,fast;
        slow=fast=head;
        while(fast !=null && fast.next != null)
        {
            fast = fast.next.next;//跳两个，所以只要到fast.next==null就要停了
            slow = slow.next;
            if (fast == slow) //快慢指针会相遇，有环，继续判断入口
            {
                slow = head;
                while (slow!=fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return  slow;
            }
        }
        return null;
    }
}
// @lc code=end

