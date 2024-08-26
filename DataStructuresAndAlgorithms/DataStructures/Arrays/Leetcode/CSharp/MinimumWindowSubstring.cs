/*
Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

A substring is a contiguous sequence of characters within the string.

 

Example 1:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
Example 2:

Input: s = "a", t = "a"
Output: "a"
Explanation: The entire string s is the minimum window.
Example 3:

Input: s = "a", t = "aa"
Output: ""
Explanation: Both 'a's from t must be included in the window.
Since the largest window of s only has one 'a', return empty string.

*/
public class MinWindow
{
  public string MinWindowCal(string searchString, string t)
  {
    // Creating Map for storing the frequency
    var requiredCharacters = buildMappingOfCharactersToOccurrences(t);
    var windowCharacterMapping = new Dictionary<char, int>();

    int left = 0;
    int right = 0;

    
    int totalCharFrequenciesToMatch = requiredCharacters.Count;
    int charFrequenciesInWindowThatMatch = 0;

    // This will store the minimum length of valid substring
    int minWindowLengthSeenSoFar = Int32.MaxValue;

     // It will store the actual substring
    String minWindow = "";

    // Here we calculate the ans using 2 pointer's approach
    while (right < searchString.Length) 
    {
      char characterAtRightPointer = searchString[right];
      addCharacterToHashtableMapping(windowCharacterMapping, characterAtRightPointer);

      bool rightCharIsARequirement = requiredCharacters.ContainsKey(characterAtRightPointer);
      if (rightCharIsARequirement) 
      {
        bool requirementForCharacterMet = requiredCharacters[characterAtRightPointer]
             == windowCharacterMapping[characterAtRightPointer];

        if (requirementForCharacterMet) 
        {
          charFrequenciesInWindowThatMatch++;
        }
      }

      while (charFrequenciesInWindowThatMatch == totalCharFrequenciesToMatch && left <= right) 
      {
        char characterAtLeftPointer = searchString[left];
        int windowSize = right - left + 1;

        if (windowSize < minWindowLengthSeenSoFar) 
        {
          minWindowLengthSeenSoFar = windowSize;
          minWindow = searchString.Substring(left, right + 1 - left);
        }

        windowCharacterMapping[characterAtLeftPointer] = windowCharacterMapping[characterAtLeftPointer] - 1;

        bool leftCharIsARequirement = requiredCharacters.ContainsKey(characterAtLeftPointer);
        if (leftCharIsARequirement) 
        {
          bool characterFailsRequirement = windowCharacterMapping[characterAtLeftPointer]
               < requiredCharacters[characterAtLeftPointer];

          if (characterFailsRequirement) 
          {
            charFrequenciesInWindowThatMatch--;
          }
        }

        left++;
      }

      right++;
    }

    return minWindow;
  }

  // Helper function for computing the character's frequency of a string
  private Dictionary<char, int> buildMappingOfCharactersToOccurrences(String s) 
  {
    var map = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++) 
    {
      int occurrencesOfCharacter = 0;
      if(map.ContainsKey(s[i]))
      {
        occurrencesOfCharacter = map[s[i]];
      }
      map[s[i]] = occurrencesOfCharacter + 1;
    }

    return map;
  }

  // Helper function to insert a character in the map
  private void addCharacterToHashtableMapping(Dictionary<char, int> map, char c) 
  {
    int occurrences= 0;
      if(map.ContainsKey(c))
      {
        occurrences = map[c];
      }
    map[c] = occurrences + 1;
  }
}
