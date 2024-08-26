/*1.Contains Duplicate:
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is 
distinct.
Input: nums = [1,2,3,1]
Output: true*/

//solution
public class ContainsDuplicate
{
    public bool ContainsDuplicateCal(int[] nums) {
        HashSet<int> final=new HashSet<int>();
        foreach(var i in nums){
            if(final.Contains(i)) return true;
            final.Add(i);
        }
        return false;
    }
}




