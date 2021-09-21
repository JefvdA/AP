const express = require('express')
const Uitslag = require('../Service/Uitslag')
const Uitslagen = require('../Service/UitslagService')
var router = express.Router()

router.get('/', (req, res) => {
    res.send(Uitslagen)
})

router.post('/:doelpunten', (req, res) => {
    const input = req.params.doelpunten

    let results = []
    for (let i = 0; i < Uitslagen.length; i++) {
        const uitslag = Uitslagen[i];
        if((uitslag.scoreThuis + uitslag.scoreOut) == input)
            results.push(uitslag)
    }

    res.send(results)
})

module.exports = router