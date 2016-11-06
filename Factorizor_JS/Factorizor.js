(function() {
	function getUserNumber() {
		var userInput = prompt("What number do you want to factor?");
		var n = parseInt(userInput, 10);
		return n;
	}
	
	function buttonClick() {
		var n = getUserNumber(),
			perfect = 0,		
			arr = [],
			quotient = 0;
		
		if(isNaN(n)) {
			alert("Input was not a valid number!");
		}
		else if (n <= 0) {
			alert("You must use a positive number!")
		}
		else
		{
			for(var i = 1; i <= n; i++) {
				quotient = n/i;
				if(quotient === Math.floor(quotient)) {
					arr.push(i);
					perfect += quotient;
				}
			}
			if(n === perfect - n || n == 1) {
			alert("PERFECTION!");
			alert("There are " + arr.length + " factors of "+ n + "! \nThe factors are: \n" + arr.toString());
			}
			else {
				if (arr.length != 2){
				alert("Your number is: " + n + "!");
				alert("There are " + arr.length + " factors of "+ n + "! \nThe factors are: \n" + arr.toString());
				}
				else {			
				alert("Your number is: " + n + "!");
				alert("The only factors are: \n" + arr.toString() + "\n It is a prime number!");
				}
			}
		}
	}
	
	document.getElementById("btn").addEventListener("click", buttonClick);
})();
