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
        ListNode temp = null;
        ListNode tempNew = null;
        while(node != null){
            temp = node.next;
            node.next = tempNew;            
            tempNew = node;
            node = temp;
        }
        return tempNew;
    }
}
