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
    public int RangeSumBST(TreeNode root, int low, int high) {
     
        int sum = 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count != 0)
        {
            TreeNode current = queue.Dequeue();
            
            if(current.val >= low && current.val <= high)
             sum += current.val;
            
            if(current.left != null && current.val > low)
            queue.Enqueue(current.left);
            
            if(current.right != null && current.val < high)
            queue.Enqueue(current.right);
            
            
        }
        
        return sum;
    }
}