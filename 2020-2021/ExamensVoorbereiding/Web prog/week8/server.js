const express = require('express')
const bp = require('body-parser')
const app = express()

app.use(bp.urlencoded({extended:false}))
app.use(bp.json())

let todo = ["Make todo list", "eat"]
let done = ["Brush teeth"]

app.get('/', (req, res) => {
    res.redirect('/todo')
})

app.get('/todo', (req, res) => {
    res.send(todo)
})

app.get('/done', (req, res) => {
    res.send(done)
})

app.post('/todo/add', (req, res) => {
    let body = req.body
    todo.push(body.todo)
    res.redirect('/todo')
})

app.delete('/todo/finish', (req, res) => {
    let body = req.body
    let todoToFinish = body.todoToFinish
    
    let index = todo.indexOf(todoToFinish)
    done.push(todo[index])
    todo.splice(index, index+1)

    res.redirect('/todo')
})

app.listen(8080, () => {
    console.log('server ready')
})