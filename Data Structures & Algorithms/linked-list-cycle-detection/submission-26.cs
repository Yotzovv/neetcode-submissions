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
    public bool HasCycle(ListNode head)
    {
        if (head is null) return false;
        if (head.next is null) return false;
        if (head.next.next is null) return false;
        
        var slow = head;
        var fast = head.next.next;

        while (fast is not null)
        {
            if (fast == slow) return true;
            
            slow = slow.next;
            fast = fast.next?.next;
        }
        
        return false;
    }
}
