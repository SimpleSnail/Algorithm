/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
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
    public bool IsSymmetric(TreeNode root) {
        return Compare(root.left,root.right);
    }
    public bool Compare(TreeNode left, TreeNode right) 
    {
        if (left == null && right == null) return true;
        else if (left != null && right == null) return false;
        else if (left == null && right != null) return false;
        else if(left.val != right.val) return false;
        var outside = Compare(left.left, right.right);
        var inside = Compare(left.right,right.left);
        return inside && outside ;
    }
}
// @lc code=end

