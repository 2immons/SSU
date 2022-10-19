function showLoginForm() {
   document.getElementById('login-form').style.display = "flex";
   document.getElementById('login-form').style.flexDirection = "column";
   document.getElementById('register-form').style.display = "none"
}

function showRegisterForm() {
   document.getElementById('register-form').style.display = "flex";
   document.getElementById('register-form').style.flexDirection = "column";
   document.getElementById('login-form').style.display = "none"
}

// бургер:

let sideMenu = $('.side-menu');
let menuButton = $('.menu-button');
let menuButtonItem = $('.menu-button-item');

$(document).on("click", function(e){
   if ((menuButton.is(e.target) || menuButtonItem.is(e.target)) && !sideMenu.hasClass('_active')) {
      sideMenu.addClass('_active');
   }
   else if (((menuButton.is(e.target) || menuButtonItem.is(e.target)) && sideMenu.hasClass('_active')) || (!(menuButton.is(e.target) || menuButtonItem.is(e.target)) && sideMenu.has(e.target).length === 0 && sideMenu.hasClass('_active'))) {
      sideMenu.removeClass('_active');
   }
})

// бронь:

let table = $('.table');
let tableId = 0;

$(document).on("click", function(e2){
   if(!menuButton.is(e2.target)){
      document.getElementById("error").classList.remove("error__occupied");
   }
   if (table.is(e2.target)) {
      tableId = e2.target.id;
      let element = document.getElementById(tableId);
      if (element.classList.contains("table__free")) {
         element.classList.add("table__occupied");
         element.classList.remove("table__free");
         document.getElementById("booking-form").classList.add("_active");
         document.getElementById("booking-form-background").classList.add("_active");
         document.getElementById("body").classList.add("_inactive");
         // сделать чтобы нельзя было нажать куда-то еще
      }
      else {
         document.getElementById("error").classList.add("_active");
      }
   }
})