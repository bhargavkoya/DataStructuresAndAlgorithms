/*
The DNA sequence is composed of a series of nucleotides abbreviated as 'A', 'C', 'G', and 'T'.

For example, "ACGAATTCCG" is a DNA sequence.
When studying DNA, it is useful to identify repeated sequences within the DNA.

Given a string s that represents a DNA sequence, return all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule. You may return the answer in any order.

 

Example 1:

Input: s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"
Output: ["AAAAACCCCC","CCCCCAAAAA"]
Example 2:

Input: s = "AAAAAAAAAAAAA"
Output: ["AAAAAAAAAA"]
*/
public class FindRepeatedDnaSequences
{
    public IList<string> FindRepeatedDnaSequencesCal(string s) {
        HashSet<string> res=new HashSet<string>();
        HashSet<string> seen=new HashSet<string>();
        for(int i=0;i<s.Length-9;i++){
            string temp=s.Substring(i,10);
            if(seen.Contains(temp))
                res.Add(temp);
            seen.Add(temp);
        }
        return res.ToList();
    }
}