function getCharactersByLocation(){
    var sUrl = "https://api.got.show/api/map/characterlocations"
    var sLocation = $("#locationInput").val()
    var oCharacters = $("#charactersList")
    oCharacters.html("")
    $.getJSON(sUrl)
        .done((oData) => {
            for(i = 0; i < oData.data.length; i++){
                if(oData.data[i].locations.includes(sLocation)){
                    oCharacters.append("<p>" + oData.data[i].name + "</p>")
                }
            }
        });
}