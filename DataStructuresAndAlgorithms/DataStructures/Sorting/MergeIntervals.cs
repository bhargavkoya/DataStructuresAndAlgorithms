/*
Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

 

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.

*/
public class Merge
{
    public int[][] MergeCal(int[][] intervals) {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0])); // Sort array to avoid following test cases.
        
        List<int[]> result = new();
        int[] prev = intervals[0];//take first array in previous variable
        result.Add(prev); // add first array to result. we will update this result over time and since its reference type it will automatically make changes
        
        for(int i=1; i<intervals.Length; i++) // start loop with first index, we took care of 0th index above
        {
            int[] current = intervals[i]; // grab current array in current variable
            
            if(prev[1] >= current[0]) // The line is overlapping when right pointer of left-line is greater than left pointer of right-line. e.g. [1,3],[2,6]
            {
                prev[1] = Math.Max(prev[1], current[1]); //Since we have to merge overlapping lines, all we have to do is take max of right pointer, 
                                                          //array is sorted so left  pointer is already at its place
            }
            else
            {
			   // now we have merged [1,3] [2,6] => [1,6], so the result that was holding [1,3] got overridden by [1,6] 
                prev = current; // we need to add current array to result to repeat the process, so assign [8,10] as prev
                result.Add(prev);// result will have [1,6] [8,10]
            }
        }
        return result.ToArray();

    }
}