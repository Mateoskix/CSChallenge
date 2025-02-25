public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode fnode = new(0,head);
        ListNode prev = fnode;
        ListNode curr = head;
        ListNode temp = null;
        ListNode next = null;

        for(int i = 1; i<left ; i++){
            prev = curr;
            curr = curr.next;
        }

        for(int i = 0; i< right-left+1; i++){
            next = curr.next;
            curr.next = temp;
            temp = curr;
            curr = next;
        }

        prev.next.next = curr;
        prev.next = temp;

        return fnode.next;
    }
}