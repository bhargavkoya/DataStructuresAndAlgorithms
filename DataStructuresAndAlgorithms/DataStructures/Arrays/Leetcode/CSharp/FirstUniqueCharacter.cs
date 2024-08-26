/*
Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

 

Example 1:

Input: s = "leetcode"
Output: 0
Example 2:

Input: s = "loveleetcode"
Output: 2
Example 3:

Input: s = "aabb"
Output: -1

*/
public class FirstUniqChar
{
    public int FirstUniqCharCal(string s) {
        Dictionary<char,int> res=new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++){
            if(!res.ContainsKey(s[i])){
                res.Add(s[i],1);
            }
            else
             res[s[i]]++;
        }
        for(int j=0;j<s.Length;j++){
            if(res[s[j]]==1)
                return j;
            
        }
        return -1;
    }
    
}