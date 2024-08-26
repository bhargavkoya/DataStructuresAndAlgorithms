/*
Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array
 such that nums[i] == nums[j] and abs(i - j) <= k.

Input: nums = [1,2,3,1], k = 3
Output: true

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
*/
public class ContainsNearbyDuplicate
{
    public bool ContainsNearbyDuplicateCal(int[] nums, int k) {
        Dictionary<int, int> finaldic = new Dictionary<int, int>();
        int diff = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (finaldic.ContainsKey(nums[i])) {
                diff = Math.Abs(finaldic[nums[i]] - i);
                
                if (diff <= k) return true;

                finaldic[nums[i]] = i;
            } else {
                finaldic.Add(nums[i], i);
            }
        }
        
        return false;
    }

    }


