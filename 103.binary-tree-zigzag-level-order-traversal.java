import java.util.LinkedList;
import java.util.Queue;

import javax.swing.tree.TreeNode;

/*
 * @lc app=leetcode id=103 lang=java
 *
 * [103] Binary Tree Zigzag Level Order Traversal
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
    public List<List<Integer>> zigzagLevelOrder(TreeNode root) {
        
        Queue<TreeNode> queue = new LinkedList<TreeNode>();
        List<List<Integer>> result =  new ArrayList<List<Integer>>();
        Boolean even = true;

        if(root == null)
          return result;

        queue.add(root);

         while(!queue.isEmpty())
         {
              int n = queue.size();
              LinkedList<Integer> lst = new LinkedList<>();

               for(int i=0;i < n; i++)
               {
                   TreeNode top = queue.poll();
                   
                   if(top.left != null)
                     queue.add(top.left);

                   if(top.right != null)
                     queue.add(top.right);

                   if(even)
                      lst.add(top.val);
                   else
                      lst.addFirst(top.val);

                   
               }

               result.add(lst);
               even = !even;
              
         }


         return result;

    }
}
// @lc code=end

