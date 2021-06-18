const express = require('express')
const bp = require('body-parser')
const mysql = require("mysql")

const app = express()
app.use(bp.urlencoded({extended:false}))
app.use(bp.json())

const pool = mysql.createPool({
    connectionLimit :10, 
    host            : "localhost",
    user            : "root",
    password        : "",
    database        : "reis"  //specifieer db die je gebruikt
})

app.get('/trips', (req, res) => {
    pool.getConnection( (err, connection) => { // connecteren naar pool
        if(err)
            throw err
        connection.query("SELECT * FROM reizen", (err, rows) => { // je krijgt een error of rijen
            connection.release() // return to the connection pool
            if(!err)
                res.send(rows)
            else
                console.log(err)
        })
    })
})

app.get('/trips/:tripid', (req, res) => {
    pool.getConnection( (err, connection) => { // connecteren naar pool
        let tripid = req.params.tripid
        if(err)
            throw err
        connection.query(`SELECT kost FROM reizen WHERE id = '${tripid}'`, (err, rows) => { // je krijgt een error of rijen
            connection.release() // return to the connection pool
            if(!err)
                res.send(`De kost van de rijs met id=${tripid} is ${rows[0].kost}`)
            else
                console.log(err)
        })
    })
})

app.get('/kosten', (req, res) => {
    pool.getConnection( (err, connection) => { // connecteren naar pool
        if(err)
            throw err
        
        connection.query("SELECT sum(kost) FROM `reizen`", (err, rows) => { // je krijgt een error of rijen
            connection.release()
            res.send(`Your total cost is ${rows[0]['sum(kost)']}`)
        })
    })
})

app.post('/trips', (req, res) => {
    let newTrip = req.body;
    console.log(newTrip)
    pool.getConnection( (err, connection) => { // connecteren naar pool
        if(err)
            throw err
        
        connection.query(`INSERT INTO reizen values(${newTrip.id}, "${newTrip.naam}", ${newTrip.kost})`, (err, rows) => { // je krijgt een error of rijen
            connection.release()
            if(!err)
                res.redirect('/trips')
            else
                console.log(err)
        })
    })
})

app.listen(8080, () => {
    console.log('server ready')
})