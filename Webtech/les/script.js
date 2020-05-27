var cars = [];

for(var i=0; i < 2; i++){
    cars.push(function() {console.log('Car' + i);});
}

for (var k in cars) {
    cars[k]();
}