/*
 * @lc app=leetcode.cn id=160 lang=csharp
 *
 * [160] 相交链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode p1 = headA;
        ListNode p2 = headB;
        while (p1!=p2)//循环终止条件：指针相等
        {
            if (p1 == null)
            {
                p1 = headB;//p1走到末尾，链表A接上链表B
            }
            else
            {
                p1 = p1.next;//向后移动
            }
            if (p2 == null)
            {
                p2 = headA;//p2走到末尾，链表B接上链表A
            }
            else
            {
                p2 = p2.next;//向后移动
            }
        }
        return p1;
    }
}
//方法二：计算两个链表长度差，然后长的链表上指针先走，走了长度差的长度后一起走
// @lc code=end

