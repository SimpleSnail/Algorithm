/*
 * @lc app=leetcode.cn id=206 lang=csharp
 *
 * [206] 反转链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode pre = null;
        ListNode temp = null;
        while (current!=null)
        {
            temp = current.next;
            current.next = pre;
            pre = current;
            current = temp;
        }
        return pre;//此处注意
        //也可以不用current,直接用head循环，因为这里需要反转链表，不需要靠head找链表了
    }
}
// @lc code=end

