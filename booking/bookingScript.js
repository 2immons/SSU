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
   if (table.is(e2.target)) {
      tableId = e2.target.id;
      let element = document.getElementById(tableId);
      if (element.classList.contains("table__free")) {
         element.classList.add("table__occupied");
         element.classList.remove("table__free");
      }
   }
})

// модал
let closeBtn = $('.close-btn');
let openBtn = $('.open-btn');
let submitBtn = $('.submit-btn');
let popupBody = $('.popup__body');
let popup = $('.popup');

$(document).on("click", function(e){
   if (closeBtn.is(e.target)) {
      popup.removeClass('_active');
   }
   if (submitBtn.is(e.target) || (popupBody.is(e.target))) {
      popup.removeClass('_active');
   }
})

$(document).on("click", function(e){
   if (openBtn.is(e.target)) {
      popup.addClass('_active');
   }
})
