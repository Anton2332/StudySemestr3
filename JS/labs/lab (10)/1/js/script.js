let img = document.querySelector('#imgchange')
let select = document.querySelector('#cars')

select.addEventListener('change', () => {
   img.src = `img/${select.options[select.selectedIndex].text.toLowerCase()}.jpg`
})