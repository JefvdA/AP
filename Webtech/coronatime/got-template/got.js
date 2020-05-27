var sUrl = "https://api.got.show/api/book/characters/";

function getData(sChar) {
  $.getJSON(sUrl + sChar, function(data){
    //Asign character information from API to variables
    var sImgUrl = data.image;
    var sName = data.name;
    var sAge = data.birth;
    var sGender = data.gender;
    var sHouse = data.house;
    var aChildren = data.children;
    var sChildren = "";
   
    if(aChildren.length === 0){ //Don't just display empty line, tell user the character has no children
      sChildren = "None";
    } else { //Character has children, display them seperated by ', '
      sChildren = aChildren.join(', ');
    }

    //Variable that stores html lines for the card
    var sCard = 
    '<br> \
    <div class="card" style="width: 18rem; margin-top: 25px"> \
      <img class="card-img-top" src=' + sImgUrl + ' alt="Card image cap"> \
      <div class="card-body">\
        <h5 class="card-title">' + sName + '</h5>\
        <p class="card-text">Age: '+ sAge + '</p>\
        <p class="card-text">Gender: '+ sGender + '</p>\
        <p class="card-text">House: '+ sHouse + '</p>\
        <p class="card-text">Children: ' + sChildren + '</p>\
      </div>\
    </div>'
    
    //Add the card in the div with id = character
    $("#character").html(sCard);
  });
}

function getCharacter() {
  var sChar = $("#charactername").val();
  if (sChar !== undefined) {
    getData(sChar);
  }
}