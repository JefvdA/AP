import React, { Component } from 'react';
import axios from 'axios';
import { Container, Col, Form, FormGroup, Label, Input } from 'reactstrap';

class DeleteProduct extends Component {

    constructor(props){
        super(props);
        if(this.props.match) {
            this.state = { name: this.props.match.params.product }
        } else {
            this.state = { name: '' }
        }
        // bind class methods, alternative is arrow function:
        // searchAll = ()=> {} OR <button onClick={(e) => this.handleInputChange(e)}>
        this.handleInputChange = this.handleInputChange.bind(this);
        this.deleteProduct = this.deleteProduct.bind(this);
    }

    deleteProduct(){
        axios.delete('http://localhost:4000/products/delete/' + this.state.name)
            .then((result) => {
                //console.log(result);
            })
            .catch((error) => {
                console.error(error)
            });
        this.props.history.push('/list');
    }

    handleInputChange(event){
        // possiblility to check on taget.type of target.name for
        // multiple inputs
        this.setState({ [event.target.name]: event.target.value });
    }

    render() {
        return (
            <Container className='App'>
                <h1 className='display-4'>Delete Product</h1>
                <br/>
                <Form className='form-group w-50'>
                    <Col>
                        <FormGroup row>
                            <Label for='name'>Name</Label>
                            <Input type = 'text' className='form-control' name='name' value={ this.state.name } onChange={ this.handleInputChange } placeholder='Enter product name' />
                        </FormGroup>
                    </Col>
                    <Col>
                        <FormGroup row>
                            <button type='button' onClick={ this.deleteProduct } className='btn btn-outline-primary'>Delete</button>
                        </FormGroup>
                    </Col>
                </Form>
            </Container>
        );
    }
}

export default DeleteProduct;