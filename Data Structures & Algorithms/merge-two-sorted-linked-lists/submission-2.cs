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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null)
        { return list1; }
        if (list1 == null)
        { return list2; }
        if (list2 == null)
        { return list1; }
        
        ListNode newList = list1;
        ListNode head = list1;
        if(list2.val < list1.val){                
                newList = list2;
                head = list2;
                list2 = list2.next;
            }
            else{
                list1 = list1.next;
            }
        
        while(list1 != null && list2 != null){
            if(list2.val < list1.val){                
                newList.next = list2;
                list2 = list2.next;
            }
            else{
                newList.next = list1;
                list1 = list1.next;
            }
            newList = newList.next;
        }
        if(list1 == null){
            newList.next = list2;
        }
        else{
            newList.next = list1;
        }
        return head;
    }
}