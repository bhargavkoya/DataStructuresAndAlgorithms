/*
Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.

 

Example 1:


Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]
Example 2:

Input: head = [], val = 1
Output: []
Example 3:

Input: head = [7,7,7,7], val = 7
Output: []


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
public class RemoveElements
{
    public ListNode RemoveElementsCal(ListNode head, int val) {
        ListNode dummy =new ListNode(-1,head);
        ListNode prev = dummy;
        while(head!=null){
            if(head.val !=val)
                prev = head;
            else
                prev.next = head.next;
            head = head.next;
        }
        return dummy.next;

    }
}