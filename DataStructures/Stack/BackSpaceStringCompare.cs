/*
Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

Note that after backspacing an empty text, the text will continue empty.

 

Example 1:

Input: s = "ab#c", t = "ad#c"
Output: true
Explanation: Both s and t become "ac".
Example 2:

Input: s = "ab##", t = "c#d#"
Output: true
Explanation: Both s and t become "".
Example 3:

Input: s = "a#c", t = "b"
Output: false
Explanation: s becomes "c" while t becomes "b".

*/
public class Solution {
    public bool BackspaceCompare(string str, string s) {
        Stack <char> stk= new Stack<char>();
        StringBuilder s1= new StringBuilder();
        
        StringBuilder s2= new StringBuilder();
        
        for(int i=str.Length-1; i>=0; i--){
            if(str[i]=='#') stk.Push('#');
            else if(stk.Count>0 && str[i]!='#' && stk.Peek()=='#') stk.Pop();
            else stk.Push(str[i]);
        }
        while(stk.Count>0) {
            if(stk.Peek()!='#') s1.Append(stk.Pop());
            else stk.Pop();
        }
        for(int i=s.Length-1; i>=0; i--){
            if(s[i]=='#') stk.Push('#');
            else if(stk.Count>0 && s[i]!='#' && stk.Peek()=='#') stk.Pop();
            else stk.Push(s[i]);
        }
        while(stk.Count>0) {
            if(stk.Peek()!='#') s2.Append(stk.Pop());
            else stk.Pop();
        }
        if(s1.ToString().Equals(s2.ToString())) return true;
        return false;

    }
}