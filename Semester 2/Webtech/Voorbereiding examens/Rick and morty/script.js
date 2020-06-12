var sBaseURL = "https://rickandmortyapi.com/api/";


function getCharacterInfo(){
    //Declare type ( character, location, episode )
    var sType = "character/";

    var sInput = $("#characterInput").val();

    $.getJSON(sBaseURL + sType)
        .done((oData) => {
            var oCharacters = oData.results;
            oCharacters.forEach(character => {
                var isnum = /^\d+$/.test(sInput);
                if(isnum){
                    if(character.id == sInput){
                        makeCharacterCard(character)
                    }
                } else {
                    if(character.name == sInput){
                        makeCharacterCard(character)
                    }
                }
            });
        })
        .fail((oError) => {
            alert("Something went wrong, check your spelling. If you are still not sure, check the console")
            console.log(oError)
        });
}

function makeCharacterCard(sCharacter){
    $("#characterCard").html('<div class="card" style="width: 18rem;"><img class="card-img-top" src="' + sCharacter.image + '" alt="Sorry, couldnt find image for this character"><div class="card-body"><h5 class="card-title">' + sCharacter.name + '</h5><p class="card-text">Species: ' + sCharacter.species + '</p><p class="card-text">Gender: ' + sCharacter.gender + '</p><p class="card-text">Origin: ' + sCharacter.origin.name + '</p><p class="card-text">Location: ' + sCharacter.location.name + '</p></div></div>');
}


function getLocationInfo(){
    //Declare type ( character, location, episode )
    var sType = "location/"

    $.getJSON(sBaseURL + sType)
        .done((odata) => {

        })
        .fail((oError) => {
            alert("Something went wrong, check your spelling. If you are still not sure, check the console")
            console.log(oError)
        });
}


function getEpisodeInfo(){
    //Declare type ( character, location, episode )
    var sType = "episode/"

    $.getJSON(sBaseURL + sType)
        .done((odata) => {

        })
        .fail((oError) => {
            alert("Something went wrong, check your spelling. If you are still not sure, check the console")
            console.log(oError)
        });
    }