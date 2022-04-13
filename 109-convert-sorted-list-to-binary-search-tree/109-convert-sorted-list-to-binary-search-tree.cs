/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    
    private List<int> result = new List<int>();
    
    public TreeNode SortedListToBST(ListNode head) {
        
        result = ConvertList(head);
        
        foreach(int x in result)
            Console.WriteLine(x);
        
        int[] arr = result.ToArray();               
        return ConvertBST(arr,0,arr.Length - 1);
        
    }
    
    private TreeNode ConvertBST(int[] arr,int left,int right)
    {                
        if(left > right)
            return null;
        
        int mid = left + (right - left) / 2;
        
        TreeNode root = new TreeNode(arr[mid]);
        root.left = ConvertBST(arr,left,mid-1);
        root.right = ConvertBST(arr,mid + 1,right);
        
        return root;
    }
    
    
    private List<int> ConvertList (ListNode head)
    {         
        while(head != null)
        {
           result.Add(head.val);
           head = head.next;
        }
        
        return result;
    }
    
    
}