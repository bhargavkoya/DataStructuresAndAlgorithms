/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false

*/
public class Solution {
    public bool IsValid(string s) {
        Stack<char> st=new Stack<char>();
        for(int i = 0;i<s.Length;i++){
            if(st.Count==0){
                st.Push(s[i]);
                continue;
            }
            if(s[i] == ')' && st.Peek() == '(' ) st.Pop();
            else if(s[i] == '}' && st.Peek() == '{' ) st.Pop();
            else if(s[i] == ']' && st.Peek() == '[' ) st.Pop();
            else{
                st.Push(s[i]);
            }
        }
        return st.Count==0;

    }
}