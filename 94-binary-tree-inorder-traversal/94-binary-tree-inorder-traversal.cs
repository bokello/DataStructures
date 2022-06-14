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
    public IList<int> InorderTraversal(TreeNode root) {
        
              List<int> result = new List<int>();
              helper(root,result);
              return result;
    }
    
     public void helper(TreeNode tree, List<int> result)
         {
            if(tree!= null)
            {
                // add left tree
                if(tree.left != null)
                    helper(tree.left,result);
                                    
                // add root node
                result.Add(tree.val);

                //add right tree
                if(tree.right != null)
                   helper(tree.right,result);                
            }             
         }
}