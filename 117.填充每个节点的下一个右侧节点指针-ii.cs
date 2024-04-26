/*
 * @lc app=leetcode.cn id=117 lang=csharp
 *
 * [117] 填充每个节点的下一个右侧节点指针 II
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        var que = new Queue<Node>();
        if (root == null) return root;
        que.Enqueue(root);//根节点入队
        while (que.Count != 0)//队列不为空
        {
            var size = que.Count;
            Node nodepre = new Node();
            Node node = new Node();
            for (int i = 0; i < size; i++)
            {
                
                if(i == 0) 
                {
                    nodepre = que.Dequeue();
                    node = nodepre;
                }
                else
                {
                    node = que.Dequeue();
                    nodepre.next = node; // 本层前一个节点next指向本节点
                    nodepre = nodepre.next;
                }
                if (node.left != null) que.Enqueue(node.left);
                if (node.right != null) que.Enqueue(node.right);
            }

        }
        return root;
    }
}
// @lc code=end

