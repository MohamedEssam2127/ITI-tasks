let childWin ;
let myTime ;

function openChildWindow () {
 childWin.onload = function() { //
        typingMessage();
    };
 
}
function typingMessage(){
    let message =" my message is hello "
    let myMessageId = childWin.document.getElementById('Mid');
    let counter = 0
    myMessageId.textContent = "";
    myTime = setInterval(function () {
        myMessageId.textContent += message.charAt(counter)
        if (counter === message.length){
              clearInterval(myTime)
              setTimeout( function () {
                childWin.close()
              },2000);
        }
          counter++;
    },100)
}

function startTask () {
    childWin  =  open('child.html', '', 'width=300,height=300')
    openChildWindow()
}


