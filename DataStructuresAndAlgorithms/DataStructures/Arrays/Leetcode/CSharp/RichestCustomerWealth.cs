public class MaximumWealth
{
    public int MaximumWealthCal(int[][] accounts) {
        int max=0;
        if(accounts.Length==0){
            return 0;
        }
        for(int i=0;i<accounts.Length;i++){
            int sum=0;
            for(int j=0;j<accounts[i].Length;j++){
                sum=sum+accounts[i][j];
            }
            Console.Write(sum);
            if(sum>=max){
                max=sum;
            }
        }
        return max;
    }
}