/*
The set [1, 2, 3, ..., n] contains a total of n! unique permutations.

By listing and labeling all of the permutations in order, we get the following sequence for n = 3:

"123"
"132"
"213"
"231"
"312"
"321"
Given n and k, return the kth permutation sequence.

 

Example 1:

Input: n = 3, k = 3
Output: "213"
Example 2:

Input: n = 4, k = 9
Output: "2314"
Example 3:

Input: n = 3, k = 1
Output: "123"

*/
public class GetPermutation
{
    public string GetPermutationCal(int n, int k) {
        int fact = 1;
        List<int> numbers = new List <int>();
        for (int i = 1; i < n; i++) {
            fact = fact * i;
            numbers.Add(i);
        }
        numbers.Add(n);
        String ans = "";
        k = k - 1;
        while (true) {
            ans = ans + "" + numbers[k / fact];
            numbers.RemoveAt(k / fact);
            if (numbers.Count == 0) {
                break;
            }

            k = k % fact;
            fact = fact / numbers.Count;
        }
        return ans;

    }
   
}