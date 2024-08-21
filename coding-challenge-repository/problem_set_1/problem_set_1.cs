using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge_repository.problem_set_1
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        public List<List<int>> PalindromePairs(string[] words)
        {
            var result = new List<List<int>>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i != j)
                    {
                        string concatenated = words[i] + words[j];
                        if (IsPalindrome(concatenated))
                        {
                            result.Add(new List<int> { i, j });
                        }
                    }
                }
            }

            //Display
            Console.WriteLine("Parenthesis Checker \n");
            string wordsArray = string.Join(", ", words);
            Console.WriteLine("Input string: " + wordsArray);
            foreach (var pair in result)
            {
                Console.WriteLine($"[{pair[0]}, {pair[1]}]");
            }
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

            return result;
        }

    }
}
