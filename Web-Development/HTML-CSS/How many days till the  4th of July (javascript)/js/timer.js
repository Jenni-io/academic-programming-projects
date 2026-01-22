"use strict";

/*
   Chapter 9 Lab 1
   Filename: time.js

   Event Timer
   Author: Jenni Morales Jeronimo
   Date:  4/4/2024
*/
   showClock();
   setInterval(showClock, 1000);

function showClock() {
   // creates new date object and gets the local data and time 
   var thisDay = new Date();
   var localDate = thisDay.toLocaleDateString();
   var localTime = thisDay.toLocaleTimeString();

   // passes the curent date and time to the HTML Elements 
   document.getElementById("currentTime").innerHTML = 
   "<span>" + localDate + "</span>" + "<span>" + localTime + "</span>";
   
   var j4Date = nextJuly4(thisDay);
   j4Date.setHours(21, 0, 0, 0);

   // Diffrence of seconds and also calculates the hrs min and seconds
   var days = (j4Date - thisDay)/(1000 * 60 * 60 * 24);
   var hrs = (days - Math.floor(days)) * 24;
   var mins = (hrs - Math.floor(hrs)) * 60;
   var secs = (mins - Math.floor(mins)) * 60;

// Passes the calculated countdown values to the HTML elements so they display on the page
   document.getElementById("dLeft").textContent = Math.floor(days);
   document.getElementById("hLeft").textContent = Math.floor(hrs);
   document.getElementById("mLeft").textContent = Math.floor(mins);
   document.getElementById("sLeft").textContent = Math.floor(secs);
   }


function nextJuly4(currentDate) {
   
   // Gets the future or current years 4th of JULY
   var cYear = currentDate.getFullYear();
   var jDate = new Date(cYear, 6, 4);
   
   if ((jDate - currentDate) < 0) {
      jDate.setFullYear(cYear + 1);
   }

   return jDate;
}

