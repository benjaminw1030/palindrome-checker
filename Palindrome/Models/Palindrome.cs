using System;

namespace Palindrome.Models
{
  public class PalindromeTest
  {
    public bool IsAPalindrome(string word)
    {
      string lowerWord = word.ToLower();
      char[] array = lowerWord.ToCharArray();
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] != array[(array.Length - 1) - i])
        {
          return false;
        }
      }
      return true;
    }
  }

  public class PalindromeVariable
  {
    public bool IsAPalindrome { get; set; }
  }
}