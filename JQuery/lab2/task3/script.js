$(document).ready(function() {
    
    $('#bunny').draggable({
        start: function() {
            $(this).effect("shake", 100);
        }
    });

    $('#black').droppable({
        accept: "#bunny", 
        drop: function(event, ui) {
            $(ui.draggable).fadeOut(500);
        }
    });

});