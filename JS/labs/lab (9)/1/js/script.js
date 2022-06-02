
let btn = document.querySelector('#sendzam')

btn.addEventListener('click', () => {

   let quantity = document.querySelector('.inputquantity')

   if (quantity.value == "") {
      quantity.style.borderColor = "red"
   } else {
      quantity.style.borderColor = "silver"
      let zam = document.querySelector('.zam')
      let thing = document.querySelector('#thing')
      let selectedThing = thing.options[thing.selectedIndex].text
      let material = document.querySelector('#matherial')
      let selectedMaterial = material.options[material.selectedIndex].text

      let result = `
      <div class="contzam">
         <p>Ваше замовлення прийнято</p>
         <p>Замовлено виріб - ${selectedThing}</p>
         <p>Матеріал - ${selectedMaterial}</p>
         <p>Кількість - ${quantity.value}</p>
      </div>
      `
      zam.innerHTML = ""
      zam.insertAdjacentHTML('beforeend', result)
   }



})
