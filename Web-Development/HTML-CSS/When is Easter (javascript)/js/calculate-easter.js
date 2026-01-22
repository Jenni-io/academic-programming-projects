"use strict";
/*
   Chapter 9 Lab 2
   Filename: calculate-easter.js

   When is Easter? JavaScript File
   Author:  Jenni Morales Jeronimo
	 Date:   4/9/2024  
*/

// Function to calculate what day Easter falls on
function calculateEaster() {
  // Clear any output text
  document.getElementById("result").innerText = "";

  // Get the year value entered by the user
  var year = parseInt(document.getElementById("year").value);
  
  // Check for invalid year values
  if (isNaN(year) || year <= 0) {
    // If year isn't valid, set focus to year textbox
    alert("Please enter a valid year.");
    document.getElementById("year").focus();
    document.getElementById("year").select();
    return;     // Stop executing script
  } // end if
  
  /* BEGIN CALCULATE EASTER BUSINESS LOGIC */

  var output = "";     // Holds output of Easter date calculation
  var a = year%19;
  var b = Math.floor(year/100);
  var c = year%100;
  var d = Math.floor(b/4);
  var e = b%4;
  var f = Math.floor((b + 8)/25);
  var g = Math.floor((b - f + 1)/3);
  var h = (19*a + b - d - g + 15)%30;
  var i = Math.floor(c/4);
  var k = c%4;
  var l = (32 + 2*e + 2 * i - h - k)%7;
  var m = Math.floor ((a + 11*h + 22*l)/451);
  var month = Math.floor((h + l - 7*m + 114)/31);
  var day = 1 + (h + l - 7*m + 114)%31 ;

// Easter can only land on March or April based on range given But if
// and error occures informs the user

  if (month == 3){
    month = "March"
  } else if (month == 4) {
    month = "April"
  } else {   
    alert("An error occured. Please enter another year.");
    document.getElementById("year").focus();
    document.getElementById("year").select();
    return;     // Stop executing script
}
  
  output += `${month} ${day}, ${year}`;

  /* END CALCULATE EASTER BUSINESS LOGIC */
  
  // Display the area
  document.getElementById("result").innerText = output;

  // Clear the year textbox and set focus to it for another entry
  document.getElementById("year").value = "";
  document.getElementById("year").focus();
} // end function

/* Keyboard event listener */
// Get the input field
var yearInput = document.getElementById("year");
// Executes a function when user presses a key on keyboard
yearInput.addEventListener("keypress", function(event) {
  // If user presses the "Enter" key...
  if (event.key === "Enter") {
    // Cancel default action, if needed
    event.preventDefault();
    // Programmatically trigger button click event
    document.getElementById("calculateEaster").click();
  } // end if
});