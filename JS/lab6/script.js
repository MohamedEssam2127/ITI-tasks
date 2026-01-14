function push (){

    let userName = document.getElementById("username").value;
    let userAge = document.getElementById("userAge").value;
    let userColor = document.getElementById("menu");
    let color  = userColor.options[userColor.selectedIndex].text
    let gender = document.querySelector('input[name="gender"]:checked').value;
    let counter = getCookie("numofLogin "+userName )===null ? 0 : Number(getCookie("numofLogin "+userName ))
        let date = new Date()
        date.setMonth(date.getMonth()+2)
        setCookie("userName" ,userName,date)
        setCookie("userAge" ,userAge,date)
        setCookie("menu" ,color,date)
        setCookie("gender" ,gender,date)
        setCookie("numofLogin "+userName ,++counter,date)
    location.assign("welcome.html")
}


function sum() {
    if (arguments.length === 0) {
        throw new Error("sumNumbers cant be called without param");
    }

    let total = 0;
    for (let i = 0; i < arguments.length; i++) {
        if (typeof arguments[i] !== 'number') {
            throw new Error("data must be of type number only ");
        }
        total += arguments[i];
    }
    return total;
}