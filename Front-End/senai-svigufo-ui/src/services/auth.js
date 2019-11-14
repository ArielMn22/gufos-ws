export const usuarioAutenticado = () => localStorage.getItem("usuario-svigufo") !== null; // Retorna true se houver token e false se nao houver.

export const parseJwt = () =>{ // Retorna um objeto com o token decodificado.
    let jwtDecode = require("jwt-decode"); // Importando o jwt-decode

    var token = localStorage.getItem("usuario-svigufo");

    return jwtDecode(token);
    // var base64Url = localStorage.getItem("usuario-svigufo").split('.')[1];
    // var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
    
    // return JSON.parse(window.atob(base64));
}
