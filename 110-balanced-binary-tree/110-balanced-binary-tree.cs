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
    public bool IsBalanced(TreeNode root) {
       if (root == null) 
           return true;
        
        return Math.Abs(height(root.left) - height(root.right)) < 2
        && IsBalanced(root.left)
        && IsBalanced(root.right);
                
    }
    
    
    private int height(TreeNode root) {
        // An empty tree has height -1
        if (root == null) 
          return -1;
    
       return 1 + Math.Max(height(root.left), height(root.right));
    }
}