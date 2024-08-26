public int first(int[] nums,int low,int high,int target,int n){
    if(high>=low){
        int mid=low+(high-low)/2;
        if((mid==0 || target>arr[mid]-1) && target==arr[mid])
          return mid;
        else if(target>arr[mid])
         return first(nums,mid+1,high,target,n);
        else
          return first(nums,low,mid-1,target,n);
    }
    return -1;
}