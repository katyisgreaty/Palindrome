using Xunit;
using System;
using System.Collections.Generic;

namespace Palindrome.Objects
{
  public class PalindromeTest
  {
    [Fact]
    public void Palindrome_ReturnInput_Input()
    {
      Palindrome testPalindrome = new Palindrome("pillow");
      string expected = "this word is not a palindrome";
      string output = testPalindrome.PalindromeMethod();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void Palindrome_ReturnTrueIfFirstLastSame_true()
    {
      Palindrome testPalindrome = new Palindrome("tendt");
      string expected = "true";
      string output = testPalindrome.PalindromeMethod();
      Assert.Equal(expected, output);
    }
  }
}
