/*
Given a positive integer n, find the smallest integer which has exactly the same digits existing in the integer n and is greater in value than n. If no such positive integer exists, return -1.

Note that the returned integer should fit in 32-bit integer, if there is a valid answer but it does not fit in 32-bit integer, return -1.

 

Example 1:

Input: n = 12
Output: 21
Example 2:

Input: n = 21
Output: -1

*/
public class NextGreaterElementThree
{
     private void swap(char[] arr, int i, int j){
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
        
    private void reverse(char[] arr, int i, int j){
        while(i<j)
            swap(arr, i++, j--);
    }
   
    public int NextGreaterElementCal(int n) {
        
        
    
        char[] arr =n.ToString().ToCharArray();
        
        //int n = arr.length;
        int i = arr.Length-2;
        while(i >= 0 && arr[i+1] <= arr[i])
            i--;
        
        if(i<0)
            return -1;
        
        int j = arr.Length-1;
        while(j>=0 && arr[j] <= arr[i]){
            j--;
        }
        
        swap(arr, i, j);
        
        reverse(arr, i+1, arr.Length-1);
        
        long result = long.Parse(new String(arr));
        
        return result > Int32.MaxValue ? -1 : (int) result;  

    }
    
}