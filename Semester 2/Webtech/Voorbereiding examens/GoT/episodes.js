const sBaseUrl = "https://api.got.show/api/map/episodes/";

const queryString = window.location.search;
const searchParams = new URLSearchParams(queryString);
const data = searchParams.get("data");
if ( data != null ) { searchData(data) }


function searchEpisode(data){
    var sInput = $("#episodeInput").val();

    if(data != null)
        sInput = data;
    
    var bIsID = sInput.startsWith('5cc');
    console.log(bIsID);

    if(bIsID){
        getJSON(sBaseUrl + "byid/" + sInput, (oData) => {
            console.log(oData);
            processEpisodeData(oData.data, true);
        });
    } else {
        getJSON(sBaseUrl + sInput, (oData) => {
            processEpisodeData(oData.data, false);
        });
    }  
}

function processEpisodeData(oEpisode, bID){
    addEpisodeJumbotron(oEpisode, bID);

    var aCharacters = oEpisode.characters;
    aCharacters.forEach(oCharacter => {
        addCharacterToList(oCharacter);
    });
}

function addEpisodeJumbotron(oEpisode, bID){
    $("#episodeJumbotrons").html('\
    <div class="jumbotron" id="episodeJumbotron">\
        <h1>' + oEpisode.name + '</h1>\
        <p class="lead">Episode ID: ' + oEpisode._id + '</p>\
        <p class="lead">Director: ' + oEpisode.director + '</p>\
        <p class="lead">Air date: ' + oEpisode.airDate + '</p>\
        <p class="lead">Season: ' + oEpisode.season + ' Episode: ' + oEpisode.nr + '</p>\
        <p class="lead">Characters in this episode: </p>\
        <ul class="list-group" id="episodeCharacterList"></ul>\
    </div>');

    if(!bID){
        $("#episodeJumbotron").append('\
        <p class="lead">Previous episode: ' + oEpisode.predecessor + '</p>\
        <p class="lead">Next episode: ' + oEpisode.successor + '</p>');
    }
}

function addCharacterToList(oCharacter){
    $("#episodeCharacterList").append('<li class="list-group-item">' + oCharacter + '</li>');
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