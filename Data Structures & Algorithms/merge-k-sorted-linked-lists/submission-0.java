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
    public ListNode mergeKLists(ListNode[] lists) {
        if(lists.length == 0){
            return null;
        }
        ListNode arr = mergeSort(lists, 0, lists.length - 1);
        return arr;
    }
    private ListNode mergeSort(ListNode[] lists, int start, int end){
        if(start == end){
            return lists[end];
        }

        int mid = (end + start) / 2;
        ListNode left = mergeSort(lists, start, mid);
        ListNode right = mergeSort(lists, mid + 1, end);
        ListNode arr = merge(right, left);
        return arr;
    }
    private ListNode merge(ListNode right, ListNode left){
        ListNode merged = new ListNode(-1);
        ListNode head = merged;
        if(right != null && left != null){
            while(right != null && left != null){
                if(right.val <= left.val){
                    merged.next = right;
                    ListNode temp = right.next;
                    right.next = null;
                    right = temp;
                }
                else{
                    merged.next = left;
                    ListNode temp = left.next;
                    left.next = null;
                    left = temp;
                }
                merged = merged.next;
            }
            if(right == null){
                merged.next = left;
            }
            if(left == null){
                merged.next = right;
            }
        }
        else if(right == null){
            return left;
        }
        else if(left == null){
            return right;
        }
        return head.next;
    }
}
