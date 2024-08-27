/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
typically using all the original letters exactly once.

Input: s = "anagram", t = "nagaram"
Output: true

Input: s = "rat", t = "car"
Output: false
*/
/*public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length) return false;
        
        var sc=s.ToCharArray();
        var tc=t.ToCharArray();
        
        Array.Sort(sc);
        Array.Sort(tc);
        
        return new string(sc).Equals(new string(tc));
    }
}*/
public class IsAnagram
{
    public bool IsAnagramCal(string s, string t) {

     if(s.Length != t.Length){
            return false;
        }
        int [] arr = new int[26];
        for(int i=0; i<s.Length; i++){
            arr[(int)s[i]-'a'] +=1;
        }
        for(int j=0; j<t.Length; j++){
            arr[(int)t[j]-'a'] -=1;
        }
        for(int i=0; i<arr.Length; i++){
            if(arr[i]!=0){
                return false;
            }
        }
        return true;
    }
}

