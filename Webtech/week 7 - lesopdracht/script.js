function SearchRecipe(){
    //Zorgen dat alles leeg is
    $('.clear').html('');

    var input = $('#inputField').val();

    //database raadplegen en code uitvoeren
    $.get('https://797018ed-47c8-4ebe-8bde-b8cf9586d45e-bluemix.cloudant.com/recipes_complete/_design/views/_view/recipeSearch?key="' + input + '"' , function(data){
        if(data.rows[0] == null){
            $('#foutMelding').text('Sorry maar dit gerecht is niet gevonden. Check spelling.');
            return;
        }

        var ingredients = data.rows[0].value.ingredients;
        var directions = data.rows[0].value.directions;

        $('#title').text(input);

        //Deel voor ingredienten te tonen
        $('#ingredientsTitle').text('ingredients');
        ingredients.forEach(ingredient => {
            $('#ingredients').append('<li>' + ingredient.name + ' (' + ingredient.quantity + ' ' + ingredient.unit + ')' + '</li>');
        });

        //Deel voor directions te tonen
        $('#directionsTitle').text('directions');
        directions.forEach(direction => {
            $('#directions').append('<li>' + direction + '</li>');
        });
    });
}