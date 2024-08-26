/*1.Contains Duplicate:
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is 
distinct.
Input: nums = [1,2,3,1]
Output: true*/

//solution


/**
 * @param {number[]} nums
 * @return {boolean}
 */
 var containsDuplicate = function(nums) {
    const result=[];
    for(let i of nums){
        if(result.includes(i)) return true;
        result.push(i);
    }
    return false;
};