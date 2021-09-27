using Microsoft.AspNetCore.Mvc;
using Palindrome.Models;

namespace Palindrome.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/palindrome")]
    public ActionResult Palindrome(string word)
    {
      PalindromeTest palinTest = new PalindromeTest();
      bool palindromeCheck = palinTest.IsAPalindrome(word);
      PalindromeVariable palindromeVariable = new PalindromeVariable();
      palindromeVariable.IsAPalindrome = palindromeCheck;
      return View(palindromeVariable);
    }

  }
}