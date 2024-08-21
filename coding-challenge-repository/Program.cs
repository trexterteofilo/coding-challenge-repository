using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coding_challenge_repository.problem_set_1;
using coding_challenge_repository.problem_set_2;

namespace coding_challenge_repository
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeChecker palindromeChecker = new PalindromeChecker();
            ParenthesisChecker parenthesisChecker = new ParenthesisChecker();

            //Problem set 1 Palindrome Pairs
            string[] words = { "bat", "tab", "cat" };
            List<List<int>> result = palindromeChecker.PalindromePairs(words);

            //Problem set 2 Parentheses Checker
            string inputString = "()[]{}";
            Console.WriteLine(parenthesisChecker.IsValid(inputString));
        }
    }
}
