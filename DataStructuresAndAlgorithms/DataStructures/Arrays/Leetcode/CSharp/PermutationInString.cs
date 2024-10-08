/*Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

In other words, return true if one of s1's permutations is the substring of s2.

 

Example 1:

Input: s1 = "ab", s2 = "eidbaooo"
Output: true
Explanation: s2 contains one permutation of s1 ("ba").
Example 2:

Input: s1 = "ab", s2 = "eidboaoo"
Output: false
*/
public class CheckInclusion
{
    public bool CheckInclusionCal(string s1, string s2) {
        Dictionary< char, int >mp=new Dictionary<char,int>();   
        foreach(var item in s1){
            if(!mp.ContainsKey(item))
                mp.Add(item,1);
            else
                mp[item]++;
        }
        int count = mp.Count;   
        int i = 0, j = 0;
        int k = s1.Length;       
        while(j < s2.Length){
            if(mp.ContainsKey(s2[j])){      //If a character is found that already exists in the map, reduce its                                                        frequency by one.
                mp[s2[j]]--;
                if(mp[s2[j]] == 0){     //If the frequency of a specific character on the map is 0, it means that all                                           occurrences of that character is found inside the current window size.
                    count--;
                }
            }
            if(j-i+1 < k){
                j++;
            }
            else if(j-i+1 == k){
				if(count == 0){    //Anagram found 
					return true;  
				}
                if(mp.ContainsKey(s2[i])){  //Check if that character is present in the map while sliding the                                                      window, then increase its frequency by one, as we decreased its                                                        frequency when we first met it while crossing the window.
                    mp[s2[i]]++;
                    if(mp[s2[i]] == 1){
                        count++;
                    }
                }
                i++;
                j++;
            }
        }
        return false;

    }
}