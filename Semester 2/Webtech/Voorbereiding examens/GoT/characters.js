const sBaseUrl = "https://api.got.show/api/show/characters/";
const sLocationsUrl = "https://api.got.show/api/map/characterlocations";

const queryString = window.location.search;
const searchParams = new URLSearchParams(queryString);
const data = searchParams.get("data");
if ( data != null ) { searchData(data) }


function searchCharacter(data){
    var sInput = $("#characterInput").val();

    if(data != null)
        sInput = data;
    
    getJSON(sBaseUrl + sInput, (oData) => {
        processCharacterData(oData);
    });
}

function processCharacterData(oCharacter){
    addCharacterCard(oCharacter);

    getJSON(sLocationsUrl, (oData) => {
        var aResults = oData.data;
        aResults.forEach(oResult => {
            if(oResult.name == oCharacter.name){
                var aLocations = oResult.locations;
                aLocations.forEach(oLocation => {
                    addLocationToList(oLocation);
                });
            }
        });
    });
}

function addCharacterCard(oCharacter){
    $("#characterCards").html('\
    <div class="card" style="width: 18rem;">\
        <img class="card-img-top" src="' + oCharacter.image + '" alt="Character image">\
        <div class="card-body">\
            <h5 class="card-title">' + oCharacter.name + '</h5>\
            <p class="card-text">Locations: <p>\
            <ul class="group-list" id="characterLocationList"></ul>\
        </div>\
    </div>')
}

function addLocationToList(oLocation){
    $("#characterLocationList").append('<li class="list-group-item"><a href="./locations.html?locName=' + oLocation + '">' + oLocation + '</a></li>');
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