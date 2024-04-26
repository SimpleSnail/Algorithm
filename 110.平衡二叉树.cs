/*
 * @lc app=leetcode.cn id=110 lang=csharp
 *
 * [110] 平衡二叉树
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
    public bool IsBalanced(TreeNode root) {
        return GetHeight(root) == -1? false:true;
    }
    public int GetHeight(TreeNode root) 
    {
        if (root == null) {
            return 0;
        }
        int leftHeight = GetHeight(root.left);
        if (leftHeight == -1) {
            return -1;
        }
        int rightHeight = GetHeight(root.right);
        if (rightHeight == -1) {
            return -1;
        }
        // 左右子树高度差大于1，return -1表示已经不是平衡树了
        if (Math.Abs(leftHeight - rightHeight) > 1) {
            return -1;
        }
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
// @lc code=end

