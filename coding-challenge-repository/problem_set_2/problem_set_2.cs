using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge_repository.problem_set_2
{ 
    class ParenthesisChecker
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            foreach (char c in s)
            {
                if (bracketPairs.ContainsKey(c))
                {
                    char topElement = stack.Count > 0 ? stack.Pop() : '#';

                    if (topElement != bracketPairs[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            //Display
            Console.WriteLine("Parenthesis Checker \n");
            Console.WriteLine("Input String: " + s);
            Console.Write("Result: ");

            return stack.Count == 0;
        }
    }
}
