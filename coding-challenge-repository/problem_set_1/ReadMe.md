
#Problem Set 1 : Palindrome pairs
##Discription:
            Given a list of unique words, your task is to find all pairs of distinct
 indices (i, j) in the list so that the concatenation of the two words, i.e., words[i] + words[j], forms a palindrome.

##Solution: 
            There are two main functions, IsPalindrome it is where it checks if the concatenation actually is a palindrome and the next function contains where the pairing of elements into a list happens.
         IsPalindrome : It functions as checking the left side and the right side letter by letter and its not the same letter it returns false and true if its the same.
         PalindromePairs: It loops around the array, pairing it with the next value in the array. if the concatenated is checked that it returns true then the indexes of the concatenated values are added to the list which then returned as a result of List within List.

##Instructions to Run the Code
             Running the project runs Program.cs and activates this class.
