// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const addTaskButton = document.getElementById("addTaskButton");
const placeHolder = document.getElementById("placeholderForTasks");
const successMessage = document.getElementById("successMessage");
const saveButton = document.getElementById("saveButton");


addTaskButton.addEventListener("click", function (event) {
    event.preventDefault();
    let container = document.createElement("div");
    container.setAttribute("class", "inputForTask")
  
    let nextinput = document.createElement("input");
    nextinput.setAttribute("name", "task");
    nextinput.setAttribute("placeholder", "Task: ");
    
    placeHolder.append(container);
    container.appendChild(nextinput);

});
