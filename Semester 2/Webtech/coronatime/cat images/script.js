//Setup dropdown for all cat breeds
$.get("https://api.thecatapi.com/v1/breeds", function(data){
    data.forEach(cat => {
        $("#breed-dropdown").append("<button type='button' class='btn btn-link dropdown-item' onclick='FetchImage(\"" + cat.id + "\")'>" + cat.name + "</button>")
    });
});

function FetchImage(breed){
    //Setup loading icon etc...
    $("#loading").removeClass("invisible");
    $("#cat-image").addClass("invisible");

    //Search for all cat breeds
    if(breed == "all"){    
        $.get("https://api.thecatapi.com/v1/images/search", function(data){
        $("#loading").addClass("invisible");
        $("#cat-image").removeClass("invisible");
        $("#cat-image").attr("src", data[0].url);
        });
    } else { //Search for a specific breed
        $.get("https://api.thecatapi.com/v1/images/search?breed_ids=" + breed, function(data){
            $("#loading").addClass("invisible");
            $("#cat-image").removeClass("invisible");
            $("#cat-image").attr("src", data[0].url);
        });
    }
}