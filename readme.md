# Fizz Buzz Implementation Without Conditionals

This code demonstrates a possible Fizz Buzz Kata implementation without using if conditionals and instead working with dictionaries.

The code was implemented via TDD to initially produce the obvious solution using if 
statements and afterwards refactored step-by-step to remove all conditionals and replace them with setting up dictionaries for producing the result.

This solution is only demonstrating alternative implementation approaches and is by way not trying to provide the most efficient nor most readable or maintainable code :-)

***Note***: the amount of data-driven test cases should usually of course not be necessary and are rather provided to demonstrate to the reader that the solution works ;-) 

# Excercise 1 - Make the code even simpler

Considering that the requirements are set in stone will not, think of how this code could be simplified while still not using any conditionals or loops.

# Excercise 2 - Make the code extensible

How could we make the code extensible so that you can easily define different or new words to be called for different numbers.

E.g. calling "Moo" if the number is divisible by 7 and calling "FizzBuzzMoo" if it is divisible by 3, 5 and 7.

To do so we shall follow the open closed principle so it should be able to set this up without modifying the inners of the FizzBuzz class.

Is it even possible to achieve this without conditionals?
I don't know, let's find out 😉

***Note:*** feel free to refactor from this code or start the solution from scratch.
The tests will surve as a safety net to tell you when you went wrong.
