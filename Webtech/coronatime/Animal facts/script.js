function GetFact(sAnimalType){
    sUrl = "http://localhost:3030/cats/random?animal_type=";
    $.get(sUrl + sAnimalType, function(data){
        $("#fact").text(data.text);
    });
}