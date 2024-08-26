/*
Given a string s, remove duplicate letters so that every letter appears once and only once. You must make sure your result is the smallest in lexicographical order among all possible results.

 

Example 1:

Input: s = "bcabc"
Output: "abc"
Example 2:

Input: s = "cbacdcbc"
Output: "acdb"

*/
public class Solution {
    public string RemoveDuplicateLetters(string s) {
        int len=s.Length;
    
        StringBuilder ans=new StringBuilder();

        Stack<char> st=new Stack<char>();
        Dictionary<char,int> fm=new Dictionary<char,int>();
        Dictionary<char,bool> vm=new Dictionary<char,bool>();

        for(int i=0;i<len;i++){
            char ch=s[i];
            if(fm.ContainsKey(ch))
                fm[ch]+=1;
            else
                fm.Add(ch,1);
        }

        foreach(char ch in fm.Keys){
            vm.Add(ch, false);
        }  

        for(int i=0;i<len;i++){
            char ch=s[i];
            fm[ch]-=1;

            if(vm[ch]){
                continue;
            }

            while(st.Count>0 && st.Peek()>ch && fm[st.Peek()]>0){
                char top=st.Pop();
                vm[top]=false;
            }

            st.Push(ch);
            vm[ch]=true;
        }


        while(st.Count>0){
            ans.Append(st.Pop());
        }

        
        string final="";
        for(int i=ans.Length-1;i>=0;i--){
            final+=ans[i];
        }
        

        return final; 

    }
}