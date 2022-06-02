let canvas = document.getElementById('canvas')
let ctx = canvas.getContext('2d')
let btnCreateElipse = document.querySelector('#createelipse')

btnCreateElipse.addEventListener('click', () => {
   let a = document.querySelector('#gorizontalvalue').value
   let b = document.querySelector('#verticalvalue').value

   ctx.clearRect(0, 0, canvas.width, canvas.height);

   ctx.beginPath();
   ctx.ellipse(200, 100, +a, +b, 0, 0, 2 * Math.PI);
   ctx.stroke();
})