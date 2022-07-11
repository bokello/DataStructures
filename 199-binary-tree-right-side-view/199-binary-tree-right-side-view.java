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
    public List<Integer> rightSideView(TreeNode root) {
        
        if(root == null)
            return new ArrayList<Integer>();
        
        ArrayDeque<TreeNode> BST = new ArrayDeque(){{offer(root); }};
        ArrayList<Integer> result = new ArrayList<Integer>();
        
        while(BST.size() != 0)
        {
            int queueSize = BST.size();
            
            for(int i=0;i < queueSize;i++)
            {
                TreeNode current = BST.poll();
                
                if(i== queueSize - 1)
                    result.add(current.val);

                if(current.left != null)
                    BST.add(current.left);

                if(current.right != null)
                    BST.add(current.right);
            }
             
        }
        
        
        return result;
        
    }
}