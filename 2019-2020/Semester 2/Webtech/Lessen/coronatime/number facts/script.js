function GetFact(factType){
    $.get('http://numbersapi.com/random/' + factType, function(data){
        $('#fact').text(data);
    })
}