/*
 * @lc app=leetcode.cn id=104 lang=csharp
 *
 * [104] 二叉树的最大深度
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
    public int MaxDepth(TreeNode root) {
        int depth = 0;
        var que = new Queue<TreeNode>();
        if (root == null) return depth;
        que.Enqueue(root);//根节点入队
        while (que.Count != 0)//队列不为空
        {
            depth++;
            var size = que.Count;

            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                if (cur.left != null) que.Enqueue(cur.left);
                if (cur.right != null) que.Enqueue(cur.right);
            }

        }
        return depth;

    }
}
// @lc code=end

