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
    public List<List<Integer>> levelOrder(TreeNode root) {
        
        List<List<Integer>> levels = new ArrayList<List<Integer>>();
        
        if(root == null)
            return levels;
        
        Queue<TreeNode> queue = new LinkedList<TreeNode>();
        queue.add(root);
                
        while(!queue.isEmpty())
        {        
            int queueSize = queue.size();
            List<Integer> currLevel = new ArrayList<Integer>();
                        
            for(int i=0;i < queueSize;i++)
            {
                TreeNode current = queue.poll();
                
                currLevel.add(current.val);
                
                if(current.left != null)
                    queue.add(current.left);
                    
                if(current.right != null)
                    queue.add(current.right);
                
            }
            
            levels.add(currLevel);
        
        }
        
        return levels;
        
    }
}