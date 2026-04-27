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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0) return null;
         for (int i = 1; i < lists.Length; i++) {
            lists[i] = Merge(lists[i], lists[i - 1]);
        }
        return lists[lists.Length - 1];
    }
    private ListNode Merge(ListNode l1, ListNode l2){
        ListNode dummy = new ListNode(0);
        ListNode p = dummy;

        int i = 0;
        while (l1 != null && l2 != null){
            if(l1.val < l2.val){
                p.next = l1;
                l1 = l1.next;
            }
            else{
                p.next = l2;
                l2 = l2.next;
            }
            p = p.next;
        }
        while (l1 != null){
            p.next = l1;
            p = p.next;
            l1 = l1.next;
        }
        while (l2 != null){
            p.next = l2;
            p = p.next;
            l2 = l2.next;
        }
        return dummy.next;
    }
}
