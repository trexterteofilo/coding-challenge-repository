#Problem Set 3 : Longest increasing subsequence
##Discription:
            Given an unsorted array of integers, find the length of the longest increasing subsequence.



##Solution: 
            The method LengthOfLis returns the maximum number of length of longest increasing subsequence. this contains comparison of preceding and succeeding value in the array and using the DP for storing the amount of when the conditions are met. incases where the succeeding value is greater than the preceeding value then the value of dp is set depending who is greater from dp[i] or dp[j] + 1  then compared to the last maxLIS if the maxLIS needs to be updated. Using Math.Max also ensures we are getting the largest value in dp[i] and dp[j].

##Instructions to Run the Code
             Running the project runs Program.cs and activates this class.