let sBaseUrlName = "https://www.themealdb.com/api/json/v1/1/search.php";
let sBaseUrlID = "https://www.themealdb.com/api/json/v1/1/lookup.php";
let sBaseUrlRandom = "https://www.themealdb.com/api/json/v1/1/random.php";


function searchMeal(){
    var sInput = $("#mealInput").val();

    let bIsNum = /^\d+$/.test(sInput);

    if(bIsNum){
        getJSON(sBaseUrlID + '?i=' + sInput, (oData) => {
            var aMeals = oData.meals;
            processMealsData(aMeals);
        });
    } else {
        getJSON(sBaseUrlName + '?s=' + sInput, (oData) => {
            var aMeals = oData.meals;
            processMealsData(aMeals);
        });
    }
}

function searchRandomMeal(){
    getJSON(sBaseUrlRandom, (oData) => {
        var aMeals = oData.meals;
        processMealsData(aMeals);
    });
}

function processMealsData(aMeals){
    $("#mealCards").html("");
    aMeals.forEach(oMeal => {
        var nMealD = oMeal.idMeal;

        addMealCard(oMeal);

        //Ingredient list
        var aIngredients = [oMeal.strIngredient1, oMeal.strIngredient2, oMeal.strIngredient3, oMeal.strIngredient4, oMeal.strIngredient5, oMeal.strIngredient6, oMeal.strIngredient7, oMeal.strIngredient8, oMeal.strIngredient9, oMeal.strIngredient10, oMeal.strIngredient11, oMeal.strIngredient12, oMeal.strIngredient13, oMeal.strIngredient14, oMeal.strIngredient15, oMeal.strIngredient16, oMeal.strIngredient17, oMeal.strIngredient18, oMeal.strIngredient19, oMeal.strIngredient20];
        var aMeasures = [oMeal.strMeasure1, oMeal.strMeasure2, oMeal.strMeasure3, oMeal.strMeasure4, oMeal.strMeasure5, oMeal.strMeasure6, oMeal.strMeasure7, oMeal.strMeasure8, oMeal.strMeasure9, oMeal.strMeasure10, oMeal.strMeasure11, oMeal.strMeasure12, oMeal.strMeasure13, oMeal.strMeasure14, oMeal.strMeasure15, oMeal.strMeasure16, oMeal.strMeasure17, oMeal.strMeasure18, oMeal.strMeasure19, oMeal.strMeasure20];
        for(var i = 0; i < aIngredients.length; i++){
            if(aIngredients[i] == "")
                break;

            addIngredietToList(aIngredients[i], aMeasures[i],nMealD);
        }
    });
}

function addMealCard(oMeal){
    $("#mealCards").append('\
    <div class="card" style="width: 18rem;">\
        <img class="card-img-top" src="' + oMeal.strMealThumb + '" alt="Bootstrap-logo">\
        <div class="card-body">\
            <h5 class="card-title">' + oMeal.strMeal + '</h5>\
            <p class="card-text">MealID: ' + oMeal.idMeal + '</p>\
            <p class="card-text">Ingredients: <p>\
            <ul class="list-group" id="ingredientsList_' + oMeal.idMeal + '"></ul></br>\
            <a href="' + oMeal.strYoutube +'" class="btn btn-primary" role="button" target="_blank">Youtube video</a>\
        </div>\
    </div>');
}

function addIngredietToList(sIngredient, sMeasure, nMealID){
    $("#ingredientsList_" + nMealID).append('<li class="list-group-item">' + sMeasure + ' Of: ' + sIngredient + '</li>');
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