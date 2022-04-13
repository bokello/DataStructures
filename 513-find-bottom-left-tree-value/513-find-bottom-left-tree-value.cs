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
    
    private int maxLevel = -1;
    private int leftMostValue = 0;
    
    public int FindBottomLeftValue(TreeNode root) {
        
        dfs(root,0); 
        return leftMostValue;
        
    }
    
    public void dfs(TreeNode root, int level)
    {        
        if(root == null)
             return;
     
        if(maxLevel < level)
        {
            maxLevel = level;
            leftMostValue = root.val;
        }        
        
        dfs(root.left, level+1 );
        dfs(root.right, level+1 );        
    }
}