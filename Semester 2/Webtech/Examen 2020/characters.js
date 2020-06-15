let sBaseUrl = "http://rickandmortyapi.com/api/";
let sType = "character/";

const queryString = window.location.search;
const searchParams = new URLSearchParams(queryString);
const charID = searchParams.get("charID");
if ( charID != null ) { searchCharacter(charID) }

searchCharacters();

function searchCharacters(){
    getJSON(sBaseUrl + sType, (oData) => {
        var aResults = oData.results;
        processCharactersData(aResults);
    })
}

function processCharactersData(aCharacters){
    aCharacters.forEach(oCharacter => {
        $("#characterCards").append('\
        <div class="col-sm">\
        <div class="card" style="width: 18rem;">\
            <img class="card-img-top" src="' + oCharacter.image + '" alt="Character image">\
            <div class="card-body">\
                <h5 class="card-title">' + oCharacter.name + '</h5>\
                <p class="card-text">Gender: ' + oCharacter.gender + '</p>\
                <p class="card-text">Status: ' + oCharacter.status + '</p>\
                <p class="card-text">Specied: ' + oCharacter.species + '</p>\
                <p class="card-text">Origin: <a id="characterOrigin_' + oCharacter.id + '">' + oCharacter.origin.name + '</a></p>\
                <p class="card-text">Location: <a id="characterLocation_' + oCharacter.id + '">' + oCharacter.location.name + '</a></p>\
                <p class="card-text">Episodes character played in: </p>\
                <ul class="list-group" id="episodeList_' + oCharacter.id + '"></ul>\
            </div>\
        </div>\
        </div>');

        getJSON(oCharacter.origin.url, (oData) => {
            $("#characterOrigin_" + oCharacter.id).attr("href", "./locations.html?locID=" + oData.id);
        });
        getJSON(oCharacter.location.url, (oData) => {
            $("#characterLocation_" + oCharacter.id).attr("href", "./locations.html?locID=" + oData.id);
        });

        var aEpisodes = oCharacter.episode;
        aEpisodes.forEach(sEpisodeUrl => {
            getJSON(sEpisodeUrl, (oData) => {
                $("#episodeList_" + oCharacter.id).append('<li class="list-group-item">' + oData.name + '</li>'); 
            });
        });
    });
}

function getJSON(sUrl, callback){
    $.getJSON(sUrl)
        .done((oData) => {
            callback(oData);
        })
        .fail((oError) => {
            console.log(oError);
        });
}