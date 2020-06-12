function getLocationsByCharacter(){
    var sUrl = "https://api.got.show/api/map/characterlocations/"
    var sCharacter = $("#characterInput").val()
    $.getJSON(sUrl + sCharacter)
        .done((oData) => {
            var sUrl = "https://api.got.show/api/book/characters/"
            var aLocations = oData.data[0].locations
            $.getJSON(sUrl + sCharacter)
                .done((oData) => {
                    var sImgUrl = oData.image
                    $("#cardDiv").html('<div class="card" style="width: 18rem;"><img class="card-img-top" src="' + sImgUrl + '" alt="This character has no image, sorry"><div class="card-body"><h5 class="card-title" id="characterName">' +  sCharacter + '</h5><p class="card-text">Characters locations<p><ul id="characterLocationList"></ul></div>')
                    aLocations.forEach(location => {
                        $("#characterLocationList").append("<li>" + location + "</li>")
                    });
            });
        })
}