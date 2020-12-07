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
<<<<<<< HEAD
            res.render('list.ejs', { products: result });
        });
    });

    /* SHOW ADD PRODUCT FORM */
    router.get('/add', (req, res) => {
        res.render('add.ejs', {});
    });

    /* ADD PRODUCT TO DB */
    router.post('/add', (req, res) => {
        db.collection('items').insertOne(req.body, (err, result) => {
            if (err) return;
            res.redirect('/');
        });
    });

    /* SEARCH FORM */
    router.get('/search', (req, res) => {
        res.render('search.ejs', {});
    });

    /* FIND A PRODUCT */
    router.post('/search', (req, res) => {
        var query = { name: req.body.name };
        db.collection('items').findOne(query, (err, result) => {
            if (err) return;
            if(result == '')
                res.render('search_not_found.ejs', {});
            else
                res.render('search_result.ejs', { product: result })
        });
    });

    /* DELETA A PRODUCT */
    router.post('/delete', (req, res) => {
        db.collection('items').findOneAndDelete({ id: req.body.id }, (err, result) => {
            if (err) return res.send(500, err);
            res.redirect('/');
        });
=======
            res.json(result);
        });
    });

    /* ADD PRODUCT */
    router.post('/add', (req, res) => {
        db.collection('items').insertOne(req.body);
    })

    /* SEARCH A PRODUCT */
    router.post('/searchAll', (req, res) => {
        //var query = { name: req.body.name }
        var query = { name : new RegExp('^' + req.body.name) }
        db.collection('items').find(query).toArray((err, result) => {
         if (err) return
         res.json(result);
       });
>>>>>>> 51e8452e714132173aa0bf9c264878be70d1d10a
    });

    /* SEARCH ONE PRODUCT */
    router.post('/searchOne', (req, res) => {
        var query = { name: req.body.name }
        db.collection('items').find(query).toArray((err, result) => {
            if (err) return
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
    