/*
Given a string s, return the maximum number of ocurrences of any substring under the following rules:

The number of unique characters in the substring must be less than or equal to maxLetters.
The substring size must be between minSize and maxSize inclusive.
 

Example 1:

Input: s = "aababcaab", maxLetters = 2, minSize = 3, maxSize = 4
Output: 2
Explanation: Substring "aab" has 2 ocurrences in the original string.
It satisfies the conditions, 2 unique letters and size 3 (between minSize and maxSize).
Example 2:

Input: s = "aaaa", maxLetters = 1, minSize = 3, maxSize = 3
Output: 2
Explanation: Substring "aaa" occur 2 times in the string. It can overlap.

*/
public class MaxFreq
{
    public int MaxFreqCal(string s, int maxLetters, int minSize, int maxSize) {
             Dictionary<string, int> subLookup = new Dictionary<string, int>();
            int result = 0;
            for (int i = 0; i < s.Length - minSize + 1; i++)
            {
                string sub = s.Substring(i, minSize);
                if (subLookup.ContainsKey(sub))
                {
                    subLookup[sub] += 1;
                }
                else
                {
                    subLookup.Add(sub, 1);
                }
            }

            foreach (var itm in subLookup)
              result = IsKeyValid(itm.Key, maxLetters) ? Math.Max(result, itm.Value) : result;
            
            return result;

    }
    private bool IsKeyValid(string key, int max)
    {
        HashSet<char> sett = new HashSet<char>();
        foreach (var itm in key)
          sett.Add(itm);

        return sett.Count() <= max;
    }

    
}