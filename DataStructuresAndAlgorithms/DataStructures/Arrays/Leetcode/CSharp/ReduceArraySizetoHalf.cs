/*
You are given an integer array arr. You can choose a set of integers and remove all the occurrences of these integers in the array.

Return the minimum size of the set so that at least half of the integers of the array are removed.

 

Example 1:

Input: arr = [3,3,3,3,5,5,5,2,2,7]
Output: 2
Explanation: Choosing {3,7} will make the new array [5,5,5,2,2] which has size 5 (i.e equal to half of the size of the old array).
Possible sets of size 2 are {3,5},{3,2},{5,2}.
Choosing set {2,7} is not possible as it will make the new array [3,3,3,3,5,5,5] which has a size greater than half of the size of the old array.
Example 2:

Input: arr = [7,7,7,7,7,7]
Output: 1
Explanation: The only possible set you can choose is {7}. This will make the new array empty.

*/
public class MinSetSize
{
    public int MinSetSizeCal(int[] arr) {
        Dictionary<int,int> dic=new Dictionary<int,int>();
        foreach(var i in arr){
            if(dic.ContainsKey(i)){
                dic[i]++;
            }
            else{
                dic.Add(i,1);
            }
        }
        
        int[] res=new int[dic.Count()];
        int ip=0;
        foreach(var item in dic){
            res[ip]=item.Value;
            ip++;
        }
        
        Array.Sort(res);
        Array.Reverse(res);
        
        int n=arr.Length;
        int sum=0;
        int count=0;
        while(n>arr.Length/2){
            
            count++;
            n-=res[sum++];
        }
        return count;
    }
}