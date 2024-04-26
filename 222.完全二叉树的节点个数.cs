/*
 * @lc app=leetcode.cn id=222 lang=csharp
 *
 * [222] 完全二叉树的节点个数
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
    public int CountNodes(TreeNode root) {
        return GetNodenumber(root);
    }
    public int GetNodenumber(TreeNode cur) 
    {
        if (cur == null) return 0;
        return 1+GetNodenumber(cur.left)+GetNodenumber(cur.right);
    }
}
// @lc code=end

