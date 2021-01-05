GET ALL PRODUCTS
    -> get('/')

ADD PRODUCT
    -> post('/add')
    -> body = new product

SEARCH ALL PRODUCTS
    -> post('/searchAll')
    -> body.name = name to search products by

SEARCH ONE PRODUCT
    -? post('/searchOne')
    -> body.name = exact name of product

DELETE A PRODUCT
    -> delete('/delete/:name')
    -> params.name = exact name of product to delete

EDIT A PRODUCT
    -> post('edit')
    -> body.name = exact name of product to edit
    -> body = edited product