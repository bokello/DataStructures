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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
                
        return construct(nums,0, nums.Length);
        
    }
    
    private TreeNode construct(int[] nums,int left, int right)
    {
      if(left == right)
          return null;
        
      int max_i = findMax(nums, left, right);
      TreeNode root = new TreeNode(nums[max_i]);
      root.left = construct(nums,left, max_i);
      root.right = construct(nums,max_i + 1, right);
        
      return root;        
    }    
    
    private int findMax(int[] numbers, int left, int right)
    {
        int max_i = left;
        
        for(int i=left; i < right; i++)
        {
            if(numbers[max_i] < numbers[i])
                max_i = i;
        }
        
        return max_i;
    }
    
}