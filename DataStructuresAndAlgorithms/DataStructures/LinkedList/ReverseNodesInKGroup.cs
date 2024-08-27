/*
Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.

k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.

You may not alter the values in the list's nodes, only nodes themselves may be changed.

 

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [2,1,4,3,5]
Example 2:


Input: head = [1,2,3,4,5], k = 3
Output: [3,2,1,4,5]

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
public class ReverseKGroup
{
    public ListNode reverseLinkedList(ListNode head,int k){
        ListNode new_head = null; 
        ListNode ptr = head; 
        while (k > 0) { 

            ListNode next_node = ptr.next; 
            ptr.next = new_head; 
            new_head = ptr; 
            ptr = next_node; 
            k--; 

        } 

        return new_head; 
    }
    public ListNode ReverseKGroupCal(ListNode head, int k) {
        ListNode temp=head;
        ListNode newhead=null;
        ListNode tail=null;
        while(temp!=null){
            int count=0;
            temp=head;
            while(count<k && temp!=null){
                temp=temp.next;
                count++;
            }
            if(count==k){
                ListNode revhead=reverseLinkedList(head,k);
                if(newhead==null){
                    newhead=revhead;
                }
                if(tail!=null)
                    tail.next=revhead;
                tail=head;
                head=temp;
            }
        }
        if(tail!=null)
            tail.next=head;
        
        return newhead==null?head:newhead;
    }
}