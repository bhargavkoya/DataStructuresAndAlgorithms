/*
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

 

Example 1:


Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
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
public class MergeTwoLists
{
    public ListNode MergeTwoListsCal(ListNode list1, ListNode list2) {
        ListNode res=new ListNode(0);
        ListNode temp=res;
       // ListNode temp1=list1;
        //ListNode temp2=list2;
        while(list1!=null && list2!=null){
           if(list1.val<=list2.val) 

            { 

                temp.next=new ListNode(list1.val); 

                list1=list1.next; 

            } 

            else 

            { 

                temp.next=new ListNode(list2.val); 

                list2=list2.next; 

            } 

            temp=temp.next;             
        }
        temp.next=(list1==null)?list2:list1; 

        return res.next; 
    }
}