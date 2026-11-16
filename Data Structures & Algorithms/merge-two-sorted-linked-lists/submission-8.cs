public class Solution {
    // [1,2,4] + [1,3,5] = [1,1,2,3,4,5]
    // Iteration 0:  l1=[1,2,4] l2=[1,3,5]
    // ITEARTION 1:  l1=[2,4]   l2=[1,3,5]
    // ITEARTION 2:  l1=[2,4]   l2=[3,5]
    // ITERATION 3:  l1=[4]     l2=[3,5]
    // ITERATION 4:  l1=[4]     l2=[5]
    // 4.next = 5
    // 3.next = 4
    // 2.next = 3
    // 1a.next = 2
    // 1b.next = 1
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var dummy = new ListNode();
        var tail = dummy;   
        
        while (list1 is not null && list2 is not null)
        {
            tail.next = list1.val <= list2.val ? list1 : list2;
            
            if (list1.val <= list2.val) list1 = list1.next;
            else list2 = list2.next;
            
            tail = tail.next;
        }
        
        tail.next = list1 ?? list2;
        
        return dummy.next;
    }
}