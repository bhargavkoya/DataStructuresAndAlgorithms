/*
You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.

We repeatedly make duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.

 

Example 1:

Input: s = "abbaca"
Output: "ca"
Explanation: 
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
Example 2:

Input: s = "azxxzy"
Output: "ay"

*/
public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stack=new Stack<char>();
        char temp='x';
        for(int i=0;i<s.Length;i++)
        {
            if(stack.Count==0)
            {
                stack.Push(s[i]);
                continue;
            }
            if(stack.Count>0)
            {
                temp=stack.Pop();
                if(temp==s[i])
                {
                    continue;
                }
                stack.Push(temp);
                stack.Push(s[i]);
            }
        
        }
        
        String str="";
        while(stack.Count>0)
        {
            str=stack.Pop()+str;

        }
        
        return str;

    }
}