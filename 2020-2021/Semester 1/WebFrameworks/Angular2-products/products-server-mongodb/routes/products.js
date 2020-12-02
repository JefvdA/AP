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

    /* SEARCH A PRODUCT */
    router.post('/search', (req, res) => {
        //var query = { name: req.body.name }
        var query = { name : new RegExp('^' + req.body.name) }
        db.collection('items').find(query).toArray((err, result) => {
         if (err) return
         res.json(result);
       });
    });
});

module.exports = router;
    