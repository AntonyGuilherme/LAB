const express = require('express')
const app = express()
const PORT = 3000
const HOST_IP = 'localhost';

const axios = require('axios').default;

app.get('/', (req, res) => {

    res.send("Hello");

})

app.get('/user-can-access/:cardId', (req, res) => {
  const { cardId } = req.params;
  
  console.log(`The follow cardId was received ${cardId}`);
  
  return axios
  .get(`http:/localhost:5237/api/access?cardId=${cardId}`)
  .then((catracaInteligenteResponse) => {
    console.log(`The access was ${catracaInteligenteResponse.data ? 'Allowed' : 'Denied'}`);
    res.send(catracaInteligenteResponse.data);
    console.log('email was sended');
  });
});

app.listen(PORT, HOST_IP,  () => {
  console.log(`Device service is listening in ${HOST_IP + ':' + PORT}`)
})