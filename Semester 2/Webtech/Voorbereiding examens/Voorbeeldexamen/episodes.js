function getEpisodeInformation(){
    var sUrl = "https://api.got.show/api/map/episodes";
    var sEpisode = $("#episodeInput").val();
    $.getJSON(sUrl)
        .done((oData) => {
            var aEpisodes = oData.data
            aEpisodes.forEach(episode => {
                var isnum = /^\d+$/.test(sEpisode);
                if(isnum){
                    if(episode.totalNr == sEpisode){
                        var aCharacters = episode.characters
                        $("#episodeJumbotron").html('<div class="jumbotron"><h1>' + episode.name + '</h1><p>Directed by: ' + episode.director + '</p><p>Airdate: ' + episode.airDate + '</p><p>Season: ' + episode.season + ', Episode: ' + episode.nr + '</p><p>Characters:</p><ul id="episodeCharacterList"></ul></div>')
                        aCharacters.forEach(character => {
                            $("#episodeCharacterList").append("<li>" + character + "</li>")
                        });
                    }
                } else {
                    if(episode.name == sEpisode){
                        var aCharacters = episode.characters
                        $("#episodeJumbotron").html('<div class="jumbotron"><h1>' + episode.name + '</h1><p>Directed by: ' + episode.director + '</p><p>Airdate: ' + episode.airDate + '</p><p>Season: ' + episode.season + ', Episode: ' + episode.nr + '</p><p>Characters:</p><ul id="episodeCharacterList"></ul><p>Previous episode:' + getEpisodeName(episode.nr - 1) + '</p><p>Next episode: ' + getEpisodeName(episode.nr + 1) + '</div>')
                        aCharacters.forEach(character => {
                            $("#episodeCharacterList").append("<li>" + character + "</li>")
                        });
                    }
                }
            });
        })
}

function getEpisodeName(nID){
    var sUrl = "https://api.got.show/api/map/episodes";
    $.getJSON(sUrl)
        .done((oData) => {
            var aEpisodes = oData.data
            aEpisodes.forEach(episode => {
                if(episode.nr == nID){
                    return episode
                }
            });
        })
}