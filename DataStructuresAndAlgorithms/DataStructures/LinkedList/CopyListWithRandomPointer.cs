/*
A linked list of length n is given such that each node contains an additional random pointer, which could point to any node in the list, or null.

Construct a deep copy of the list. The deep copy should consist of exactly n brand new nodes, where each new node has its value set to the value of its corresponding original node. Both the next and random pointer of the new nodes should point to new nodes in the copied list such that the pointers in the original list and copied list represent the same list state. None of the pointers in the new list should point to nodes in the original list.

For example, if there are two nodes X and Y in the original list, where X.random --> Y, then for the corresponding two nodes x and y in the copied list, x.random --> y.

Return the head of the copied linked list.

The linked list is represented in the input/output as a list of n nodes. Each node is represented as a pair of [val, random_index] where:

val: an integer representing Node.val
random_index: the index of the node (range from 0 to n-1) that the random pointer points to, or null if it does not point to any node.
Your code will only be given the head of the original linked list.

 

Example 1:


Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
Example 2:


Input: head = [[1,1],[2,1]]
Output: [[1,1],[2,1]]
Example 3:



Input: head = [[3,null],[3,0],[3,null]]
Output: [[3,null],[3,0],[3,null]]

*/
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

public class CopyRandomList
{
    public Node CopyRandomListCal(Node head) {
            Node p=head; 

 

   //stuff similar node at place of next node 

        while(p!=null) 

        { 

            Node nxt=p.next; 

            Node copy=new Node(p.val); 

            copy.next=nxt; 

            p.next=copy; 

            p=nxt; 

        } 

        p=head; 
        
        //to create random links 

        while(p!=null) 

        { 

         p.next.random=(p.random!=null)?p.random.next:null; 

         p=p.next.next; 

             

        } 

        p=head; 

        Node ret=(p!=null)?p.next:null; 

 //separate two linked lists 

        while(p!=null) 

        { 

            Node copy=p.next; 

            p.next=copy.next; 

            p=p.next; 

            copy.next=(p!=null)?p.next:null; 

        } 

        return ret; 

 
        
    }
}