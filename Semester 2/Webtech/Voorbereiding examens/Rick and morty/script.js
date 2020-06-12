var sBaseURL = "https://rickandmortyapi.com/api/";


function getCharacterInfo(){
    //Declare type ( character, location, episode )
    var sType = "character/";

    var sInput = $("#characterInput").val();
    var isnum = /^\d+$/.test(sInput);

    if(isnum){
        $.getJSON(sBaseURL + sType + sInput)
            .done((oData) => {
                $("#characterCard").html("")
                makeCharacterCard(oData);
            })
            .fail((oError) => {
                alert("Something went wrong, check your spelling. If you are still not sure, check the console");
                console.log(oError);
            });
    } else {
        $.getJSON(sBaseURL + sType + "?name=" + sInput)
            .done((oData) => {
                var aResults = oData.results;
                $("#characterCard").html("")
                aResults.forEach(result => {
                    makeCharacterCard(result)
                });
            })
            .fail((oError) => {
                alert("Something went wrong, check your spelling. If you are still not sure, check the console");
                console.log(oError);
            });
    }
}

function makeCharacterCard(sCharacter){
    $("#characterCard").append('<div class="card" style="width: 18rem;"><img class="card-img-top" src="' + sCharacter.image + '" alt="Sorry, couldnt find image for this character"><div class="card-body"><h5 class="card-title">' + sCharacter.name + '</h5><p class="card-text">ID: ' + sCharacter.id + '<p class="card-text">Species: ' + sCharacter.species + '</p><p class="card-text">Gender: ' + sCharacter.gender + '</p><p class="card-text">Status: ' + sCharacter.status + '<p class="card-text">Origin: ' + sCharacter.origin.name + '</p><p class="card-text">Location: ' + sCharacter.location.name + '</p></div></div>');
}


function getLocationInfo(){
    //Declare type ( character, location, episode )
    var sType = "location/";

    var sInput = $("#locationInput").val();
    var isnum = /^\d+$/.test(sInput);

    if(isnum){
        $.getJSON(sBaseURL + sType + sInput)
        .done((oData) => {
            console.log(oData)
        })
        .fail((oError) => {
            alert("Something went wrong, check your spelling. If you are still not sure, check the console");
            console.log(oError);
        });
    } else {

    }
}


function getEpisodeInfo(){
    //Declare type ( character, location, episode )
    var sType = "episode/";

    $.getJSON(sBaseURL + sType)
        .done((oData) => {

        })
        .fail((oError) => {
            alert("Something went wrong, check your spelling. If you are still not sure, check the console");
            console.log(oError);
        });
    }