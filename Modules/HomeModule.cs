using Nancy;
using PalindromeChecker.Objects;
using System;
using System.Collections.Generic;

namespace PalindromeChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        string userInput = Request.Form["initial-word"];
        Palindrome newPalindrome = new Palindrome(userInput);
        string userOutput = newPalindrome.PalindromeMethod();
        return View["index.cshtml", userOutput];
      };
    }
  }
}
