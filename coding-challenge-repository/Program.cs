using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coding_challenge_repository.problem_set_1;
using coding_challenge_repository.problem_set_2;
using coding_challenge_repository.problem_set_3;

namespace coding_challenge_repository
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeChecker palindromeChecker = new PalindromeChecker();
            ParenthesisChecker parenthesisChecker = new ParenthesisChecker();
            LIS _LIS = new LIS();

            //Problem set 1 Palindrome Pairs
            string[] words = { "bat", "tab", "cat" };
            List<List<int>> result = palindromeChecker.PalindromePairs(words);

            //Problem set 2 Parentheses Checker
            string inputString = "()[]{}";
            Console.WriteLine(parenthesisChecker.IsValid(inputString));

            //Problem set 3 Length of Increasing Subsequence
            int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
            int length = _LIS.LengthOfLIS(nums);

            Console.ReadLine();
        }
    }
}
