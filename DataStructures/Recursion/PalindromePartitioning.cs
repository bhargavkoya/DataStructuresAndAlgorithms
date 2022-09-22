/*
Given a string s, partition s such that every substring of the partition is a palindrome. Return all possible palindrome partitioning of s.

A palindrome string is a string that reads the same backward as forward.

 

Example 1:

Input: s = "aab"
Output: [["a","a","b"],["aa","b"]]
Example 2:

Input: s = "a"
Output: [["a"]]

*/
public class Solution {
    public IList<IList<string>> Partition(string s) {
        List<IList<String>> res = new List<IList<String>>();
        List <String> path = new List<String>();
        partitionHelper(0, s, path, res);
        return res;
    }
    
    public  void partitionHelper(int index, String s, List <String> path,                                                            List<IList<String>> res) {
        if (index == s.Length) {
            res.Add(new List<String>(path));
            return;
        }
        for (int i = index; i < s.Length; i++) {
            if (isPalindrome(s, index, i)) {
                path.Add(s.Substring(index, i-index + 1));
                partitionHelper(i + 1, s, path, res);
                path.RemoveAt(path.Count - 1);
            }
        }
    }

   public bool isPalindrome(String s, int start, int end) {
        while (start <= end) {
            if (s[start++] != s[end--])
                return false;
        }
        return true;
    }

}