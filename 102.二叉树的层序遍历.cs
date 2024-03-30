/*
 * @lc app=leetcode.cn id=102 lang=csharp
 *
 * [102] 二叉树的层序遍历
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res = new List<IList<int>>();//存储结果
        var que = new Queue<TreeNode>();//二叉树节点类型的队列
        if (root == null) return res;//空树
        que.Enqueue(root);//根节点进队列
        while (que.Count != 0)
        {
            var size = que.Count;//上一层节点数
            var vec = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                vec.Add(cur.val);
                if (cur.left != null) que.Enqueue(cur.left);
                if (cur.right != null) que.Enqueue(cur.right);
            }
            res.Add(vec);


    }
    return res;

    }
}
//此题也可以用递归
// @lc code=end

