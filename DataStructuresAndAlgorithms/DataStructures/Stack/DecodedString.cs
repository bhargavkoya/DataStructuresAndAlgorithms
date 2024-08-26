/*
Given an encoded string, return its decoded string.

The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.

You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed, etc. Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there will not be input like 3a or 2[4].

The test cases are generated so that the length of the output will never exceed 105.

 

Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"

*/
public class Solution {
    public string DecodeString(string s) {
        int n = s.Length;

        int num = 0;

        Stack<StringBuilder> sb = new Stack<StringBuilder>();
        Stack<int> times = new Stack<int>();

        sb.Push(new StringBuilder());

        for(int i=0;i<n;i++)
        {
            char c = s[i];

            if(c=='[')
            {
                times.Push(num);
                sb.Push(new StringBuilder());
                num =0;
            }
            else if(c==']')
            {
                int time = times.Pop();
                String temp = sb.Pop().ToString();
                StringBuilder sbb = sb.Peek();
                while(time-->0) sbb.Append(temp);
            }
            else if(Char.IsDigit(c))
            {
                num = num * 10 + (c-'0');
            }
            else
            {
                sb.Peek().Append(c);
            }
        }

        return sb.Peek().ToString();

    }
}