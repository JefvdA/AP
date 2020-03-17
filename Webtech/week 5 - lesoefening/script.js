function plus(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 + number2;
    document.getElementById("outputField").innerHTML = output;
}

function maal(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 * number2;
    document.getElementById("outputField").innerHTML = output;
}

function min(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 - number2;
    document.getElementById("outputField").innerHTML = output;
}

function delen(){
    var numbers = getInput();
    var number1 = numbers[0];
    var number2 = numbers[1];

    var output = number1 / number2;
    document.getElementById("outputField").innerHTML = output;
}

function getInput(){
    var number1 = parseInt(document.getElementById("number1").value);
    var number2 = parseInt(document.getElementById("number2").value);

    return [number1, number2];
}