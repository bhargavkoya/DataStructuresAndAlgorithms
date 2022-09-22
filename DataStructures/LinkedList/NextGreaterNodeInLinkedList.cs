/*
You are given the head of a linked list with n nodes.

For each node in the list, find the value of the next greater node. That is, for each node, find the value of the first node that is next to it and has a strictly larger value than it.

Return an integer array answer where answer[i] is the value of the next greater node of the ith node (1-indexed). If the ith node does not have a next greater node, set answer[i] = 0.

 

Example 1:


Input: head = [2,1,5]
Output: [5,5,0]
Example 2:


Input: head = [2,7,4,3,5]
Output: [7,0,5,5,0]

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
    public int[] NextLargerNodes(ListNode head) {
       List<int> a=new List<int>();
        while(head!=null){
            a.Add(head.val);
            head=head.next;
        }
        int[] nums=a.ToArray();
        
        int n = nums.Length;
        int[] ans=new int[n];
        for(int k=0;k<n;k++){
            ans[k]=0;
        }
        Stack<int> s=new Stack<int>();
        for(int i = n-1; i >= 0; i--){
            if(s.Count==0)
                ans[i]=0;
            else if(a[i]<s.Peek()){
                ans[i]=s.Peek();
            }
            else if(a[i]>=s.Peek()){
                while(s.Count>0 && a[i]>=s.Peek())
                    s.Pop();
                if(s.Count==0)
                    ans[i]=0;
                else
                    ans[i]=s.Peek();
            }
            s.Push(a[i]);
        }
        //Array.Reverse(ans);
        return ans;

    }
}