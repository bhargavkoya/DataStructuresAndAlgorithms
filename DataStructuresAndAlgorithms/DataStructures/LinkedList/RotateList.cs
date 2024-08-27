/*
Given the head of a linked list, rotate the list to the right by k places.

 

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:


Input: head = [0,1,2], k = 4
Output: [2,0,1]

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
public class RotateRight
{
    public ListNode RotateRightCal(ListNode head, int k) {
       if(head==null)
           return head;
        
        int length=1;
        ListNode tail=head;
        while(tail.next!=null){
            length++;
            tail=tail.next;
        }
        
        k=k%length;
        
        if(k==0)
            return head;
        
        //Moving to pivot
        ListNode curr=head;
        for(int i=0;i<length-k-1;i++){
            curr=curr.next;
        }
        
        ListNode newnode=curr.next;
        curr.next=null;
        tail.next=head;
        
        return newnode;
        
        
    }
}