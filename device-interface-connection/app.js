const express = require('express')
const app = express()
const PORT = 3000
const HOST_IP = '192.168.1.131';

const axios = require('axios').default;

app.get('/', (req, res) => {

    res.send("Hello");

})

app.get('/user-can-access/:cardId', (req, res) => {
  const { cardId } = req.params;
  
  console.log(`The follow cardId was received ${cardId}`);

  return axios
  .get(`http://localhost:5115/CratracaInteligente/CanUserAccessCollegeRestaurant?cardId=${cardId}`)
  .then((catracaInteligenteResponse) => {
    console.log(`The access was ${catracaInteligenteResponse.data ? 'Allowed' : 'Denied'}`);
    res.send(catracaInteligenteResponse.data);
  });
});

app.listen(PORT, HOST_IP,  () => {
  console.log(`Device service is listening in ${HOST_IP + ':' + PORT}`)
})