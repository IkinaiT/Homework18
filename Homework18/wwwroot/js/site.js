// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function validation() {
    document.getElementById('submit-button').disabled =
        !(document.getElementById('mammal').checked ||
            document.getElementById('amphibian').checked ||
            document.getElementById('bird').checked ||
            document.getElementById('unknown').checked) ||
        document.getElementById('text-input-1').value == "" ||
        document.getElementById('text-input-2').value == "" ||
        document.getElementById('text-input-3').value == "" ||
        document.getElementById('text-input-4').value == "" ||
        document.getElementById('text-input-5').value == "" ||
        document.getElementById('text-input-6').value == "";
}