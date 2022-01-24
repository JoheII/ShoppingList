// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// $(".deactivateMe").on("click", function() 
//     {
//     if ($(this).children().prop('checked')) {
//         $(this).children().prop('checked', false);
//     }
//     else 
//     {
//         $(this).children().prop('checked', true);
//     }
// })

$(".addListElement").on("click", function() {
    console.log("hi");
    // $(this).siblings(".listMenu").after("<form><input type='checkbox' ID='addMe'><input type='text'><label for='addMe'></label></input></form>");
});

function addItemToList(listItem){
    console.log("sending list item from function " +listItem);
}

window.onload=function() {
    var addItem = document.getElementById("addItem");
    addItem.addEventListener('keypress', function(e){
        if(e.key === 'Enter'){
            var item = $("#addItem").val();
            addItemToList(item);
            console.log("Adding item to list: " +item);
        }
    });
}