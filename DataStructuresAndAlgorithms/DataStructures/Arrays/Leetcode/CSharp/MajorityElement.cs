/*
The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2


*/

public class MajorityElement
{
    public int MajorityElementCal(int[] nums) {
        int majority=0;
        int count=0;
        for(int i=0;i<nums.Length;i++){
            if(count==0){
                majority=nums[i];
            }
        
           count+=(nums[i]==majority)?1:-1;
            
        }
        return majority;
    }
}