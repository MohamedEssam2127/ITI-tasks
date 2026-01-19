let img1 = document.getElementsByTagName('img')[0]

let img2 = img1.cloneNode()

img1.style.position = 'fixed'
img1.style.top = '0'
img1.style.right = '0'
img1.style.display='block'

img2.style.position = 'fixed'
img2.style.bottom ='0'
img2.style.left= '0'


document.body.append(img2)


let nav = document.getElementById('navigation')

nav.style.position = 'absolute'
nav.style.top = '40%'
nav.style.left = '50%'

let items = document.getElementsByTagName('li')

for (let i =0 ;i < items.length ;i++){
    items[i].style.listStyleType='circle';
}