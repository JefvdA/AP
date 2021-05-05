const express = require("express")
const app = express()

trips = [{'id':0, 'cost':69}];

app.get("/trips", (req, res) => {
    res.send(JSON.stringify(trips))
})