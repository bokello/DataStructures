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
    public int GetMinimumDifference(TreeNode root) {
        
        List<int> inorderList = InOrder(root,new List<int>());
        
        int minDiff = FindMinimumDifference(inorderList);
        
        return minDiff;
        
    }
    
    private List<int> InOrder(TreeNode root, List<int> result)
    {
        if(root == null)
            return result;
        
        InOrder(root.left,result);
        result.Add(root.val);
        InOrder(root.right,result);
        
        return result;        
    }
    
    private int FindMinimumDifference(List<int> list)
    {
        int min = int.MaxValue;
        int[] arr = list.ToArray();
        
        
        for(int i=0; i + 1 < arr.Length; i++)
        {
            int diff = arr[i + 1] - arr[i];
            min = Math.Min(diff,min);
        }
        
        return min;
    }
    
    
    
}