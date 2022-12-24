import javax.swing.tree.TreeNode;

/*
 * @lc app=leetcode id=100 lang=java
 *
 * [100] Same Tree
 */

// @lc code=start

class Solution {
    public boolean isSameTree(TreeNode p, TreeNode q) {
        
         return sameTree(p,q);          
        
    }

    private boolean sameTree(TreeNode p, TreeNode q)
    {
        if(p == null && q == null)
         return true;
    
        if(q == null || p == null)
         return false;

        if(p.val != q.val)
           return false;

        return (sameTree(p.left, q.left) && sameTree(p.right, q.right));

    }
}


// @lc code=end

