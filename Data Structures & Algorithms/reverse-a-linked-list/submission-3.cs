public class Solution {
    public ListNode ReverseList(ListNode head)
    {
        
        ListNode prev = null;
        ListNode curr = head;

        while (curr is not null)
        {
            ListNode next = curr.next;
            curr.next = prev;

            prev = curr;    
            curr = next;
        }
        
        return prev;
    }
}
