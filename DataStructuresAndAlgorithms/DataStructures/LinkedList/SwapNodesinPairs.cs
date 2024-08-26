/*
Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

 

Example 1:


Input: head = [1,2,3,4]
Output: [2,1,4,3]
Example 2:

Input: head = []
Output: []
Example 3:

Input: head = [1]
Output: [1]

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
    public ListNode SwapPairs(ListNode head) {
        if(head==null || head.next==null)
            return head;
        ListNode dummy_node =new ListNode(-1, head);
        ListNode prev_node = dummy_node;
        
        
        while(head!=null  && head.next!=null){
            
            ListNode first_node = head;
            ListNode second_node = head.next;
            
           //swapping
            prev_node.next = second_node;
            first_node.next = second_node.next;
            second_node.next = first_node;
            
            prev_node = first_node;
            head = first_node.next;
        }
        
        return dummy_node.next;

    }
    
    
}