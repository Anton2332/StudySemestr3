let ob = {
  "Стіл письмовий": {
    price: 12000,
    count: 5
  },
  "Стіл кухоний": {
    price: 8000,
    count: 10
  },
  "Стілець": {
    price: 20,
    count: 1200
  },
  "Шкаф книжний": {
    price: 14200,
    count: 4
  }
}

let contResult = document.querySelector('.conteinerResult')

let f = function () {
  contResult.innerHTML = ""
  let sum = 0
  let result = `
      <div class="cont_info">
        <div class="box1">Товар</div>
        <div class="box2">Ціна за штуку</div>
        <div class="box3">Кількість</div>
        <div class="box4">Сумарно</div>
      </div>
  `
  for (i in ob) {
    result += `
  <div class="cont_info">
    <div class="box1">${i}</div>
    <div class="box2">${ob[i].price}</div>
    <div class="box3">${ob[i].count}</div>
    <div class="box4">${ob[i].count * ob[i].price}</div>
  </div>
`
    sum += ob[i].count * ob[i].price
  }
  result += `
  <div class="cont_info">
  <div class="box">${"Підсумок"}</div>
  <div class="box4">${sum}</div>
</div>
  `
  contResult?.insertAdjacentHTML('beforeend', result)
}

f()

let btn = document.querySelector('#btn')
btn.addEventListener('click', () => {

  let fun = document.querySelector("#func")
  let func = fun.options[fun.selectedIndex].text

  let price = +document.querySelector('#price').value
  let count = +document.querySelector('#count').value
  console.log(price)
  if (Number(price) != 0 && Number(count) != 0) {
    ob[func].price = +price;
    ob[func].count = +count;
  }
  if (Number(price) == 0 && Number(count) != 0) {
    ob[func].count = +count;
  }
  if (Number(price) != 0 && Number(count) == 0) {
    ob[func].price = +price;
  }
  f()
}

)




