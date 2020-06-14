var sBaseURL = "https://rickandmortyapi.com/api/";


const queryString = window.location.search;
const urlParams = new URLSearchParams(queryString);
const charID = urlParams.get("charID");
const locName = urlParams.get("locName");
const epiID = urlParams.get("epiID");

if(charID != null){ getCharacterInfo(charID) }
if(locName != null) { getLocationInfo(locName) }
if(epiID != null) { getEpisodeInfo(epiID) }


function getCharacterInfo(nCharID){
    //Declare type ( character, location, episode )
    var sType = "character/";

    var sInput = $("#characterInput").val();

    if(nCharID != null){
        sInput = parseInt(nCharID);
    }
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
                    makeCharacterCard(result);
                });
            })
            .fail((oError) => {
                alert("Something went wrong, check your spelling. If you are still not sure, check the console");
                console.log(oError);
            });
    }
}

function makeCharacterCard(oCharacter){
    $("#characterCard").append('<div class="card" style="width: 18rem;"><img class="card-img-top" src="' + oCharacter.image + '" alt="Sorry, couldnt find image for this character"><div class="card-body"><h5 class="card-title">' + oCharacter.name + '</h5><p class="card-text">ID: ' + oCharacter.id + '<p class="card-text">Species: ' + oCharacter.species + '</p><p class="card-text">Gender: ' + oCharacter.gender + '</p><p class="card-text">Status: ' + oCharacter.status + '</p><a class="card-text" href="./locations.html?locName=' + oCharacter.origin.name + '">Origin: ' + oCharacter.origin.name + '</a></br><a class="card-text" href="locations.html?locName=' + oCharacter.location.name + '">Location: ' + oCharacter.location.name + '</a></div></div>');
}



function getLocationInfo(sLocName){
    //Declare type ( character, location, episode )
    var sType = "location/";

    var sInput = $("#locationInput").val();

    if(sLocName != null){
        sInput = sLocName;
    }
    var bIsnum = /^\d+$/.test(sInput);

    if(bIsnum){
        $.getJSON(sBaseURL + sType + sInput)
        .done((oData) => {
            $("#locationJumbotron").html("");
            makeLocationJumbotron(oData);
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
            $("#locationJumbotron").html("");
            aResults.forEach(result => {
                makeLocationJumbotron(result);
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

function makeLocationJumbotron(oLocation){
    $("#locationJumbotron").append('<div class="jumbotron"><h1>' + oLocation.name + '</h1><p class="lead">Type: ' + oLocation.type + '</p><p class="lead">Dimension: ' + oLocation.dimension + '</p><p>Residents:</p><ul id="locationResidentList_' + oLocation.id + '"></ul></div>')
}

function addResidentToList(sResidentUrl, nLocationID){
    $.getJSON(sResidentUrl)
        .done((oData) => {
            var sResidentName = oData.name;
            var nResidentID = oData.id;
            $("#locationResidentList_" + nLocationID).append('<li class="list-group-item"><a href="./characters.html?charID=' + nResidentID + '">' + sResidentName + '</a></li>');
        })
        .fail((oError) => {
            console.log(oError);
        })
}


function getEpisodeInfo(nEpiID){
    //Declare type ( character, location, episode )
    var sType = "episode/";

    var sInput = $("#episodeInput").val();

    if(nEpiID != null) {
        sInput = parseInt(nEpiID);
    }
    var bIsnum = /^\d+$/.test(sInput);

    if(bIsnum){
        $.getJSON(sBaseURL + sType + sInput)
            .done((oData) => {
                $("#episodeJumbotron").html("");
                makeEpisodeJumbotron(oData);

                var aCharacters = oData.characters;
                aCharacters.forEach(character => {
                    addCharacterToList(character, oData.id);
                });
            })
            .fail((oError) => {
                alert("Sorry, could not find the episode, please check your input and try again. (For more info check the console)");
                console.log(oError);
            });
    } else {
        $.getJSON(sBaseURL + sType + "?name=" + sInput)
            .done((oData) => {
                $("#episodeJumbotron").html("")

                var aResults = oData.results;
                aResults.forEach(result => {
                    makeEpisodeJumbotron(result);

                    var aCharacters = result.characters;
                    aCharacters.forEach(character => {
                        addCharacterToList(character, result.id);
                    });
                });
            })
            .fail((oError) => {
                alert("Sorry, could not find the episode, please check your spelling and try again. (For more info check the console)");
                console.log(oError);
            });
    }
}

function makeEpisodeJumbotron(oEpisode){
    $("#episodeJumbotron").append('\
    <div class="jumbotron">\
        <h1>' + oEpisode.name + '</h1>\
        <p class="lead">Air date: ' + oEpisode.air_date + '</p>\
        <p class="lead">Episode: ' + oEpisode.episode + '</p>\
        <hr class="my-4">\
        <p>Characters in this episode</p>\
        <ul class="list-group" id="episodeCharacterList_' + oEpisode.id + '"></ul>\
    </div>');
}

function addCharacterToList(sCharacterUrl, nEpisodeID){
    $.getJSON(sCharacterUrl)
        .done((oData) => {
            var sCharacterName = oData.name;
            $("#episodeCharacterList_" + nEpisodeID).append('<li class="list-group-item"><a href="characters.html?charID=' + oData.id + '">' + sCharacterName + '</a></li>');
        })
        .fail((oError) => {
            console.log(oError);
        });
}