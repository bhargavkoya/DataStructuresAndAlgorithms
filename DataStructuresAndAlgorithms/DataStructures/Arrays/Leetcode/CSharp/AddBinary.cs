/*Given two binary strings a and b, return their sum as a binary string.

 

Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
*/
public class AddBinary
{
    public string AddBinaryCal(string a, string b) {
        
       String sb = "";
        
        int i = a.Length - 1;
        int j = b.Length - 1;
    
        int sum = 0;
        int carry = 0;
        while (i >= 0 || j >= 0){
            //assign carry to sum as it will be added at each stage
            sum = carry;
            // add the value of the index character to the sum if index is greater than 0
            if (i >= 0) sum += a[i--]-'0';
            if (j >= 0) sum += b[j--]-'0';
            //evaluate carry
            carry = sum / 2;
            //append the mod value with BASE
            sb+=(sum % 2).ToString();
        }
        //if any carry left add to the final result
        if (carry != 0) sb+=(carry);
        //we reverse the string and return
        
        string res="";
        for(int k=sb.Length-1;k>=0;k--){
            res+=sb[k];
        }
        return res.ToString();

    }
}