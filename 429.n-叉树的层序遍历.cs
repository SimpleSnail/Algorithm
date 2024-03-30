/*
 * @lc app=leetcode.cn id=429 lang=csharp
 *
 * [429] N 叉树的层序遍历
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        var res = new List<IList<int>>();
        var que = new Queue<Node>();
        if (root == null) return res;
        que.Enqueue(root);
        while (que.Count != 0)
        {
            var size = que.Count;
            var vec = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                vec.Add(cur.val);
                foreach(var item in cur.children)
                {
                    que.Enqueue(item);
                }
            }
            res.Add(vec);
        }
        return res;
        
    }
}
// @lc code=end

