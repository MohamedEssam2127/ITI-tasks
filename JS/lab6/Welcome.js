function display () {
    let img  = document.getElementById("welcome_img");
    let favColor  = getCookie("menu")
    let username  = document.getElementById("welcome_name");
    let numberOfSign= document.getElementById("welcome_number");
    let userFromCookie = getCookie("userName")
    img.src= getCookie('gender')==="male"?"assets/1.jpg":'assets/2.jpg'
    username.style.color=favColor
    numberOfSign.style.color= favColor
    username.textContent=userFromCookie
    numberOfSign.textContent =  getCookie("numofLogin "+userFromCookie)
}
display()