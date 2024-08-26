/*
Given an array of integers heights representing the histogram's bar height where the width of each bar is 1, return the area of the largest rectangle in the histogram.

 

Example 1:


Input: heights = [2,1,5,6,2,3]
Output: 10
Explanation: The above is a histogram where width of each bar is 1.
The largest rectangle is shown in the red area, which has an area = 10 units.
Example 2:


Input: heights = [2,4]
Output: 4

*/
public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        
        // Calculate the left smaller index by maintaining a monotone increasing stack
        Stack<int[]> stack = new Stack<int[]>(); // int[] stores the index and value for each element
        int[] leftSmaller = new int[n]; // Computed smaller left indices will be stored here
        for(int i=0; i < n; i++){
            int curr = heights[i];
            // Pop elements out of the stack until we find a smaller element in the left of current element
            while(stack.Count>0 && curr <= stack.Peek()[1])
                stack.Pop();
            // The boundary of the current element will be the next element right adjacent to the smaller element.
            // If there is no left boundary then we make it as 0
            leftSmaller[i] = stack.Count>0 ? stack.Peek()[0] + 1 : 0;
            stack.Push(new int[]{i, curr});
        }

        // Calculate the right smaller index
        stack = new Stack<int[]>();   // Re-initializing the stack
        int[] rightSmaller = new int[n]; // Computed smaller right indices will be stored here
             
        for(int i=n-1; i >= 0; i--){
            int curr = heights[i];
            // Pop elements out of the stack until we find a smaller element in the right of current element
            while(stack.Count>0 && curr <= stack.Peek()[1])
                stack.Pop();
            // The boundary of the current element will be the next element left adjacent to the smaller element.
            // If there is no right boundary then we consider the last element index as the end boundary
            rightSmaller[i] = stack.Count>0 ? stack.Peek()[0] - 1 : n-1;
            stack.Push(new int[]{i, curr});
        }

        int maxArea = 0;
        for(int i=0; i < n; i++){
            int currArea = (rightSmaller[i] - leftSmaller[i] + 1) * heights[i];
            maxArea = Math.Max(maxArea, currArea);
        }        
        return maxArea;

    }
}