/*
Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

 

Example 1:

Input: s = "abccccdd"
Output: 7
Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.
Example 2:

Input: s = "a"
Output: 1
Explanation: The longest palindrome that can be built is "a", whose length is 1.

*/
public class LongestPalindrome
{
    public int LongestPalindromeCal(string s) {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        foreach(var c in s){
            if(dic.ContainsKey(c)){
                dic[c]++;
            }
            else{
                dic.Add(c,1);
            }
        }
        
        int ans=0;
        bool firstodd=false;
        for(int i=0;i<dic.Count();i++){
            if(dic.ElementAt(i).Value%2==0){
                ans+=dic.ElementAt(i).Value;
            }
            else{
                if(!firstodd){
                    ans+=dic.ElementAt(i).Value;
                    firstodd=true;
                }
                else{
                    ans+=dic.ElementAt(i).Value-1;
                }
            }
        }
        
        return ans;
    }
}