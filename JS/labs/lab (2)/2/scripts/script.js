// var myFont = document.querySelectorAll('.myclass');

var myLight = document.querySelectorAll("img")
var myButton = document.querySelectorAll("button")

myLight[1].style.display = "none";

myButton[0].onclick = function () {
  myLight[0].style.display = "none";
  myLight[1].style.display = "block";
}

myButton[1].onclick = function () {
  myLight[1].style.display = "none";
  myLight[0].style.display = "block";
}
