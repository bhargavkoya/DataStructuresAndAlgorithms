/*
In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]

*/
public class Generate
{
    public IList<IList<int>> GenerateCal(int numRows) {
        var res=new List<IList<int>>();
        if(numRows ==0) return res;
        res.Add(new List<int>(){1});
         for(int i=1;i<numRows;i++){
             var prev_row=res[i-1];
             List<int> current_row=new List<int>();
             current_row.Add(1);
             for(int j=1;j<i;j++){
                 current_row.Add(prev_row[j-1]+prev_row[j]);
             }
             current_row.Add(1);
             res.Add(current_row);
         }       
        
        return res;
    }
}