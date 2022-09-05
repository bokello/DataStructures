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
    public IList<int> PreorderTraversal(TreeNode root) {
        
                
        return preOrder(root, new List<int>());
        
        
    }
    
    private List<int> preOrder(TreeNode root, List<int> result)
    {
        if(root != null)
        {
           result.Add(root.val);
           preOrder(root.left, result);
           preOrder(root.right, result);            
        }
        
        return result;
    }
}