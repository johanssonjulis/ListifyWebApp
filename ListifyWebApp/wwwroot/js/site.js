// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const addTaskButton = document.getElementById("addTaskButton");
const placeHolder = document.getElementById("placeholderForTasks");

addTaskButton.addEventListener("click", function (event) {
    event.preventDefault();
    let nextinput = document.createElement("input");
    nextinput.setAttribute("asp-for", "taskDescription");
    placeHolder.appendChild(nextinput);
    
})