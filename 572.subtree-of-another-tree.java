/*
 * @lc app=leetcode id=572 lang=java
 *
 * [572] Subtree of Another Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public boolean isSubtree(TreeNode root, TreeNode subRoot) {
        
          if(root == null)
            return false;
        
          if(isSame(root,subRoot))
            return true;

        return isSubtree(root.left, subRoot) || isSubtree(root.right, subRoot);
        
    }

    private boolean isSame(TreeNode p, TreeNode q)
    {

        if(p == null || q == null)
           return p == null && q == null;


        return p.val == q.val && isSame(p.left,q.left) && isSame(p.right,q.right);
    }
}
// @lc code=end

