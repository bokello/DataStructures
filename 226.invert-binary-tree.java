/*
 * @lc app=leetcode id=226 lang=java
 *
 * [226] Invert Binary Tree
 */

// @lc code=start
class Solution {
    public TreeNode invertTree(TreeNode root) {
 
        if(root == null)
          return root;

        TreeNode left = invertTree(root.left);
        TreeNode right = invertTree(root.right);
        root.left = right;
        root.right = left;

        return root;

    }
}

// @lc code=end

