/*
Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.

Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.

 

Example 1:

Input: nums = [1,2,2,3,1]
Output: 2
Explanation: 
The input array has a degree of 2 because both elements 1 and 2 appear twice.
Of the subarrays that have the same degree:
[1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
The shortest length is 2. So return 2.
Example 2:

Input: nums = [1,2,2,3,1,4,2]
Output: 6
Explanation: 
The degree is 3 because the element 2 is repeated 3 times.
So [2,2,3,1,4,2] is the shortest subarray, therefore returning 6.
*/
public class FindShortestSubArray
{
    public int FindShortestSubArrayCal(int[] nums) {
        Dictionary<int,int> res=new Dictionary<int,int>();
        int max=0;
        
        Dictionary<int,List<int>> seen=new Dictionary<int,List<int>>();
        int minlength=0;
        for(int i=0;i<nums.Length;i++){
            
            if(res.ContainsKey(nums[i])){
                res[nums[i]]++;
               
                if(res[nums[i]]>max){
                    max=res[nums[i]];
                    
                }
            }
            else{
                res.Add(nums[i],1);
            }
        }
        /*int max=0;
        
        foreach(var item in res){
            max=Math.Max(max,item.Value);
        }*/
        
    for(int i=0;i<nums.Length;i++) // Finding elemnts which are appearing d times in an array
    {
        if(res[nums[i]]==max && seen.ContainsKey(nums[i]))
        {
            seen[nums[i]].Add(i);  // storing their index in map <int,vector> type
        }
    }
        int ans=0;
    foreach(var k in seen)
    {
        List<int> n=seen[k.Key];  
        int a=n[n.Count-1]-n[0]+1; //calculating length by finding the first and last index of most appearing                                               element and adding 1 to find the length of subarray.
        ans=Math.Min(ans,a);  // Finding minimum of all possible outcomes
    }

        return ans;
    }
}