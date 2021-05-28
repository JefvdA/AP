const express = require('express')
const bp = require('body-parser')
const mysql = require('mysql')
const app = express()

app.use(bp.urlencoded({extended:false}))
app.use(bp.json())

const pool = mysql.createPool({
    connectionLimit : 10,
    host : "localhost",
    user : "root",
    password : "",
    database : "ekvoetbal"
})

app.get('/ploegen', (req, res) => {
    pool.getConnection((err, connection) => {
        if(err)
            throw err
        
        console.log(`Connected as id: ${connection.id}`)

        connection.query("select * from ploegen", (err, rows) => {
            connection.release()
            if(err)
                console.log(err)
            else
                res.send(rows)
        })
    })
})

app.get('/ploegen/:id', (req, res) => {
    pool.getConnection((err, connection) => {
        if(err)
            throw err
        
        const id = req.params.id
        connection.query(`select * from ploegen where id = ${id}`, (err, rows) => {
            connection.release()
            if(err)
                console.log(err)
            else
                res.send(rows)
        })
    })
})

app.get('/delete/ploegen/:id', (req, res) => {
    pool.getConnection((err, connection) => {
        if(err)
            throw err
        
        const id = req.params.id
        connection.query(`delete from ploegen where id = ${id}`, (err, rows) => {
            connection.release()
            if(err)
                console.log(err)
            else
                res.send(rows)
        })
    })
})

app.listen(3000, err => {
    if(err)
        console.log(err)
    console.log('Server runnning on port 3000')
})