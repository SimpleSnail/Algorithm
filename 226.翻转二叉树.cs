/*
 * @lc app=leetcode.cn id=226 lang=csharp
 *
 * [226] 翻转二叉树
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        var que = new Queue<TreeNode>();
        if (root == null) return null;
        que.Enqueue(root);//根节点入队
        while (que.Count != 0)//队列不为空
        {
            var size = que.Count;

            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                (cur.left,cur.right) = (cur.right,cur.left);
                if (cur.left != null) que.Enqueue(cur.left);
                if (cur.right != null) que.Enqueue(cur.right);
            }

        }
        return root;
    }
}
// @lc code=end

