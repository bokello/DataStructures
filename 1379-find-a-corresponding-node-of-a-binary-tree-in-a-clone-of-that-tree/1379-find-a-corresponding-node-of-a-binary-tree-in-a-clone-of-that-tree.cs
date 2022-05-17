/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    
    TreeNode ans;
    TreeNode targetValue;
    
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        
        targetValue = target;
        inorder(original,cloned);
        return ans;
    }
    
    
    public void inorder(TreeNode o, TreeNode c)
    {
        if(o != null)
        {
            inorder(o.left, c.left);
            if(o == targetValue)
                ans = c;
            inorder(o.right, c.right);
        }
    }
}
