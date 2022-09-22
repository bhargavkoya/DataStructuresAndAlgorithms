/*
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both cases.

 

Example 1:

Input: s = "hello"
Output: "holle"
Example 2:

Input: s = "leetcode"
Output: "leotcede"

*/

public class Solution {
    public string ReverseVowels(string s) {
        int start=0,end=s.Length-1;
        
        while(start<end){
            if(!isVowel(char.ToLower(s[start]))){
                start++;
                continue;
            }
            if(!isVowel(char.ToLower(s[end]))){
                end--;
                continue;
            }
             char temp=s[start];
             res[start]=s[end];
             s[end]=temp;
              start++;
              end--;
        
       
          }
        return s;
    }
       bool isVowel(char c){
            if(c=='a'|| c=='e' || c=='i' || c=='o' ||c=='u') return true;
            return false;
        }
}