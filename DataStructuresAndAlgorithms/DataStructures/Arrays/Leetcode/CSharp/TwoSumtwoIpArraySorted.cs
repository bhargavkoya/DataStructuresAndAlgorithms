/* 
Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order,
 find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and 
 numbers[index2] where 1 <= index1 < index2 <= numbers.length.

Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.

Your solution must use only constant extra space.

Input: numbers = [2,3,4], target = 6
Output: [1,3]
Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].

*/
public class TwoSum
{
    public int[] TwoSumCal(int[] numbers, int target) {
        int start=0;
        int end=numbers.Length-1;
        int[] result=new int[2];
        while(start<end){
            int sum=numbers[start]+numbers[end];
            if(target==sum){
                result[0]=start+1;
                result[1]=end+1;
                break;
            }
            else if(target>sum){
                start+=1;
            }
            else{
                end--;
            }
        }
        return result;
    }
}

