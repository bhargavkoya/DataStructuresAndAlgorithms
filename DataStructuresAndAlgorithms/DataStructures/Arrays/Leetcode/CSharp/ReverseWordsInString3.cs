/*
Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

 

Example 1:

Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Example 2:

Input: s = "God Ding"
Output: "doG gniD"

*/
public class ReverseWords
{
    public string ReverseWordsCal(string s) {
        char[] chars = s.ToCharArray();

        int start = 0;
        int end;
        for (end = 0; end <= chars.Length; end++) {
            // When 'end' reaches a space character ' ', reverse the words from 'start' to 'end' - 1 index in 'chars'.
            if (end == chars.Length || chars[end] == ' ') {
                reverse(chars, start, end - 1);
                // reset the start for the next word.
                start = end + 1;
            }
        }

        return new String(chars);

    }
    
    public void reverse(char[] c, int start, int end) {
        while (start < end) {
            char tmp = c[end];
            c[end] = c[start];
            c[start] = tmp;
            start++;
            end--;
        }
    }

}