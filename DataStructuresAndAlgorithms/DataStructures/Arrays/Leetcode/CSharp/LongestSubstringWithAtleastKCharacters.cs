/*
Given a string s and an integer k, return the length of the longest substring of s such that the frequency of each character in this substring is greater than or equal to k.

 

Example 1:

Input: s = "aaabb", k = 3
Output: 3
Explanation: The longest substring is "aaa", as 'a' is repeated 3 times.
Example 2:

Input: s = "ababbc", k = 2
Output: 5
Explanation: The longest substring is "ababb", as 'a' is repeated 2 times and 'b' is repeated 3 times.

*/
public class LongestSubstring
{
    public int LongestSubstringCal(string s, int k) {
        int n=s.Length;
        if(n==0 || n<k)
            return 0;
        if(k<=1)
            return n;
        
        Dictionary<char,int> res=new Dictionary<char,int>();
        foreach(var i in s){
            if(res.ContainsKey(i))
                res[i]++;
            else
                res.Add(i,1);
        }
        
        int l=0;
        while(l<n && res[s[l]]>=k)
            l++;
        if(l>=n-1) return l;
        
        int ls1=LongestSubstring(s.Substring(0,l),k);
        while(l<n && res[s[l]]<k) l++;
        int ls2=LongestSubstring(s.Substring(l),k);
        
        return Math.Max(ls1,ls2);
    }
}