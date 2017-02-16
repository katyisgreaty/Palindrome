using Nancy;
using System;
using System.Collections.Generic;

namespace PalindromeChecker.Objects
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
      int counter = 0;
      int half = _wordInput.Length/2;
      string result = "this word is not a palindrome";
      for (int i = 0; i <= half; i++)
      {
        if (_wordInput[i] == _wordInput[(_wordInput.Length-(i+1))])
        {
          counter++;
        }
      }
      if(counter >= half)
      {
        result = "true";
      }
      return result;
    }
  }
}
