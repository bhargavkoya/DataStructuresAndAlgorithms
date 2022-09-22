/*
Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

void add(key) Inserts the value key into the HashSet.
bool contains(key) Returns whether the value key exists in the HashSet or not.
void remove(key) Removes the value key in the HashSet. If key does not exist in the HashSet, do nothing.
 

Example 1:

Input
["MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains"]
[[], [1], [2], [1], [3], [2], [2], [2], [2]]
Output
[null, null, null, true, false, null, true, null, false]

Explanation
MyHashSet myHashSet = new MyHashSet();
myHashSet.add(1);      // set = [1]
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(1); // return True
myHashSet.contains(3); // return False, (not found)
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(2); // return True
myHashSet.remove(2);   // set = [1]
myHashSet.contains(2); // return False, (already removed)
*/
public class MyHashSet {

    int capacity = (int)Math.Pow(2, 6); // capacity must be equal 2^N (where n is any number)
    List<int>[] buckets;
    
    public MyHashSet() {
        buckets = new List<int>[capacity];
        for (var i=0; i<capacity; i++) {
            buckets[i] = new List<int>();
        }
    }
    
    public void Add(int key) {        
        if (!Contains(key)) {
            buckets[key & (capacity-1)].Add(key);
        }
    }
    
    public void Remove(int key) {
        var b = buckets[key & (capacity-1)];
        for (var q=b.Count-1; q>=0; q--) {
            if (b[q] == key) { 
                b.RemoveAt(q);
                break;
            }
        }
    }
    
    public bool Contains(int key) {
        var b = buckets[key & (capacity-1)];
        for (var q=b.Count-1; q>=0; q--) {
            if (b[q] == key) {
                return true;
            }
        }
        return false;
    }

}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */