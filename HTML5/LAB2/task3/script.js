function  myLine () {
    let canv =  document.getElementById('canv');
    var x =10;
    var context = canv.getContext('2d');
    context.beginPath()
     var interval = setInterval(function (){
            if(x===500) clearInterval(interval)
            context.moveTo(0,0);
            context.lineTo(x,x);
            context.strokeStyle = "red"
            context.strokeWidth = 5
            context.stroke();
            x+=10;
        },200)
}
