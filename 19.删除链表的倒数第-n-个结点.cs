/*
 * @lc app=leetcode.cn id=19 lang=csharp
 *
 * [19] 删除链表的倒数第 N 个结点
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(-1,head);//涉及到删除，使用虚拟头结点更加方便
        ListNode slowIndex = dummy;
        ListNode fastIndex = dummy;
        for (int i = 0; i < n; i++)
        {
            fastIndex = fastIndex.next;
        }
        while (fastIndex.next!=null)
        {
            fastIndex = fastIndex.next;
            slowIndex = slowIndex.next;
        }
        slowIndex.next = slowIndex.next.next;
        return dummy.next;
    }
}
// @lc code=end

