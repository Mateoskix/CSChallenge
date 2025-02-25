public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode temp = null;
        while (head != null)
        {
            var next = head.next;
            head.next = temp;
            temp = head;
            head = next;
        }
        return temp;        
    }
}