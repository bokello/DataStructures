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
public class BSTIterator {

    List<int> sortedNodes;
    int index = -1;
    
    public BSTIterator(TreeNode root) {
        
        sortedNodes = new List<int>();
        _inorder(root);
    }
    
    private void _inorder(TreeNode root)
    {
        if(root == null)
            return;
        
        _inorder(root.left);
        sortedNodes.Add(root.val);
        _inorder(root.right);
    }
    
    public int Next() {
        return sortedNodes[++index];
    }
    
    public bool HasNext() {
        return index + 1 < sortedNodes.Count;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */