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
    public int KthSmallest(TreeNode root, int k) {
         List<int> nums = inorder(root, new List<int>());
            return nums.ToArray()[k-1];
    }
    
    
    public List<int> inorder(TreeNode root, List<int> arr) {
            if (root == null) 
                return arr;
            
            inorder(root.left, arr);
            arr.Add(root.val);
            inorder(root.right, arr);
        
            return arr;
       }
}