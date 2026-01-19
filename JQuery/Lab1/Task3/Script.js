
let interval1 ;
let interval2 ;
let interval3 ;
let img1 = document.images[0]
    let leftPos = parseInt(getComputedStyle(img1).left)
    let flag1 = true ;

let img2 = document.images[1]
    let leftPos2 = parseInt(getComputedStyle(img2).left)
    let flag2 = false ;

let img3 = document.images[2]
    let leftPos3 = parseInt(getComputedStyle(img3).top)
    let flag3 = false ;

let mydiv = document.getElementsByClassName('content')[0];

let divWidth = parseInt(getComputedStyle(mydiv).width)
let divHeight = parseInt(getComputedStyle(mydiv).height)

function go () {
    if(!interval1 && ! interval2 && ! interval3 ){
 interval1 =setInterval(function(){

    if(flag1){
        leftPos+=50
    img1.style.left = leftPos+"px"
    if (leftPos>=divWidth-50){
        flag1 = false
    }
    }else{
        
         leftPos-=50
    img1.style.left = (leftPos)+"px"
    if(leftPos <=0){
        flag1 = true
    }
    }

},400)



  interval2 =setInterval(function(){

    if(flag2){
        leftPos2+=50
    img2.style.left = leftPos2+"px"
    if (leftPos2>=700){
        flag2 = false
    }
    }else{
        
         leftPos2-=50
    img2.style.left = (leftPos2)+"px"
    if(leftPos2 <=-10){
        flag2 = true
    }
    }

},400)


 interval3 =setInterval(function(){

    if(flag3){
        leftPos3+=50
    img3.style.top = leftPos3+"px"
    if (leftPos3>=450){
        flag3 = false
    }
    }else{
        
         leftPos3-=50
    img3.style.top = (leftPos3)+"px"
    if(leftPos3 <=0){
        flag3 = true
    }
    }

},400)




    }

}
function stop () {
    clearInterval(interval1)
    clearInterval(interval2)
    clearInterval(interval3)
    interval1=null
    interval2= null
    interval3= null
}