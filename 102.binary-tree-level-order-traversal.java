import java.util.LinkedList;
import java.util.Queue;

import javax.swing.tree.TreeNode;

/*
 * @lc app=leetcode id=102 lang=java
 *
 * [102] Binary Tree Level Order Traversal
 */

// @lc code=start
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
        
         List<List<Integer>> result = new ArrayList<List<Integer>>();

         if(root == null)
           return result;

         Queue<TreeNode> queue = new LinkedList<TreeNode>();

         queue.add(root);

         while(!queue.isEmpty())
         {
              int queueSize = queue.size();
              List<Integer> res = new ArrayList<>();
             
              for(int i=0;i < queueSize;i++)
              {
                    TreeNode currentNode = queue.poll();
                    res.add(currentNode.val);

                    if(currentNode.left != null)
                        queue.add(currentNode.left);

                    if(currentNode.right != null)
                        queue.add(currentNode.right);
                  
              }

              result.add(res);
         }



         return result;

    }
}
// @lc code=end

