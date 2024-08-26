/*
Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

 

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.

*/
public class Intersection
{
    public int[] IntersectionCal(int[] nums1, int[] nums2) {
        
       HashSet<int> res=new HashSet<int>();
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
        List<int> result=new List<int>();
        foreach(var item in res){
            result.Add(item);
        }
        return result.ToArray();
    }
}