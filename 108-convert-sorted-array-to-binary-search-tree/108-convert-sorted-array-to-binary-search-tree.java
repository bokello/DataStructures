/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public TreeNode sortedArrayToBST(int[] nums) {
        
        if(nums.length == 0)
            return null;
        
        return ConvertArrayToTree(nums,0, nums.length-1);
        
    }
    
    public TreeNode ConvertArrayToTree(int[] arr , int left, int right)
    {
        if(left > right)
            return null;
        
        
        int midpoint = left + (right - left) / 2;
        
        TreeNode root = new TreeNode(arr[midpoint]);
        root.left = ConvertArrayToTree(arr,left,midpoint - 1);
        root.right = ConvertArrayToTree(arr,midpoint + 1,right);
        
        return root;
        
    }
    
}