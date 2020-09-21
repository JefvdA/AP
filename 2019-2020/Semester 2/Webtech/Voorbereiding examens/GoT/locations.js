const sBaseUrl = "https://api.got.show/api/map/characterlocations";

const queryString = window.location.search;
const searchParams = new URLSearchParams(queryString);
const locName = searchParams.get("locName");
if ( locName != null ) { searchLocation(locName) }


function searchLocation(locName){
    var sInput = $("#locationInput").val();
    var aCharacters = [];

    if(locName != null)
        sInput = locName;

    $("#locationJumbotrons").append('\
    <div class="jumbotron">\
        <h1>' + sInput + '</h1>\
        <p class="lead">Characters in this location: </p>\
        <ul class="list-group" id="characterList">\
        </ul>\
    </div>')

    getJSON(sBaseUrl, (oData) => {
        var aCharacters = oData.data;
        aCharacters.forEach(oCharacter => {
            if(oCharacter.locations.includes(sInput)){
                console.log(oCharacter.name);
                addCharacterToList(oCharacter);
            }
        });
    });
}

function addCharacterToList(oCharacter){
    $("#characterList").append('<li class="list-group-item">' + oCharacter.name + '</li>');
    console.log(oCharacter.name + " has been added to the list");
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