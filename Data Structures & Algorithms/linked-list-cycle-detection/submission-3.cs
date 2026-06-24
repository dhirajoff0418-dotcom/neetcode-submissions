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
    public bool HasCycle(ListNode head) {
       ListNode Fast=head;
       ListNode Slow=head;
       while(Fast != null && Fast.next != null){
            Slow=Slow.next;
            Fast=Fast.next.next;
            if(Fast==Slow){
                return true;
            }
       } 
       return false;
    }
}
