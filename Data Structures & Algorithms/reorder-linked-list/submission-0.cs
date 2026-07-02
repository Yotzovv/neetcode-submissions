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

public class Solution
{
    public void ReorderList(ListNode head)
    {
        Console.Clear();
        var middle = FindMiddle(head);
        var reversedRight = ReverseLinkedList(middle);
        
        ListNode left = head;
        ListNode right = reversedRight;
        
        while (right.next is not null && left.next is not null)
        {
            ListNode nextLeft = left.next;
            ListNode nextRight = right.next;
            
            left.next = right;
            if (nextLeft == right || left == right)
            {
                right.next = null;
                break;
            }
            
            right.next = nextLeft;
            
            left = nextLeft;
            right = nextRight;
        }
        
        PrintList(head);
        
    }

    private ListNode? FindMiddle(ListNode head)
    {
        var fast = head;
        var slow = head;

        int iteration = 0;
        
        while (fast is not null and { next: not null })
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return slow;
    }

    private static ListNode? ReverseLinkedList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while (current is not null)
        {
            ListNode next = current.next;

            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    public void PrintList(ListNode head)
    {
        Console.WriteLine();
        while (head is not null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }

        // Console.ReadKey();
    }
}

