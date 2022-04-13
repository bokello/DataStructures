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
 
   public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        
        
       var resultOne = FindLeaves(root1,new List<int>());
       var resultTwo = FindLeaves(root2,new List<int>());
                      
       return resultOne.ToArray().SequenceEqual(resultTwo.ToArray());
        
    }
    
    public List<int> FindLeaves(TreeNode root, List<int> result)
    {        
        if(root != null)
        {
            if(root.left == null && root.right == null)
                result.Add(root.val);        
            FindLeaves(root.left,result);
            FindLeaves(root.right,result);            
        }
        
        return result;        
    }
    
}