const express = require("express")

const app = express()

app.listen(3000, (err) => {
    if(err)
        console.log(err)
    console.log('listening on port 3000')
})

app.get("/", (req, res) => {
    res.send("hello stranger")
})