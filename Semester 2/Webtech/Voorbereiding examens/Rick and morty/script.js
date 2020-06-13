var sBaseURL = "https://rickandmortyapi.com/api/";


function getCharacterInfo(){
    //Declare type ( character, location, episode )
    var sType = "character/";

    var sInput = $("#characterInput").val();
    var bIsnum = /^\d+$/.test(sInput);

    if(bIsnum){
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

function makeCharacterCard(oCharacter){
    $("#characterCard").append('<div class="card" style="width: 18rem;"><img class="card-img-top" src="' + oCharacter.image + '" alt="Sorry, couldnt find image for this character"><div class="card-body"><h5 class="card-title">' + oCharacter.name + '</h5><p class="card-text">ID: ' + oCharacter.id + '<p class="card-text">Species: ' + oCharacter.species + '</p><p class="card-text">Gender: ' + oCharacter.gender + '</p><p class="card-text">Status: ' + oCharacter.status + '<p class="card-text">Origin: ' + oCharacter.origin.name + '</p><p class="card-text">Location: ' + oCharacter.location.name + '</p></div></div>');
}


function getLocationInfo(){
    //Declare type ( character, location, episode )
    var sType = "location/";

    var sInput = $("#locationInput").val();
    var bIsnum = /^\d+$/.test(sInput);

    if(bIsnum){
        $.getJSON(sBaseURL + sType + sInput)
        .done((oData) => {
            $("#locationCard").html("");
            makeLocationCard(oData);
            var aResidents = oData.residents;
            aResidents.forEach(resident => {
                addResidentToList(resident, oData.id);
            });
        })
        .fail((oError) => {
            alert("Something went wrong, check your spelling. If you are still not sure, check the console");
            console.log(oError);
        });
    } else {
        $.getJSON(sBaseURL + sType + "?name=" + sInput)
        .done((oData) => {
            var aResults = oData.results;
            $("#locationCard").html("");
            aResults.forEach(result => {
                makeLocationCard(result);
                var aResidents = result.residents;
                aResidents.forEach(resident => {
                    addResidentToList(resident, result.id);
                });
            });
        })
        .fail((oError) => {
            alert("Something went wrong, check your spelling. If you are still not sure, check the console");
            console.log(oError);
        });
    }   
}

function makeLocationCard(oLocation){
    $("#locationCard").append('<div class="card" style="width: 18rem;"><div class="card-body"><h5 class="card-title">' + oLocation.name + '</h5><p class="card-text">ID: ' + oLocation.id + '</p><p class="card-text">Type: ' + oLocation.type + '<p><p class="card-text">Dimension: ' + oLocation.dimension + '<p><p class="card-text">Residents:<p><ul class="list-group" id="locationResidentList_' + oLocation.id + '"></ul></div></div>')
}

function addResidentToList(sResidentUrl, nLocationID){
    $.getJSON(sResidentUrl)
        .done((oData) => {
            var sResidentName = oData.name
            $("#locationResidentList_" + nLocationID).append('<ul class="list-group-item">' + sResidentName + '</ul>');
            console.log("#locationResidentList_" + nLocationID);
        })
        .fail((oError) => {
            console.log(oError);
        })
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