/*
 * @lc app=leetcode id=124 lang=java
 *
 * [124] Binary Tree Maximum Path Sum
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

    private int maxSum;

    public int maxPathSum(TreeNode root) {
        
        maxSum = Integer.MIN_VALUE;

        sumFromTree(root);
        
        return maxSum;
    }

    private int sumFromTree(TreeNode root)
    {

        if(root == null)
            return 0;

        int leftSum = Math.max(sumFromTree(root.left),0);

        int rightSum = Math.max(sumFromTree(root.right),0);

        maxSum = Math.max(maxSum, leftSum + rightSum + root.val);

        return Math.max((leftSum + root.val), (rightSum + root.val) );

    }


}
// @lc code=end

