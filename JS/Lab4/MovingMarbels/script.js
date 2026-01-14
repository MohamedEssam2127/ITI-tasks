let current = 0;
let myTime;
function move() {
    let images = document.images;
    images[current].src = "assets/marble3.jpg";
    myTime = setInterval(function () {
        images[current].src = "assets/marble1.jpg";
        current = (current + 1) % images.length;
        images[current].src = "assets/marble3.jpg";
    }, 500);
}

function stop () {
    clearInterval(myTime);
}
function reloadAgain (){
    move()
}