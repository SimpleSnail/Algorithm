/*
 * @lc app=leetcode.cn id=111 lang=csharp
 *
 * [111] 二叉树的最小深度
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
    public int MinDepth(TreeNode root) {
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
                if (cur.left == null && cur.right == null)  return  depth;
            }

        }
        return depth;
    }
}
/*
递归法
        if (root == NULL) return 0;
        if (root->left == NULL && root->right != NULL) {
            return 1 + minDepth(root->right);
        }
        if (root->left != NULL && root->right == NULL) {
            return 1 + minDepth(root->left);
        }
        return 1 + min(minDepth(root->left), minDepth(root->right));
*/
// @lc code=end

