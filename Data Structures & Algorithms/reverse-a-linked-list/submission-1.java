/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */

class Solution {
    public ListNode reverseList(ListNode head) {
        ListNode node = head;
        if (head == null){
            return head;
        }
        ListNode ans = rev (head, head.next);
        head.next = null;
        return ans;
    }
    public ListNode rev(ListNode first, ListNode second){
        if (second == null)
        {
            return first;
        }
        ListNode temp = second.next;
        second.next = first;
        return rev(second, temp);
    }
}
