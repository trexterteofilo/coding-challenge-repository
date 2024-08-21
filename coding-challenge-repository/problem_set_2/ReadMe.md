#Problem Set 2 : Valid Parenthesis
##Discription:
            Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is
valid. An input string is valid if:
1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.


##Solution: 
            isValid method contains Stack and Dictionary to optimize containing and comparing of characters. its main function is to loop through the inputted string and checks if the character is in the Dictionary and impliments LIFO principle which is used to match brackets. If an open bracket is encountered it gets push to the stack and pops if it encounters paired closing bracket and returns false if that condition is not met.

##Instructions to Run the Code
             Running the project runs Program.cs and activates this class.
