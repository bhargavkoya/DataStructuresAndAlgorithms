/*
Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:


Input: head = [1,1,1,2,3]
Output: [2,3]

*/
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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        while((current!=null) && (current.next!=null)){
            if(current.val == current.next.val){
                while((current.next!=null) && (current.val == current.next.val)){
                    current = current.next;
                }
                
                if(prev==null)
                    head = current.next;
                else
                    prev.next = current.next;
                
                current = current.next;
                }
            else{
                if(prev==null)
                    prev = current;
                else
                    prev = prev.next;
                
                current = current.next;
                }
            }
        return head;

    }
}