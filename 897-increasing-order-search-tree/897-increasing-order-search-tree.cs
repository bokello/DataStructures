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
    
    private List<int> values = new List<int>();
    
    public TreeNode IncreasingBST(TreeNode root) 
    {
       inOrder(root);      
       
       TreeNode ans = new TreeNode();
       TreeNode cur = ans;
        
       foreach(int val in values)
       {
           cur.right = new TreeNode(val);
           cur = cur.right;
       }
      
       return ans.right;
        
    }
    
    private void inOrder(TreeNode root)
    {
        if(root == null)
            return;
        
        inOrder(root.left);
        values.Add(root.val);
        inOrder(root.right);        
    }
}