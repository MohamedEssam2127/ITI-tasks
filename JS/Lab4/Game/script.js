let firstImg =[];
let secondImg=[];
let counter =0;
let score =0;
let isProcessing = false;
function flip(id){
    if (isProcessing ||counter === 2) return; 
    let img = document.getElementById(id);
     if (counter === 1 && img === firstImg[1]) return;
    counter++
    let myId = id.split('.')[0]; 
    if (counter ===1 ){
        firstImg[0]= myId
        firstImg[1] = document.getElementById(id)
        firstImg[1].src = 'assets/'+myId+'.gif';
    }else if (counter ===2){
        secondImg[0]= myId
        secondImg[1]= document.getElementById(id)
        secondImg[1].src = 'assets/'+myId+'.gif'
        if(firstImg[0]!==secondImg[0]){
            setTimeout(function () {
                    isProcessing = true;
                    counter=0
                    firstImg[1].src ='assets/Moon.gif'
                    secondImg[1].src ='assets/Moon.gif'
                    isProcessing = false;
            } , 900)
        }else{
                document.getElementById("score").textContent=  ++score   
                counter = 0;
                isProcessing = false;
                if(score===6) { 
                    setTimeout( function () {
                          alert('congratulation !') 
                    },200)
                    RessetButton()
                }

        }
    } 
}

function shuffleImages() {
    let images = document.querySelectorAll('img');
    for (let i = 0; i < images.length; i++) {
        let j = Math.floor(Math.random() * images.length);
        let tempId = images[i].id;
        images[i].id = images[j].id;
        images[j].id = tempId;
    }
    for (let i = 0; i < images.length; i++) {
        images[i].onclick = function() {
            flip(this.id);
        };
    }
}

function RessetButton (){
    let images = document.images 
    counter =0;
    score =0
    firstImg=[]
    secondImg=[]
    for(let i = 0 ; i< images.length ;i++){
        images[i].src ='assets/Moon.gif'
    }
    document.getElementById("score").textContent= 0
    shuffleImages()
}




