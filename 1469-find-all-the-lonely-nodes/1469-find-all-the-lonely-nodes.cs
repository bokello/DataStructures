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
    public IList<int> GetLonelyNodes(TreeNode root) {
        
        IList<int> result = new List<int>();   
        
        result = getNodes(root,new List<int>());
        
        return result;
        
    }
    
    private List<int> getNodes(TreeNode root, List<int> myList)
    {
            if(root == null)
              return myList;
        
            if(root.left != null && root.right == null)
              myList.Add(root.left.val);
        
            if(root.left == null && root.right != null)
              myList.Add(root.right.val);
        
           
             getNodes(root.left,myList);
             getNodes(root.right,myList);
                
              return myList;
    }
    
}