public class ProductExceptSelf
{
    public int[] ProductExceptSelfCal(int[] nums) {
        int n=nums.Length;
        int[] result=new int[n];
        //prefix multiplication
        int prefix=1;
        int postfix=1;
        for(int i=0;i<nums.Length;i++){
            result[i]=prefix;
            prefix*=nums[i];
             //result[n-1-i]*=postfix;
            //postfix*=nums[n-1-i];

        }
        
        
        for(int j=nums.Length-1;j>=0;j--){
            result[j]*=postfix;
            postfix*=nums[j];
        }
        
        return result;
    }
}