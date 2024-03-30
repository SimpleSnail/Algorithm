/*
 * @lc app=leetcode.cn id=637 lang=csharp
 *
 * [637] 二叉树的层平均值
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
    public IList<double> AverageOfLevels(TreeNode root) {
        var res = new List<double>();
        var que = new Queue<TreeNode>();
        if (root == null) return res;
        que.Enqueue(root);
        double s = 0;
         while (que.Count != 0)
        {   
            var size = que.Count;
            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                s = s + cur.val;
                if (cur.left != null) que.Enqueue(cur.left);
                if (cur.right != null) que.Enqueue(cur.right);
            }
            res.Add(s/size);
            s = 0;
        }
        return res;


    }
}
// @lc code=end

