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
      string expected = "pillow";
      string output = testPalindrome.PalindromeMethod();
      Assert.Equal(expected, output);
    }
  }
}
