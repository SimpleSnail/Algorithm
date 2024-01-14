/*
 * @lc app=leetcode.cn id=707 lang=csharp
 *
 * [707] 设计链表
 */

// @lc code=start


public class MyLinkedList {

        int size;//链表长度
        ListNode head;//虚拟头结点
    
        public MyLinkedList(){
            size = 0;
            head = new ListNode(0);
        }
    
    
    public int Get(int index) {
        if (index<0||index>=size)
        return -1;
        ListNode current = head;
        for (int i = 0; i <= index; i++)
        {
            current = current.next;
        }
        return current.val;

    }
    
    public void AddAtHead(int val) {
        AddAtIndex(0,val);
    }
    
    public void AddAtTail(int val) {
        AddAtIndex(size,val);
    }
    
    public void AddAtIndex(int index, int val) {
        if (index>size)//注意这里不包含等于
        return;
        index = Math.Max(0,index);
        ListNode current = head;
        for (int i = 0; i < index; i++)//注意这里只遍历到index前的一个元素
        {
            current= current.next;
        }
        ListNode node = new ListNode(val);
        var temp = current.next;
        current.next = node;
        node.next = temp;
        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index<0||index>=size)
        return;
        ListNode current = head;
        for (int i = 0; i < index; i++)//注意这里也只遍历到index前的一个元素
        {
            current= current.next;
        }
        current.next = current.next.next;//删除结点
        size--;
    }
}

class ListNode{
    public int val;
     public ListNode next;
    public ListNode(int val){
        this.val = val;
    }
}
/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
// @lc code=end

