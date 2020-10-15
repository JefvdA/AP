var express = require('express');
var router = express.Router();
const axios = require('axios');
const { response } = require('express');
const DB_URL = "http://127.0.0.1:5984/products/";
const DB_VIEWS = "_design/views/_view/";

/* GET ALL PRODUCTS */
router.get('/', (req, res) => {
    axios.get(DB_URL + DB_VIEWS + "allProducts")
        .then(function(response) {
            //console.log(response.data.rows);
            res.render('list.ejs', { products: response.data.rows });
        })
        .catch(function(error) {
            console.log(error);
        });
});

/* SHOW ADD PRODUCT FORM */
router.get('/add', (req, res) => {
    res.render('add.ejs', {});
});

/* ADD PRODUCT TO DB */
router.post('/add', (req, res) => {
    axios.post(DB_URL, req.body)
        .then(response => res.redirect('/'))
        .catch(error => console.log(error));
});

/* SEARCH FORM */
router.get('/search', (req, res) => {
    res.render('search.ejs', {});
});

/* FIND A PRODUCT */
router.post('/search', (req, res) => {
    axios.get(DB_URL + DB_VIEWS + "allProducts" + '?key="' + req.body.name + '"')
        .then(function(response) {
            //console.log(response.data.rows[0]);
            if(response.data.rows[0])
                res.render("search_result.ejs", { product: response.data.rows[0] });
            else
                res.render("search_not_found.ejs", {});
        })
        .catch(function(error) {
            console.log(error);
        });
});

/* DELETA A PRODUCT */
router.post('/delete', (req, res) => {
    axios.get(DB_URL + DB_VIEWS + "allProducts" + '?key="' + req.body.name + '"')
        .then(function(response) {
            if(response.data.rows[0]) {
                var id = response.data.rows[0].value._id;
                var rev = response.data.rows[0].value._rev;
                axios.delete(DB_URL + id + '?rev=' + rev).then(response => res.redirect('/')).catch(error => console.log(error));
            }
        })
        .catch(error => console.log(error));
});

module.exports = router;
    