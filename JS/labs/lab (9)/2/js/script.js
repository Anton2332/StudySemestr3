
let btn = document.querySelector('#sub')

btn.addEventListener('click', () => {
   let inpGrad = document.querySelector("#grad")

   let fun = document.querySelector("#func")
   let results = document.querySelector("#result")
   let conteiner = document.querySelector(".conteiner")
   let selectedFunc = fun.options[fun.selectedIndex].text
   results.innerHTML = ""
   if (inpGrad.value == "") {
      inpGrad.style.borderColor = "red"
   } else {

      inpGrad.style.borderColor = "silver"
      let grad = inpGrad.value;

      if (selectedFunc == "Синус") {
         let result = "sin(" + grad + "°) = " + Math.sin(grad * Math.PI / 180) + "  "
         conteiner.insertAdjacentText('beforeend', result)
      } else if (selectedFunc == "Косинус") {
         let result = "cos(" + grad + "°) = " + Math.cos(grad * Math.PI / 180) + "  "
         conteiner.insertAdjacentText('beforeend', result)
      } else if (selectedFunc == "Тангенс") {
         let result = "tan(" + grad + "°) = " + Math.tan(grad * Math.PI / 180) + "  "
         results.insertAdjacentText('beforeend', result)
      }
   }

})