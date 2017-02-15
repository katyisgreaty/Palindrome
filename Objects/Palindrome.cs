using Nancy;
using System;
using System.Collections.Generic;

namespace Palindrome.Objects
{
  public class Palindrome
  {
    private string _wordInput;

    public Palindrome (string wordInput)
    {
      _wordInput = wordInput;
    }

    public string PalindromeMethod()
    {
      if (_wordInput[0] == _wordInput[(_wordInput.Length-1)])
      {
        return "true";
      }
      else
      {
        return "this word is not a palindrome";
      }
    }
  }
}
