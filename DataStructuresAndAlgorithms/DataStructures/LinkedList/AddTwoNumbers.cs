/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
*/
//Definition for singly - linked list.
 public class ListNode
{
       public int val;
        public ListNode next;
   public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
 }

public class AddTwoNumbers
{
    public ListNode AddTwoNumbersCal(ListNode l1, ListNode l2) {
       int sum = 0;

        //first init
        ListNode resNode = new ListNode();
        ListNode copyNode = resNode;
        
        //start iteration
        while(l1!=null || l2!=null || sum!= 0)
        {
            if(l1!=null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            
            if(l2!=null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            ListNode newNode = new ListNode();
            newNode.val = sum%10;
            copyNode.next = newNode;
            copyNode = newNode;
            
            sum/=10;   //will always be 0 or 1
        }
        
       return resNode.next;

    }
}