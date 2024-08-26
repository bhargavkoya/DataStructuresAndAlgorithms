/*Given two strings s and p, return an array of all the start indices of p's anagrams in s. You may return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: s = "cbaebabacd", p = "abc"
Output: [0,6]
Explanation:
The substring with start index = 0 is "cba", which is an anagram of "abc".
The substring with start index = 6 is "bac", which is an anagram of "abc".
Example 2:

Input: s = "abab", p = "ab"
Output: [0,1,2]
Explanation:
The substring with start index = 0 is "ab", which is an anagram of "ab".
The substring with start index = 1 is "ba", which is an anagram of "ab".
The substring with start index = 2 is "ab", which is an anagram of "ab".
*/
public class FindAnagrams
{
    public IList<int> FindAnagramsCal(string s, string p) {
            List<int> v=new List<int>();
            Dictionary<char,int> mp = new Dictionary<char,int>();
            int left=0,right=0;
            for (int i = 0; i < p.Length; i++) 
            {
                int value;
                if (mp.TryGetValue(p[i], out value))
                {
                    mp[p[i]]++;
                }
                else
                {
                    mp.Add(p[i],1);
                }
             
            }   

            int count=mp.Count;
            int r=p.Length;

            while(right<s.Length)
            {
                mp[s[right]]--;
                if(mp[s[right]] == 0)
                    count--;
                if(right-left+1 < r)
                    right++;
                else if(right-left+1 == r)
                {
                    if(count == 0)
                    {
                        v.Add(left);
                    }
                    mp[s[left]]++;
                    if(mp[s[left]] > 0)
                        count++;
                    left++;right++;
                }
            }
            return v;
    }
}