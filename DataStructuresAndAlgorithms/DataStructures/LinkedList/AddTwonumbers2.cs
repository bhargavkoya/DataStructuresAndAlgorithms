/*
You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [7,2,4,3], l2 = [5,6,4]
Output: [7,8,0,7]
Example 2:

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [8,0,7]
Example 3:

Input: l1 = [0], l2 = [0]
Output: [0]

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

    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}
    public class AddTwoNumbersTwo
    {
        public ListNode AddTwoNumbersCal(ListNode l1, ListNode l2)
        {
            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>();
            ListNode result = null;
            while (l1 != null)
            {
                st1.Push(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                st2.Push(l2.val);
                l2 = l2.next;
            }
            int a, b, carry = 0;
            while (st1.Count > 0 || st2.Count > 0)
            {
                a = 0; b = 0;
                if (st1.Count > 0)
                {
                    a = st1.Peek();
                    st1.Pop();
                }
                if (st2.Count > 0)
                {
                    b = st2.Peek();
                    st2.Pop();
                }
                int add = (a + b + carry);
                carry = add / 10;
                ListNode temp = new ListNode(add % 10);
                if (result == null)
                {
                    result = temp;
                }
                else
                {
                    temp.next = result;
                    result = temp;
                }
            }
            if (carry != 0)
            {
                ListNode temp = new ListNode(carry);
                temp.next = result;
                result = temp;
            }
            return result;

        }
    }
