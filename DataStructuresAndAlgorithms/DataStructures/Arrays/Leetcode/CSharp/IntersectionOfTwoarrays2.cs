/*
Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

 

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted.

*/
public class Intersect
{
    public int[] IntersectCal(int[] nums1, int[] nums2) {
        List<int> res=new List<int>();
       Array.Sort(nums1);
        Array.Sort(nums2);
        int i=0,j=0;
        while(i<nums1.Length && j<nums2.Length){
            if(nums1[i]>nums2[j]) j++;
            else if(nums1[i]<nums2[j]) i++;
            else{
                res.Add(nums1[i]);
                i++;
                j++;
            }
        }
        
        return res.ToArray();
 
    }
}