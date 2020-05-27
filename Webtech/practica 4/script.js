var people = [
    Jef = new Person("Jef", "van der Avoirt", "28/03/2003"),
    Jan = new Person ("Jan", "Jansens", "01/01/1999"),
];

for(var i = 0; i < people.length; i++){
    console.table(people[i]);
}

function Person(voornaam, naam, geboortedatum){
    this.voornaam = voornaam;
    this.naam = naam;
    this.geboortedatum = geboortedatum;
};

function printPerson(oPerson){
    for(var prop in oPerson){
        console.log(prop + ": " + oPerson[prop]);
    }
}