feather.replace()
let sBaseUrl = "https://apapi.herokuapp.com/api/covid19/";

let types = [
    'New',
    'Total'
]

let labels = [
    'Confirmed',
    'Deaths',
    'Recovered'
]

function getSummary() {
    $.getJSON(sBaseUrl + '/csse-jhu/summary')
        .done(function(oData){
            console.log(oData.Global);
            fillTable(oData.Global);
        })
        .fail(function(oError){
            console.log(oError);
        });
}

function fillTable(oData) {
    //Assign number format to variable
    let oNumberFormat = new Intl.NumberFormat('nl-BE');

    //Add emtpy slot in label row
    $("#table-labels").append("<th></th>")

    //Add title for each label in label row
    labels.forEach(label => {
        $("#table-labels").append("<th class='text-right'>" + label + "</th>");
    });

    //Do stuff for eacht type of data (NEW - TOTAL)
    types.forEach(type => {
        //Add row for each type of data
        $("#table-rows").append('<tr id="' + type + '-row"><th>' + type + '</th></tr>')
        
        //Add correct data to correct row
        labels.forEach(label => {
            $('#' + type + '-row').append('<td class="text-right">' + oNumberFormat.format(oData[type + label]) + '</td>');
        })
    });
}

function fillCountryTable(aCountries, aLabels, sType) {

}

function capFirstChar(sText) {
  return sText[0].toUpperCase() + sText.slice(1);
}