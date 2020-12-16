import React from 'react';
import axios from 'axios';

class App extends React.Component {
  constructor(props){
    super(props);
    this.state = {
      imageURL: '',
    }
  }

  componentDidMount() {
    axios.get('https://dog.ceo/api/breeds/image/random')
      .then(response => {
        this.setState({ imageURL: response.data.message });
      })
      .catch(error => {
        console.log(error);
      })
  }

  render(){
    return (
      <img width="300" height="300" src={ this.state.imageURL } />
    )
  }
}

export default App;
