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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Dummy node banaya hai.
        // Isse first node handle karna easy ho jata hai.
        ListNode dummy = new ListNode(-1);

        // Tail merged list ke last node ko point karega.
        // Initially ye dummy par hi hai.
        ListNode tail = dummy;

        // Jab tak dono lists me nodes hain
        while (list1 != null && list2 != null) {
            // Agar list1 ki value chhoti ya equal hai
            if (list1.val <= list2.val) {
                // list1 ka current node merged list me jod do
                tail.next = list1;

                // list1 ko next node par le jao
                list1 = list1.next;
            } else {
                // list2 ka current node merged list me jod do
                tail.next = list2;

                // list2 ko next node par le jao
                list2 = list2.next;
            }

            // Tail ko naye last node par move karo
            tail = tail.next;
        }

        // Agar list1 me abhi bhi nodes bache hain
        if (list1 != null)
            // Unhe directly attach kar do
            tail.next = list1;
        else
            // Warna list2 ke remaining nodes attach kar do
            tail.next = list2;

        // Dummy fake node tha.
        // Actual merged list dummy.next se start hoti hai.
        return dummy.next;
    }
}