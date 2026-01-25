 

$(document).ready(function () {
    $('#car').animate(
{left : '1320px'},{
    duration:5000,
    easing:'linear',
    step:function (now ){
        let curr = Math.round(now)
        $('#txt').text('<img  src= "12.gif" style ="left = "'+curr +'px" > ')
    }
}
    )
})