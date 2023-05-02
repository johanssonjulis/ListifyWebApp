// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const submitButton = document.getElementById("submitButton");
const placeholderForTasks = document.getElementById("placeholderForTasks");


submitButton.addEventListener("click", function (event) {
    event.preventDefault();
    submitButton.setAttribute("hidden", "true");
    const test = document.createElement("input");
    test.setAttribute("type", "text");
    placeholderForTasks.appendChild(test);
    const addTask = document.createElement("button");
    addTask.textContent = "Add task";
    placeholderForTasks.appendChild(addTask);
});
addTask.addEventListener("click", function (event) {
    event.preventDefault();
    test.value = "";
   
})