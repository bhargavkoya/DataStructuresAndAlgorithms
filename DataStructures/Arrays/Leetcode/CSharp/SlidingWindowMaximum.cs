/*
You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of 
the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.

Return the max sliding window.

Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
Output: [3,3,5,5,6,7]
Explanation: 
Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7

 */

 public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
                // Create a Double Ended Queue, Qi that
        // will store indexes of array elements
        // The queue will store indexes of useful
        // elements in every window and it will
        // maintain decreasing order of values
        // from front to rear in Qi, i.e.,
        // arr[Qi.front[]] to arr[Qi.rear()]
        // are sorted in decreasing order
        List<int> Qi = new List<int>();
        int[] result=new int[nums.Length-k+1];
 
        /* Process first k (or first window)
        elements of array */
        int i;
        int a=0;
        for (i = 0; i < k; ++i) {
            // For every element, the previous
            // smaller elements are useless so
            // remove them from Qi
            while (Qi.Count != 0 && nums[i] >=
                            nums[Qi[Qi.Count-1]])
               
                // Remove from rear
                Qi.RemoveAt(Qi.Count-1);
 
            // Add new element at rear of queue
            Qi.Insert(Qi.Count, i);
        }
 
        // Process rest of the elements,
        // i.e., from arr[k] to arr[n-1]
        for (; i < nums.Length; ++i)
        {
            // The element at the front of
            // the queue is the largest element of
            // previous window, so print it
            //Console.Write(arr[Qi[0]] + " ");
            result[a]=nums[Qi[0]];
 
            // Remove the elements which are
            // out of this window
            while ((Qi.Count != 0) && Qi[0] <= i - k)
                Qi.RemoveAt(0);
 
            // Remove all elements smaller
            // than the currently
            // being added element (remove
            // useless elements)
            while ((Qi.Count != 0) && nums[i] >=
                           nums[Qi[Qi.Count - 1]])
                Qi.RemoveAt(Qi.Count - 1);
 
            // Add current element at the rear of Qi
            Qi.Insert(Qi.Count, i);
            a=a+1;
        }
 
        // Print the maximum element of last window
        //Console.Write(arr[Qi[0]]);
        result[a]=nums[Qi[0]];
        return result;
     }
    }


