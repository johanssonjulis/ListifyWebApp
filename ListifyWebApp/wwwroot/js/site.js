// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const addTaskButton = document.getElementById("addTaskButton");
const placeHolder = document.getElementById("placeholderForTasks");

addTaskButton.addEventListener("click", function (event) {
    event.preventDefault();
    let container = document.createElement("div");
  
    let nextinput = document.createElement("input");
    nextinput.setAttribute("name", "task");
    placeHolder.append(container);
   
    container.appendChild(nextinput);

});