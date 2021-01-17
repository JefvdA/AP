var express = require('express');
var router = express.Router();
const MongoClient = require('mongodb').MongoClient;
var db;

MongoClient.connect('mongodb://127.0.0.1:27017', { useUnifiedTopology: true }, (err, database) => {
    if (err) return console.log(err);
    db = database.db('products');

    /* GET ALL PRODUCTS */
    router.get('/', (req, res) => {
        db.collection('items').find().toArray((err, result) => {
            if (err) return;
            res.json(result);
        });
    });

    /* ADD A PRODUCT */
    router.post('/add', (req, res) => {
        db.collection('items').insertOne(req.body, () => {
            res.json('{"succes": "ok"}');
        });
    })

    /* SEARCH PRODUCTS */
    router.post('/searchAll', (req, res) => {
        var query = { name: new RegExp('^' + req.body.name) }
        db.collection('items').find(query).toArray((err, result) => {
            if(err) return;
            res.json(result);
        });
    });

    /* SEARCH ONE PRODUCT */
    router.post('/searchOne', (req, res) => {
        var query = { name: req.body.name }
        db.collection('items').find(query).toArray((err, result) => {
            if(err) return
            res.json(result);
        });
    });

    /* DELETE A PRODUCT */
    router.delete('/delete/:name', (req, res) => {
        db.collection('items').findOneAndDelete({ name: req.params.name });
    });

    /* EDIT A PRODUCT */
    router.post('/edit', (req, res) => {
        db.collection('items').replaceOne({ name: req.body.name }, req.body);
    });
});

module.exports = router;
    