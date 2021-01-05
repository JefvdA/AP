import React, { Component } from 'react';
import axios from 'axios';
import { Container, Col, Form, FormGroup, Label, Input } from 'reactstrap';

class EditProduct extends Component {

    constructor(props){
        super(props);
        this.state = {
            name: this.props.match.params.product,
            brand: '',
            description: '',
            price: '',
        };
        // bind class methods, alternative is arrow function:
        // searchAll = ()=> {} OR <button onClick={(e) => this.handleInputChange(e)}>
        this.handleInputChange = this.handleInputChange.bind(this);
        this.editProduct = this.editProduct.bind(this);
    }

    componentDidMount() {
        axios.post('http://localhost:4000/products/searchOne', { name: this.state.name })
            .then(json => {
                const product = json.data[0];
                console.log(product);
                this.setState({ name: product.name,
                                brand: product.brand,
                                description: product.description,
                                price: product.price });
            })
            .catch(error => console.log(error));
    }

    editProduct(){
        axios.post('http://localhost:4000/products/edit', this.state)
            .then(result => {
                // executed correctly
            })
            .catch(error => {
                console.error(error);
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
                <h1 className='display-4'>Edit Product</h1>
                <br/>
                <Form className='form-group w-50'>
                    <Col>
                        <FormGroup row>
                            <Label for='name'>Name: { this.state.name }</Label>
                        </FormGroup>
                        <FormGroup row>
                            <Label for='name'>Brand</Label>
                            <Input type = 'text' className='form-control' name='brand' value={ this.state.brand } onChange={ this.handleInputChange } placeholder='Enter product brand' />
                        </FormGroup>
                        <FormGroup row>
                            <Label for='name'>Description</Label>
                            <Input type = 'text' className='form-control' name='description' value={ this.state.description } onChange={ this.handleInputChange } placeholder='Enter product description' />
                        </FormGroup>
                        <FormGroup row>
                            <Label for='name'>Price</Label>
                            <Input type = 'text' className='form-control' name='price' value={ this.state.price } onChange={ this.handleInputChange } placeholder='Enter product price' />
                        </FormGroup>
                    </Col>
                    <Col>
                        <FormGroup row>
                            <button type='button' onClick={ this.editProduct } className='btn btn-outline-primary'>Edit</button>
                        </FormGroup>
                    </Col>
                </Form>
            </Container>
        );
    }
}

export default EditProduct;