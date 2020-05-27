function plus(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 + number2;
    $("#outputField").val(output);
}

function maal(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 * number2;
    $("#outputField").val(output);
}

function min(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 - number2;
    $("#outputField").val(output);
}

function delen(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 / number2;
    $("#outputField").val(output);
}

function getInput(){
    var number1 = parseInt($("#number1").val());
    var number2 = parseInt($("#number2").val());    

    return [number1, number2];
} 