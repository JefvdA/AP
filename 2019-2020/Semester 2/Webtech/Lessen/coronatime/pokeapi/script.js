let sBaseUrl = "https://pokeapi.co/api/v2/pokemon/",
oCharRegex = RegExp("^[A-z]*$"),
oIntRegex = RegExp("^[0-9]*$");


function onPageLoad(){
    getPokemon("pikachu");
}

function getUserInput() {
    sInput = prompt("Pokemon name OR pokemon ID: ", "Charmander OR 4");

    if(sInput === null){

    } else if(sInput === ''){
        alert("Please enter something, it's quite hard to find a pokémon otherwise!");
    } else if(sInput.indexOf(" ") >= 0){
        alert("Please don't use spaces, try again!");
    } else if(!oCharRegex.test(sInput) && !oIntRegex.test(sInput)){
        alert("Don't use characters and numbers at the same time please!");
    } else {
        getPokemon(sInput.toLowerCase());
    }
}

function getPokemon(sInput) { 
    $.get('https://pokeapi.co/api/v2/pokemon/' + sInput, function(data){
        $("#name").text(capFirstChar(data.name));
        $("#height").text(data.height);
        $("#weigth").text(data.weight);
        $("#type").text(getTypes(data.types));
        $("#pokePicture").attr('src', getImageUrl(data.id));
    });
}

function getImageUrl(sId) {
    let sImgUrl = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/",
    sImgExt = ".png",
    sImgId = sId.toString();
    while(sImgId.length < 3){
        sImgId = 0 + sImgId;
    }
    return sImgUrl + sImgId + sImgExt;
}

function getTypes(aTypes) {
    let sTypes = "";
    aTypes.forEach(type => {
        if(sTypes.length == 0){
            sTypes = capFirstChar(type.type.name);
        } else {
            sTypes = sTypes + ', ' + capFirstChar(type.type.name);
        }
    });
    return sTypes;
}

function capFirstChar(sText) {
    return sText[0].toUpperCase() + sText.slice(1);
}