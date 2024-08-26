/*
Design a HashMap without using any built-in hash table libraries.

Implement the MyHashMap class:

MyHashMap() initializes the object with an empty map.
void put(int key, int value) inserts a (key, value) pair into the HashMap. If the key already exists in the map, update the corresponding value.
int get(int key) returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
void remove(key) removes the key and its corresponding value if the map contains the mapping for the key.
 

Example 1:

Input
["MyHashMap", "put", "put", "get", "get", "put", "get", "remove", "get"]
[[], [1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]
Output
[null, null, null, 1, -1, null, 1, null, -1]

Explanation
MyHashMap myHashMap = new MyHashMap();
myHashMap.put(1, 1); // The map is now [[1,1]]
myHashMap.put(2, 2); // The map is now [[1,1], [2,2]]
myHashMap.get(1);    // return 1, The map is now [[1,1], [2,2]]
myHashMap.get(3);    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
myHashMap.put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
myHashMap.get(2);    // return 1, The map is now [[1,1], [2,1]]
myHashMap.remove(2); // remove the mapping for 2, The map is now [[1,1]]
myHashMap.get(2);    // return -1 (i.e., not found), The map is now [[1,1]]

*/

public class MyHashMap {

       private class KeyValue {
        public int Key;
        public int Value;
        
        public KeyValue(int key, int value) {
            this.Key = key;
            this.Value = value;
        }
    }
    
    int capacity = (int)Math.Pow(2, 6); // capacity must be equal 2^N (where n is any number)
    List<KeyValue>[] buckets;

    public MyHashMap() {
        buckets = new List<KeyValue>[capacity];
        for (var i=0; i<capacity; i++) {
            buckets[i] = new List<KeyValue>();
        }
    }
    
    public void Put(int key, int value) {
        var b = buckets[key & (capacity-1)];
        var el = b.FirstOrDefault(x => x.Key == key);
        if (el != null) el.Value = value;
        else buckets[key & (capacity-1)].Add(new KeyValue(key, value));
    }
    
    public int Get(int key) {
        var b = buckets[key & (capacity-1)];
        return b.FirstOrDefault(x => x.Key == key)?.Value ?? -1;
    }
    
    public void Remove(int key) {
        var b = buckets[key & (capacity-1)];
        for (var q=b.Count-1; q>=0; q--) {
            if (b[q].Key == key) { 
                b.RemoveAt(q);
                break;
            }
        }
    }

}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */