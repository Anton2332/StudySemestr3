
let btn = document.querySelector('#btn')
btn.addEventListener('click', () => {

   let fun = document.querySelector("#func")
   let func = fun.options[fun.selectedIndex].text
   // let focus = window.open("pr1.html", "2")
   // focus.focus()
   let contResult = document.querySelector('.conteinerResult')

   let from = +document.querySelector('#from').value
   let to = +document.querySelector('#to').value
   let step = +document.querySelector('#step').value

   let arrGradus = []
   let arrRadian = []
   let arrResult = []

   for (let i = from; i <= to; i = i + step) {
      arrGradus.push(i)
      arrRadian.push(i * Math.PI / 180)
   }
   if (func == "sin") {
      for (let i = from; i <= to; i = i + step) {
         arrResult.push(Math.sin(i * Math.PI / 180))
      }
      contResult?.insertAdjacentHTML('beforeend', `<div class="box_func">sin</div>`)
   } else if (func == "cos") {
      for (let i = from; i <= to; i = i + step) {
         arrResult.push(Math.cos(i * Math.PI / 180))
      }
      contResult?.insertAdjacentHTML('beforeend', `<div class="box_func">cos</div>`)
   } else if (func == "tan") {
      for (let i = from; i <= to; i = i + step) {
         arrResult.push(Math.tan(i * Math.PI / 180))
      }
      contResult?.insertAdjacentHTML('beforeend', `<div class="box_func">tan</div>`)
   }

   for (let i = 0; i < arrResult.length; i++) {
      console.log(i);
      let result = `
            <div class="cont_info">
               <div class="box1">${arrGradus[i]}</div>
               <div class="box2">${arrRadian[i]}</div>
               <div class="box3">${arrResult[i]}</div>
            </div>
      `
      contResult?.insertAdjacentHTML('beforeend', result)
   }

})


