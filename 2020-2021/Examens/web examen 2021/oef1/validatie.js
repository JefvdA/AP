function validate(username){
    if(username.length < 4)
        return false
    if(username[username.length-1] == "_")
        return false
    if(username.split(" ").length > 1)
        return false

    return true
}

console.log(validate('TomPeeters')) // Geldige username
console.log(validate("Tom")) // Ongeldige username
console.log(validate('TomPeeters_')) // Ongeldige username
console.log(validate('Tom Peeters')) // Ongeldige username
