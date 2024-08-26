public int last(int[] nums,int low,int high,int target,int n){
    if(high>=low){
        int mid=low+(high-low)/2;
        if((mid==n-1 || target<arr[mid]+1) && target==arr[mid])
          return mid;
        else if(target>arr[mid])
         return last(nums,mid+1,high,target,n);
        else
          return last(nums,low,mid-1,target,n);
    }
    return -1;
}