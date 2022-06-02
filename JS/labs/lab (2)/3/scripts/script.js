// var myFont = document.querySelectorAll('.myclass');

var myLight = document.querySelector("img")

// myLight[1].style.display = "none";
// myLight[2].style.display = "none";
// var j = 0;
// setInterval(
//   function () {
//     if (j == 0) {
//       j++;
//       myLight[0].style.display = "none";
//       myLight[1].style.display = "block";
//     }
//     else if (j == 1) {
//       j++;
//       myLight[1].style.display = "none";
//       myLight[2].style.display = "block";
//     } else if (j == 2) {
//       j = 0;
//       myLight[2].style.display = "none";
//       myLight[0].style.display = "block";
//     }
//   }, 2000
// )



var j = 0;
setInterval(
  function () {
    if (j == 0) {
      j++;
      myLight.src = "img/l2_erase.png";
    }
    else if (j == 1) {
      j++;
      myLight.src = "img/l3_erase.png";
    } else if (j == 2) {
      j = 0;
      myLight.src = "img/l1_erase.png";
    }
  }, 2000
)



