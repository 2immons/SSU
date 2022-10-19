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

let offset = 0;
const sliderLine = document.querySelector('.slider-line');

document.querySelector('.slider-next').addEventListener('click', function(){
   offset = offset + 900;
   if (offset > 2700) {
       offset = 0;
   }
   sliderLine.style.left = -offset + 'px';
})

document.querySelector('.slider-prev').addEventListener('click', function(){
   offset = offset - 900;
   if (offset < 0) {
      offset = 2700;
   }
   sliderLine.style.left = -offset + 'px';
})

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
