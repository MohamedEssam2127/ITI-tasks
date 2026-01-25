
$(document).ready(function () {
    let sections = $('.section');

let aboutBtn = $('.btn').eq(0)
aboutBtn.on('click',function (){
    sections.hide()
    $('#about').show()
})

let galaryBtn = $('.btn').eq(1)
galaryBtn.on('click',function (){
     sections.hide()
    $('#galary').show()
})

let servicesBtn = $('.btn').eq(2);
servicesBtn.on('click', function () {
    if ($('#services').is(':visible')) {
        $('#services').slideUp(400);
    } else {
        sections.hide();
        $('#services').show();
        $('.service').hide();
        $('.service').each(function(index) {
            $(this).delay(index * 200).slideDown(400);
        });
    }
});


let complainDivBtn = $('.btn').eq(3)
complainDivBtn.on('click',function (){
     sections.hide()
    $('#complain_div').show()
})
////////// Galary 
let imgIndex =1  
let leftArrow = $('#left')
let rightArrow = $('#right')

leftArrow.on('click', function () {
     $('#slide').fadeOut(400, function () {
        if (imgIndex > 1) {
            imgIndex--;
        } else {
            imgIndex = 8;
        }
         $('#slide').attr('src', 'images/' + imgIndex + '.jpg');
         $('#slide').fadeIn(400);
    });
});

rightArrow.on('click', function () {
    $('#slide').fadeOut(400, function () {
        if (imgIndex < 8) {
            imgIndex++;
        } else {
            imgIndex = 1;
        }
        $('#slide').attr('src', 'images/' + imgIndex + '.jpg');
        $('#slide').fadeIn(400);
    });
});



$('#send').on('click', function() {
    $('#res_name').text($('#name').val());
    $('#res_email').text($('#email').val());
    $('#res_phone').text($('#phone').val());
    $('#res_complain').text($('#complain').val());

    $('#complain_div').hide();
    $('#result_div').show();
});

$('#back').on('click', function() {
    $('#result_div').hide();
    $('#complain_div').show();
});








})
