/*
 * @lc app=leetcode.cn id=24 lang=csharp
 *
 * [24] 两两交换链表中的节点
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
    public ListNode SwapPairs(ListNode head) {
        ListNode dummy = new ListNode (-1,head);//虚拟头结点
        ListNode cur =dummy;
        ListNode pre = cur.next;
        ListNode temp;
        while (cur.next!=null&&cur.next.next!=null)
        {
            temp = pre.next.next;//temp的变化
            cur.next = pre.next;
            cur.next.next = pre;
            pre.next = temp;
            cur = pre;
            pre = cur.next;//cur和pre需要变化
        }
        return dummy.next;
    }
}
// @lc code=end

