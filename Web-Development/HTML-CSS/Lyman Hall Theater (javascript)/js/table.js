"use strict";

/*
   Chapter 10 Lab 1
   Filename: table.js

   Table JavaScript
   Author: Jenni Morales Jeronimo
   Date:   4/15/2024
*/

/*  This varable test the script*/
var thisDay = new Date("August 12, 2024");

/* The table varable contains the HTML code that will code the events table*/
var tableHTML = "<table id='eventTable'>";
   tableHTML += "<caption>Upcoming Events</caption>";
   tableHTML += "<tr><th>Date</th><th>Event</th><th>Prices</th></tr>";

   /* This varable list the events within the 14 day 
   period of the current date that was stated in the thisDay variable */
var endDate = new Date(thisDay.getTime() + 14 * 24 * 60 * 60 * 1000);

/* this for loop tells us that the i counters inital value is 0 
and should be less than the eventDates.lenth incrimenting by 1 */

for(var i = 0; i < eventDates.length; i++ ){
   var eventDate = new Date(eventDates[i]); 
   var eventDay = eventDate.toDateString();
   var eventTime = eventDate.toLocaleTimeString();

   /* The if statement test if the thisDay is less 
   than or equal to eventDate and endDate  and if the statements are true then it will 
   create a table row with table data containg the event day, time, descriptions, and prices.*/

if ((thisDay <= eventDate) && (eventDate <= endDate)) {
    tableHTML += "<tr>";
    tableHTML += "<td>" + eventDay + "@" + eventTime + "</td>";
    tableHTML += "<td>" + eventDescriptions[i] + "</td>";
    tableHTML += "<td>" + eventPrices[i] + "</td>";
    tableHTML += "</tr>";
}

}

/* This concatenate's the </table> tag to the end of the tableHTML variable */

tableHTML += "</table>";

/*  Now this should assign the tableHTML 
variable to the inner HTML elemt ID of eventList*/

document.getElementById("eventList").innerHTML = tableHTML;