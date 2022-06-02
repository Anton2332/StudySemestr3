let square = document.querySelector('#square');

anim(square)

function anim(square) {

   let radius = 100
   let x = 300
   let y = 200
   let time = 1
   let f = 0
   let s = 2 * Math.PI / 180
   setInterval(function () {
      f += s
      square.style.left = x + radius * Math.sin(f) + 'px'
      square.style.top = y + radius * Math.cos(f) + 'px'
   }, time)
}