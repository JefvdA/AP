import React, { Component } from 'react';
import SearchProduct from './product/SearchProduct';
import ListProduct from './product/ListProduct';
import AddProduct from './product/AddProduct';
import DeleteProduct from './product/DeleteProduct';
import EditProduct from './product/EditProduct';
import { BrowserRouter, Switch, Route, Link } from 'react-router-dom';
import Login from './auth/Login';

class App extends Component {

  constructor(props) {
    super(props);
    this.state = { authenticated: false }
    this.logout = this.logout.bind(this);
  }

  componentDidMount() {
    if(localStorage.getItem('user')){
      let user = JSON.parse(localStorage.getItem('user'));
      this.setState({ authenticated: user.authenticated });
    }
  }

  logout() {
    localStorage.removeItem('user');
    window.location.reload();
  }

  render(){
    if(this.state.authenticated === true) {
      return (
        <div className='container'>
          <BrowserRouter>
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
              <div className="container-fluid">
                <a className="navbar-brand">Products</a>
                <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                  <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse" id="navbarNav">
                  <ul className="navbar-nav">
                    <li className="nav-item active">
                      <Link to={ '/list' } className='nav-link'>List</Link>
                    </li>
                    <li className="nav-item active">
                      <Link to={ '/add' } className='nav-link'>Add</Link>
                    </li>
                    <li className="nav-item active">
                      <Link to={ '/search' } className='nav-link'>Search</Link>
                    </li>
                    <li className="nav-item active">
                      <Link to={ '/delete' } className='nav-link'>Delete</Link>
                    </li>
                    <li className="nav-item active">
                      <Link to={ '' } onClick={ this.logout } className='nav-link'>Logout</Link>
                    </li>
                  </ul>
                </div>
              </div>
            </nav>
            <br/><br/>
            <Switch>
              <Route exact path='/list' component={ ListProduct } />
              <Route exact path='/add' component={ AddProduct } />
              <Route exact path='/search' componen={ SearchProduct } />
              <Route exact path='/edit/:product' component={ EditProduct } />
              <Route path='/delete/:product' component={ DeleteProduct } />
              <Route path='/delete' component={ DeleteProduct } />
              <Route exact path='/login' component={ Login } />
              <Route path='*'><ListProduct/></Route>
            </Switch>
          </BrowserRouter>
        </div>
      );
    } else {
      return (
        <BrowserRouter>
          <Route path="*" component={ Login } />
        </BrowserRouter>
      );
    }
  }
}

export default App;
