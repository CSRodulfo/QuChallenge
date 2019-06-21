# QuChallenge

WORD FINDER	
The objective is to solve the proposal in the following way. I try with the least amount of iterations possible, but in case of iterating, I try to make the iteration have the least amount of logical conditions, in this way the high performance is the most important thing to solve.
I receive a matrix and convert it vector with all possible vertical and horizontal lines. Next, I use the strategy of type window to look up the word received
 
 <p align="center">
  <img src="https://csrodulfo.com.ar/wp-content/uploads/windows.png">
</p>
  
 If I find the word, I add it to the list and, finally, I resolve to group by and count the words found and return the first 10 most repeated
The architecture is very simple:
* API
* Services and Businesses
* Test

I don´t use DI or library (Ex: FluentValidation) I decided a simple paradigm of POO and principle SOLID

 <p align="center">
  <img src="https://csrodulfo.com.ar/wp-content/uploads/QuClass.png">
</p>

URL in Azure: http://qubeyond.azurewebsites.net/
