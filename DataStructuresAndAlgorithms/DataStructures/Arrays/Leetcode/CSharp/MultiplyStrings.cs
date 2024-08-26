/*
Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.

Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.

 

Example 1:

Input: num1 = "2", num2 = "3"
Output: "6"
Example 2:

Input: num1 = "123", num2 = "456"
Output: "56088"

*/
public class Multiply
{
    public string MultiplyCal(string num1, string num2) {
        string ans="";
        int[] v=new int[num1.Length+num2.Length];
        for(int i=num1.Length-1;i>-1;i--){
            for(int j=num2.Length-1;j>-1;j--){
                v[i+j+1]+=(num1[i]-'0')*(num2[j]-'0');
                v[i+j]+=v[i+j+1]/10;
                v[i+j+1]%=10;
            }
        }
        bool got=false;
        for(int i=0;i<v.Length;i++){
            if(!got && v[i]!=0) got=true;
            if(got) ans+=(v[i]).ToString();
        }
        if(ans.Length==0) return "0";
        return ans;

    }
}
        