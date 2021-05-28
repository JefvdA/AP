const express = require("express")
const bp = require("body-parser")
const app = express()

trips = [{'id':0, 'costs':[20, 5, 2]}, {'id':1, 'costs':[8, 5, 67]}]

app.use(bp.json())
app.use(bp.urlencoded({ extended: true }))

app.get("/trips", (req, res) => {
    res.send(JSON.stringify(trips))
})

app.get("/kosten", (req, res) => {
    totalCost = 0
    trips.forEach(trip => {
        trip.costs.forEach(cost => {
            totalCost += cost
        });
    })
    res.send(JSON.stringify({'totalCost':totalCost}))
})

app.get("/trips/:tripId", (req, res) => {
    totalTripCost = 0

    tripId = req.params.tripId
    trips.find(trip => trip.id == tripId).costs.forEach(cost => {
        totalTripCost += cost
    })
    res.send(JSON.stringify({'totalTripCost':totalTripCost}))
})

app.post("/trips/:tripId", (req, res) => {
    cost = req.body.cost
    tripId = req.params.tripId
    console.log(`Adding cost (${cost}) to trip with id: ${tripId}`)

    trips.find(trip => trip.id == tripId).costs.push(cost)

    res.send({"message":"ok"})
})

app.post("/trips", (req, res) => {
    trip = req.body
    trips.push(trip)

    res.send({"message":"ok"})
})

app.listen(8080, () => console.log("server is running"))