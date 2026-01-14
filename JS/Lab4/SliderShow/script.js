let counter  = 1;
let myTime 

function next () {
    let myImage =   document.getElementById("pics")
    if(counter < 6){
        counter++;
       myImage.src= "SlideShow/"+counter+".jpg"
    }
}

function prev(){
    let myImage =   document.getElementById("pics")
     if(counter >1){
        counter--;
       myImage.src= "SlideShow/"+counter+".jpg"
    }
}

function SlideShow () {
    let myImage =   document.getElementById("pics")
    if (! myTime){
        myTime =  setInterval(function () {
            if(counter < 6){
                counter++;
            }else {
                counter=1
            }
            myImage.src= "SlideShow/"+counter+".jpg"
            // console.log ("here")
        },900)
    }else {
        console.log("NOoooooo")
    }
}
function stop(){
    clearInterval(myTime)
    myTime= null
}