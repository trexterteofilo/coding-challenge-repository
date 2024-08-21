using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge_repository.problem_set_3
{
    class LIS
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int n = nums.Length;
            int[] dp = new int[n];
            int maxLIS = 1;

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
                maxLIS = Math.Max(maxLIS, dp[i]);
            }

            //Display
            string numsArray = string.Join(", ", nums);
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            Console.WriteLine("Longest Incrasing Subsequence \n");
            Console.WriteLine("Array: " + numsArray);
            Console.WriteLine("LIS output: " + maxLIS);

            return maxLIS;
        }
    }
}
