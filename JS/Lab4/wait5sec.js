
function wait5sec () {
    let wait5 = new Date().getTime()+5000
    console.log("start ")
    let flag = true ;
    while(flag){
        if(new Date().getTime() > wait5){
             flag =false
        }
    }
    console.log("finsh")
}

// typingMessage()
wait5sec()