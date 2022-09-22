/*
You are given a string s consisting of lowercase English letters, and an integer k.

First, convert s into an integer by replacing each letter with its position in the alphabet (i.e., replace 'a' with 1, 'b' with 2, ..., 'z' with 26). Then, transform the integer by replacing it with the sum of its digits. Repeat the transform operation k times in total.

For example, if s = "zbax" and k = 2, then the resulting integer would be 8 by the following operations:

Convert: "zbax" ➝ "(26)(2)(1)(24)" ➝ "262124" ➝ 262124
Transform #1: 262124 ➝ 2 + 6 + 2 + 1 + 2 + 4 ➝ 17
Transform #2: 17 ➝ 1 + 7 ➝ 8
Return the resulting integer after performing the operations described above.


*/
public class Solution {
    public int GetLucky(string s, int k) {
        int num =0;
        
         
        for(int i=0;i<s.Length;i++){
            int val = s[i]-96;
            if(val>=10)
                val=(val%10)+(val/10)%10;
            num+=val;
            
        }
        
    
        while(k>1){
            int sum=0;
            while(num!=0){
             sum += num%10;
             num/=10;   
            }
            num =sum;
            k--;
        }
            
        return num ;
        

    }
    
}