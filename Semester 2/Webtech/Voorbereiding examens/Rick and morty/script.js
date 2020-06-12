var baseURL = "https://rickandmortyapi.com/api/";


function getCharacterInfo(){
    //Declare type ( character, location, episode )
    var type = "character/";

    var sInput = $("#characterInput").val();

    $.getJSON(baseURL + type)
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
        });
}

function makeCharacterCard(character){
    $("#characterCard").html('<div class="card" style="width: 18rem;"><img class="card-img-top" src="' + character.image + '" alt="Sorry, couldnt find image for this character"><div class="card-body"><h5 class="card-title">' + character.name + '</h5><p class="card-text">Species: ' + character.species + '</p><p class="card-text">Gender: ' + character.gender + '</p><p class="card-text">Origin: ' + character.origin.name + '</p><p class="card-text">Location: ' + character.location.name + '</p></div></div>');
}