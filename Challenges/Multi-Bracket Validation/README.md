## Code Challenge
Multi-bracket Validation.

## What is the challenge?
Creating a method that will take a string as its only argument, and will return a boolean representing whether or not the brackets
in the string are balanced. There are 3 types of brackets:

1. Round Brackets : ()
2. Square Brackets : []
3. Curly Brackets : {}

## Approach
The utilization of a stack in this problem domain was used to return True or False, whether the string contained a perfect bracket matching sequence or not.
A class Stack and Node were built out, with methods of Pop(), Push(), and Peek() utilized for the stack class. The Node class was built out to give us a Value and a Next.
This problem domain involved using a char array to convert the string into individual characters, divided by commas for each charachter. Following
The char array a foreach looping mechanism was used to loop through each character and inside of that loop a swutch statement was utilized to
check if there was an opening bracket, if so push it to the stack. If it was a closing bracketg, it was then evaluated to the opening bracket in the top of stack.
If it was a reciprocating match we want to discard that character and pop the top of the stack, leving nothing in the stack. If there wasnt a match  the opening
bracket would stay in the stack and at the end of the looping mechanism if there was anything left in the stack that would return false, otherwise true. Done.


## What will the outcome look like?
![Demo](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/Multi-Bracket%20Validation/MultiBracketValidation/assets/Capture.PNG)
![Whiteboard](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/Multi-Bracket%20Validation/MultiBracketValidation/assets/20190124_183051.jpg)

## Unit Testing

![Testing](https://github.com/Bigrig72/data_structures_and_algorithms_401/blob/master/Challenges/Multi-Bracket%20Validation/MultiBracketValidation/assets/testing.PNG)
