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
    
    private int countGoodNodes = 0;
    
    public int GoodNodes(TreeNode root) {
        
        if(root == null)
            return countGoodNodes;
        
        dfs(root,Int32.MinValue);        
        
        return countGoodNodes;
    }
    
    private void dfs(TreeNode root,int maxValue)
    {
        
        if(maxValue <= root.val)
            countGoodNodes++;
        
        if(root.left != null)
        dfs(root.left, Math.Max(root.val, maxValue));
        
        if(root.right != null)
        dfs(root.right, Math.Max(root.val, maxValue));
        
    }
    
    
}







