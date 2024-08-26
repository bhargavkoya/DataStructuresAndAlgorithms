/*
Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.

 

Example 1:

Input: s = "(()"
Output: 2
Explanation: The longest valid parentheses substring is "()".
Example 2:

Input: s = ")()())"
Output: 4
Explanation: The longest valid parentheses substring is "()()".
Example 3:

Input: s = ""
Output: 0

*/
public class Solution {
    public int LongestValidParentheses(string s) {
        int n = s.Length;
        if(n == 0) return 0;
        Stack<int> st=new Stack<int>();
        st.Push(-1);
        int len = 0;
        
        for(int i=0 ; i<n ; ++i){
            if(s[i] == '(') st.Push(i);
            else if(s[i] == ')'){
                st.Pop();
                if(st.Count==0) st.Push(i);
                else{
                    len = Math.Max(len,i - st.Peek());
                }
            }
        }
        return len;

    }
    
}