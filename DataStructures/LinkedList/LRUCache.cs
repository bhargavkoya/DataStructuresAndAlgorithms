/*
Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

Implement the LRUCache class:

LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
int get(int key) Return the value of the key if the key exists, otherwise return -1.
void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.
The functions get and put must each run in O(1) average time complexity.

 

Example 1:

Input
["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
Output
[null, null, null, 1, null, -1, null, -1, 3, 4]

Explanation
LRUCache lRUCache = new LRUCache(2);
lRUCache.put(1, 1); // cache is {1=1}
lRUCache.put(2, 2); // cache is {1=1, 2=2}
lRUCache.get(1);    // return 1
lRUCache.put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
lRUCache.get(2);    // returns -1 (not found)
lRUCache.put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
lRUCache.get(1);    // return -1 (not found)
lRUCache.get(3);    // return 3
lRUCache.get(4);    // return 4

*/
public class LRUCache {

    public class Node
    {
        // In this question we will be taking help of doubly linked list
        public int value, key;
        public Node next;
        public Node prev;

        // these key-value pairs are used, as further we will be using hashmap too, so that the get(key) method can be            implemented in O(1) time - as it is a search operation
        public Node(int key1, int value1)
        {
            key = key1;
            value = value1;
        }
    }
    
    Node head = new Node(0,0);  // for key-value
    Node tail = new Node(0,0);

    Dictionary<int, Node> map = new Dictionary<int,Node>();   // integer - key, Node - where there is our key

    int size;

    public LRUCache(int capacity) {
        size = capacity;

        head.next = tail;
        tail.prev = head;

    }
    
    public int Get(int key) {
        // to get a key - we will first search it our hashmap
        // if found:
        //      --> with the help of key-value - we will search that node
        //      --> remove that node, and place it in the fornt - as it is now recently used
        //      --> remove it from hashmap
        //      --> update the hashmap with the new node address
        // if not found:
        //      --> return -1

        if(map.ContainsKey(key) == true)
        {
            // found

            // store the node value from the hashmap
            Node temp = map[key];

            // remove this node
            remove(temp);

            // insert it now
            insert(temp);

            // now our insert and remove function - automatically changes our hashmap values too
            return temp.value;
        }
        else
        {
            return -1;
        }

    }
    
    public void Put(int key, int value) {
        // now to put the key-value pair in our LRU cache we will have to keep track of our size

        // if the size of hashmap is lesser than the size allotted - we will insert it
        // if the size is equal, we will remove the element from last and insert it again

        // if map already contains the value we are abt to insert - then again remove it first and then insert

        if(map.ContainsKey(key) == true)
        {
            remove(map[key]);
        }

        if(map.Count == size)
        {
            remove(tail.prev);  // reomve from back
        }

        Node temp = new Node(key, value);
        // insert it
        insert(temp);

    }

    
    
    // now we will make our basic - insert and delete operation
    private void insert(Node temp)
    {
        // always our insertion will happen from the head side - so as to denote that this is the most recently used              one

        // before adding in our linked list - we will add this element in our hashmap too
        map.Add(temp.key, temp);

        // now we will make the adjustments
        temp.next = head.next;
        head.next.prev = temp;
        head.next = temp;
        temp.prev = head;
    }

    private void remove(Node temp)
    {
        // to remove, we will delete from the tail side

        // first we will remove it from the hashmap
        map.Remove(temp.key);

        // now from the list
        temp.prev.next = temp.next;
        temp.next.prev = temp.prev;
    }


}
/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */