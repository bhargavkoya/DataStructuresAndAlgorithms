/*
You are given an array of binary strings strs and two integers m and n.

Return the size of the largest subset of strs such that there are at most m 0's and n 1's in the subset.

A set x is a subset of a set y if all elements of x are also elements of y.

 

Example 1:

Input: strs = ["10","0001","111001","1","0"], m = 5, n = 3
Output: 4
Explanation: The largest subset with at most 5 0's and 3 1's is {"10", "0001", "1", "0"}, so the answer is 4.
Other valid but smaller subsets include {"0001", "1"} and {"10", "1", "0"}.
{"111001"} is an invalid subset because it contains 4 1's, greater than the maximum of 3.
Example 2:

Input: strs = ["10","0","1"], m = 1, n = 1
Output: 2
Explanation: The largest subset is {"0", "1"}, so the answer is 2.
*/


public class FindMaxForm
{
    int[,,] dp;
    public int FindMaxFormCal(string[] strs, int m, int n) {
        dp=new int[m+1,n+1,strs.Length];
        for(int i=0;i<m+1;i++){
            for(int j=0;j<n+1;j++){
                for(int k=0;k<strs.Length;k++){
                    dp[i,j,k]=-1;
                }
            }
        }
        return findMax(strs,m,n,0);
    }
    int findMax(string[] strs,int m,int n,int index){
        if(index==strs.Length) return 0;
        if(dp[m,n,index]!=-1) return dp[m,n,index];
        int countzeros=0;
        for(int i=0;i<strs[index].Length;i++){
            if(strs[index][i]=='0')
                countzeros+=1;
        }
        int countones=strs[index].Length-countzeros;
        
        if(m-countzeros>=0 && n-countones>=0){
            return dp[m,n,index]=Math.Max(1+findMax(strs,m-countzeros,n-countones,index+1),findMax(strs,m,n,index+1));
        }
        
        return dp[m,n,index]=findMax(strs,m,n,index+1);
    }
}