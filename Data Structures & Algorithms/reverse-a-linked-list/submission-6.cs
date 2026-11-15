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
    public ListNode ReverseList(ListNode head) {
        if (head is null) return null;
        if (head.next is null) return head;

        var next = ReverseList(head.next);
        head.next.next = head;
        head.next = null;

        return next;
    }
}
