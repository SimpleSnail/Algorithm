/*
 * @lc app=leetcode.cn id=515 lang=csharp
 *
 * [515] 在每个树行中找最大值
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
    public IList<int> LargestValues(TreeNode root) {
        var res = new List<int>();
        var que = new Queue<TreeNode>();
        if (root == null) return res;
        que.Enqueue(root);
        while (que.Count != 0)
        {
            var size = que.Count;
            int max = int.MinValue;
            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                max = max > cur.val?max:cur.val;
                if (cur.left != null) que.Enqueue(cur.left);
                if (cur.right != null) que.Enqueue(cur.right);
            }
            res.Add(max);
        }
        return res;

    }
}
// @lc code=end

