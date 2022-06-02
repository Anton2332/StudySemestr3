let square = document.querySelector('#square');

let listener = function (e) {
   if (e.pageX < 450 && e.pageY < 450 && e.pageX > 50 && e.pageY > 50) {
      square.style.left = e.pageX - 50 + "px";
      square.style.top = e.pageY - 50 + "px";

   }
   else {
      document.removeEventListener('mousemove', listener);
   }
}

let flag = 0;
square.addEventListener('click', () => {
   if (flag % 2 == 0) {
      square.addEventListener('mousemove', listener);
      flag++;
   } else {
      square.removeEventListener('mousemove', listener);
      flag++;
   }
})
