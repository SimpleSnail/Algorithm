/*
 * @lc app=leetcode.cn id=199 lang=csharp
 *
 * [199] 二叉树的右视图
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
    public IList<int> RightSideView(TreeNode root) {
        var res = new List<int>();
        var que = new Queue<TreeNode>();
        if (root == null) return res;
        que.Enqueue(root);
         while (que.Count != 0)
        {
            var size = que.Count;
            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                if(i == size-1) res.Add(cur.val);
                if (cur.left != null) que.Enqueue(cur.left);
                if (cur.right != null) que.Enqueue(cur.right);
            }
        }
        return res;
    }
}
// @lc code=end

