$(document).ready(function(){
    $("#zoomin").click(function(){
        var width = $("img").width();
        console.log(width);
        if(width < 300){
        $("img").animate({
            width : "+=20px",
            height : "+=20px",
        },10);
        }
    });

    $("#zoomout").click(function(){
        var width = $("img").width();
        console.log(width);
        if(width > 100){
        $("img").animate({
            width : "-=20px",
            height : "-=20px",
        },10);
        }
    });
});