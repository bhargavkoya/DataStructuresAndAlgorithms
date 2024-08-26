/*
Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

 

Example 1:

Input: nums = [3,2,3]
Output: [3]
Example 2:

Input: nums = [1]
Output: [1]
Example 3:

Input: nums = [1,2]
Output: [1,2]

*/

public class MajorityElement
{
    public IList<int> MajorityElementCal(int[] nums) {
        int majority1=nums[0];
        int majority2=nums[0];
        int count1=0;
        int count2=0;
        var res=new List<int>();
        for(int i=0;i<nums.Length;i++){
            if(majority1==nums[i]){
                count1++;;
            }
            else if(majority2==nums[i]){
                count2++;
            }
            else if(count1==0){
                majority1=nums[i];
                count1=1;
            }
            else if(count2==0){
                majority2=nums[i];
                count2=1;
            }
            else{
                count1--;
                count2--;
            }
            
           
           
            
        }
        int c1=0,c2=0;
        for(int j=0;j<nums.Length;j++){
            if(nums[j]==majority1) c1++;
            if(nums[j]==majority2) c2++;
            
        }
        if(c1>nums.Length/3 && c2>nums.Length/3) {res.Add(majority1);res.Add(majority2);}
        if(c1>nums.Length/3) res.Add(majority1);
        if(c2>nums.Length/3) res.Add(majority2);

        return res;
    }
}