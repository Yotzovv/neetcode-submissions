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
        var visitedNodes = new HashSet<ListNode>();
        
        var current = head;
        while (current is not null)
        {
            if (visitedNodes.Contains(current)) return true;
            
            visitedNodes.Add(current);
            current = current.next;
        }

        return false;
    }
}
