/*
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

 

Example 1:

Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]
Example 2:

Input: n = 1
Output: ["()"]

*/
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> res=new List<string>();
        Generate(res,n,0,0,"");
        return res;
    }
    public void Generate(List<string> res,int n, int open,int close,string currstr){
        if(currstr.Length==2*n){
            res.Add(currstr);
            return;
        }
        if(open<n) 
            Generate(res,n,open+1,close,currstr+"(");
        if(close<open)
            Generate(res,n,open,close+1,currstr+")");
    }
}