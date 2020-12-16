//var mybutton = document.querySelector(".Design_font");
//window.onscroll = function() {
//    matrixFunction() //or scroll function--
//};

//function matrixFunction() {
//    debugger
//    if (document.body.scrollTop > 900 || document.documentElement.scrollTop > 900) {
//        mybutton.style.display = "block";
//    } else {
//        mybutton.style.display = "none";
//    }
//}

function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
};

//bar 

jQuery('.main-bar').click(function(e) {
    jQuery(this).toggleClass('activefile');
    e.preventDefault();
    jQuery('#myHeader').slideToggle();
});


// search--click
//function searchFn() {
//    var Font = document.getElementById("Font_table");
//    if (Font.style.display === "none") {
//       Font.style.display = "block";
//    } else {
//       Font.style.display = "none";
//    }
//   }

////----copy--text----

//function copyFn() {
//    debugger
//    var copyText = document.getElementsById("copycontent"");
//        debugger
//    copyText.select();
//    copyText.setSelectionRange(0, 99999)
//    document.execCommand("copy");
//    alert("Copied the text: " + copyText.value);
//  }