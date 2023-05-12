// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const addTaskButton = document.getElementById("addTaskButton");
const placeHolder = document.getElementById("placeholderForTasks");

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
/* When the user clicks on the button,
toggle between hiding and showing the dropdown content */
function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown menu if the user clicks outside of it
window.onclick = function (event) {
    if (!event.target.matches('.dropbtn')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}