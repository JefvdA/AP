import React, { Component } from 'react';
import axios from 'axios';
import { Container, Label } from 'reactstrap';
import TableRow from './TableRow.js';

class ListProduct extends Component {

    constructor(props){
        super(props);
        this.state = {
            products: [],
        };
        // bind class methods, alternative is arrow function:
        // searchAll = ()=> {} OR <button onClick={(e) => this.handleInputChange(e)}>
        this.handleInputChange = this.handleInputChange.bind(this);
    }

    componentDidMount() {
        this.listAll();
    }

    listAll() {
        axios.get('http://localhost:4000/')
            .then((result) => {
                this.setState({ products: result.data });
            })
            .catch((error) => {
                console.error(error);
            })
    }

    handleInputChange(event){
        // possiblility to check on taget.type of target.name for
        // multiple inputs
        this.setState({ [event.target.name]: event.target.value });
    }

    tableRows(){
        return this.state.products.map((object, i) => {
            return <TableRow obj={ object } key={ i } />
        });
    }

    render() {
        return (
            <Container className='App'>
                <h1 className='display-4'>All Products</h1>
                <br/>
                <div>
                    <h1 className='display-4'>Results</h1>
                    <br/><br/>
                    <table className='table table-striped'>
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Brand</th>
                                <th>Description</th>
                                <th>Price</th>
                            </tr>
                        </thead>
                        <tbody>
                            { this.tableRows() }
                        </tbody>
                    </table>
                </div>
            </Container>
        );
    }
}

export default ListProduct;