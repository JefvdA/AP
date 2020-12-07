var createError = require('http-errors');
var express = require('express');
var path = require('path');
var cookieParser = require('cookie-parser');
var logger = require('morgan');
<<<<<<< HEAD
=======
var cors = require('cors');
>>>>>>> 51e8452e714132173aa0bf9c264878be70d1d10a

var indexRouter = require('./routes/index');
var productsRouter = require('./routes/products.js');

var app = express();

<<<<<<< HEAD
=======
//CORS
var originWhiteList = [
  'http://localhost:4200'
];
var corsOptions = {
  origin: function(origin, callback) {
    var isWhitelisted = originWhiteList.indexOf(origin) !== -1;
    callback(null, isWhitelisted);
  }
}
app.use(cors(corsOptions));

>>>>>>> 51e8452e714132173aa0bf9c264878be70d1d10a
// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs');

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

app.use('/', indexRouter);
app.use('/products', productsRouter);

// catch 404 and forward to error handler
app.use(function(req, res, next) {
  next(createError(404));
});

// error handler
app.use(function(err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  res.render('error');
});

module.exports = app;
