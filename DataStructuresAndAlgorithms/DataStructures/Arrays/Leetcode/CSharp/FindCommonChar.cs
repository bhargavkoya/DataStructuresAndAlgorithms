/*
Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.

 

Example 1:

Input: words = ["bella","label","roller"]
Output: ["e","l","l"]
Example 2:

Input: words = ["cool","lock","cook"]
Output: ["c","o"]

*/

public class CommonChars
{
    public IList<string> CommonCharsCal(string[] words) {
        List<int> mi=Enumerable.Repeat(0, 26).ToList();
        
        for(int i=0;i<words.Length;i++)
        {
               List<int>freq=Enumerable.Repeat(0, 26).ToList();
               for(int j=0;j<words[i].Length;j++)
               {
                      freq[words[i][j] -'a']++;
               }
               for(int k=0;k<26;i++)
               {
                     mi[k]=Math.Min(mi[k],freq[k]);
               }
               
        }
        List<string> ans=new List<string>();
        for(int i=0;i<26;i++)
        {
               for(int j=1;j<= mi[i] ;j++)  
               {
                    string st="";
                   char ch=(char)(i+'a');
                     st+=ch;
                     ans.Add(st);
               }
        }
        return ans;
        
    }
}