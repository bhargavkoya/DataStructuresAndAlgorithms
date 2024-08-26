/*
Given a string s, find the length of the longest substring without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.


*/
public class LengthOfLongestSubstring
{
    public int LengthOfLongestSubstringCal(string s) {
        int start =0;
        int end = 0;  
        int max=0;
        
        HashSet<Char> hs= new HashSet<Char>();
        while(end<s.Length){
            if(!hs.Contains(s[end])){
                hs.Add(s[end]);
                end++;
                max= Math.Max(end-start,max);
            }
            else{
                hs.Remove(s[start]);
                start++;
            }
        }
        return max;

    }
}