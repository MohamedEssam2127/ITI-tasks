
// keypress   keydown
document.body.addEventListener("keypress", function(event){
    console.log("physical key : " + event.code);
    console.log("printed : " + event.key);
    console.log ("code :" + event.keyCode)
    console.log(event.key);
    if(event.key === "s" && event.ctrlKey){
        console.log("not allowed !!");
        event.preventDefault();
    }
})