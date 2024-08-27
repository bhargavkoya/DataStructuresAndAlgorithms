/*
Given the head of a linked list, we repeatedly delete consecutive sequences of nodes that sum to 0 until there are no such sequences.

After doing so, return the head of the final linked list.  You may return any such answer.

 

(Note that in the examples below, all sequences are serializations of ListNode objects.)

Example 1:

Input: head = [1,2,-3,3,1]
Output: [3,1]
Note: The answer [1,2,1] would also be accepted.
Example 2:

Input: head = [1,2,3,-3,4]
Output: [1,2,4]
Example 3:

Input: head = [1,2,3,-3,-2]
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
public class RemoveZeroSumSublists
{
    public ListNode RemoveZeroSumSublistsCal(ListNode head) {
        ListNode dummy=new ListNode();
        dummy.next=head;
        Dictionary<int,ListNode> map=new Dictionary<int,ListNode>();
        int psum=0;
        map.Add(psum,dummy);
        while(head!=null){
            psum+=head.val;
            if(map.ContainsKey(psum)){
                var toremove=map[psum].next;
                int Sum=psum;
                while(toremove!=head){
                    Sum+=toremove.val;
                    map.Remove(Sum);
                    toremove=toremove.next;
                }
                map[psum].next=head.next;
            }
            else{
                map.Add(psum,head);
            }
            head=head.next;
        }
        return dummy.next;
    }
}