/*
 * @lc app=leetcode id=230 lang=java
 *
 * [230] Kth Smallest Element in a BST
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
    public int kthSmallest(TreeNode root, int k) {
        
        ArrayList<Integer> myList = inOrder(root, new ArrayList<Integer>());

        return myList.get(k-1);

    }

    private ArrayList<Integer> inOrder(TreeNode root, ArrayList<Integer> result)
    {
        if(root == null)
        return result;

        inOrder(root.left,result);
        result.add(root.val);
        inOrder(root.right,result);

        return result;
    }
}
// @lc code=end

