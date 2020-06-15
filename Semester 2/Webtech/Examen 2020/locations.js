let sBaseUrl = "http://rickandmortyapi.com/api/";
let sType = "location/";

const queryString = window.location.search;
const searchParams = new URLSearchParams(queryString);
const locID = searchParams.get("locID");
if ( locID != null ) { searchLocation(locID) }

function searchLocation(nLocID){
    let sInput = $("#locationInput").val()

    if(nLocID != null)
        sInput = nLocID;
        
    let bIsNum = /^\d+$/.test(sInput);
    console.log(bIsNum);
    if(bIsNum){
        $("#locationCard").html("");
        getJSON(sBaseUrl + sType + sInput, (oData) => {
            processLocationData(oData);
        });
    }
}

function processLocationData(oLocation){
    var nLocationID = oLocation.id;
    addLocationCard(oLocation);

    var aResidents = oLocation.residents;
    aResidents.forEach(resident => {
        getJSON(resident, (oData) => {
            addResidentToList(oData, nLocationID);
        });
    });
}

function addLocationCard(oLocation){
    $("#locationCard").append('\
    <div class="card" style="width: 18rem;">\
        <div class="card-body">\
            <h5 class="card-title">' + oLocation.name + '</h5>\
            <p class="card-text">Type: ' + oLocation.type + '</p>\
            <p class="card-text">Dimension: ' + oLocation.dimension + '</p>\
        </div>\
    </div>');
}

function addResidentToList(oResident, nLocationID){
    $("#residentList_" + nLocationID).append('<li class="list-group-item"><a href="./characters.html?charID=' + oResident.id + '">' + oResident.name + '</a></li>');
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