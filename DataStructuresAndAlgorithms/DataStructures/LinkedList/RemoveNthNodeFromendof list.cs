/*
Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

Example 1:


Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count = 0;
        ListNode temp = head;
        while (temp != null) {
            ++count;
            temp = temp.next;
        }
        // If it has only one element
        if (count == 1)
            return null;
        
        int index = count - n + 1;
        // If it is the first element
        if (index == 1)
            return head.next;
        
        temp = head;
        ListNode prev = null;
        count = 0;
        while (temp != null) {
            ++count;
            if (count == index) {
                prev.next = temp.next;
            }
            prev = temp;
            temp = temp.next;
        }
        return head;

    }
}