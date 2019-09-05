import axios from 'axios';

//Serviço generico para fazer as chamadas para api
export default {
  call(endpoint) {
    let auth = "bearer " + localStorage.getItem("usuario-svigufo"); //Retorna o token como uma string.
    
    let config = {
      headers: {
        "Content-Type" : "application/json",
        "Authorization" : auth
      }
    }

    // let urlApi = `http://192.168.4.112:5000/api/${endpoint}`;
    let urlApi = `http://localhost:5000/api/${endpoint}`;

    return {
      getOne: ({ id }) => axios.get(`${urlApi}/${id}`, config),
      getAll: () => axios.get(`${urlApi}`, config),
      update: (toUpdate) =>  axios.put(urlApi,toUpdate, config),
      create: (toCreate) =>  axios.post(urlApi,toCreate, config),
      delete: ({ id }) =>  axios.delete(`${urlApi}/${id}`, config)
    }
  }
}