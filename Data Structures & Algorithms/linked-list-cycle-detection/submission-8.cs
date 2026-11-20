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
        var visitedNodes = new Dictionary<ListNode, bool>();
        
        var current = head;
        while (current is not null)
        {
            Console.WriteLine(current.val);

            if (visitedNodes.ContainsKey(current)) return true;
            else visitedNodes[current] = true;
            
            current = current.next;
        }

        return false;
    }
}
