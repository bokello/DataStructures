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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
               
        ListNode dummy = new ListNode();
		dummy.next = head;
        
        ListNode p1 = dummy;
        ListNode p2 = dummy;
        
        for(int i=0; i <= n;i++)
          p2 = p2.next;
        
        while(p2 !=null)
        {
            p2 = p2.next;
            p1 = p1.next;            
        }
        
        p1.next = p1.next.next;
        return dummy.next;
        
        
    }
}