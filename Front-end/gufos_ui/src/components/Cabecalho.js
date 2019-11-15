import React, { Component } from "react";
import NavBar from "../components/NavBar";
import "../assets/css/cabecalho.css";

//withRouter para redirecionar as rotas
import { Link, withRouter } from "react-router-dom";

import logo from "../assets/img/icon-login.png";
import { usuarioAutenticado, parseJwt } from "../services/auth";

class Cabecalho extends Component {

  logout()
  {
    localStorage.removeItem("usuario-gufos");
    this.props.history.push("/");

    // alert("Usuário deslogado com sucesso!");
  }

  render() {
    const NavAdmin = (
      <div>
        <Link to="/tiposeventos">Tipos Eventos</Link>
        <Link to="/eventos/cadastrar">Eventos</Link>
        <span onClick={this.logout.bind(this)}>Sair</span>
      </div>
    );
  
    const NavComum = (
      <div>
        <Link to="/eventos">Eventos</Link>
        <span onClick={this.logout.bind(this)}>Sair</span>
      </div>
    );
  
    const NavDeslogado = (
      <div>
        <Link to="/login">Login</Link>
      </div>
    );

    // Header v1.0
    return (
      <header className="cabecalhoPrincipal">
        <div className="container">
          <img src={logo} alt="Gufos" />

          <nav className="cabecalhoPrincipal-nav">
            <div>
              <Link to="/">Home</Link>
            </div>

            {(usuarioAutenticado() && parseJwt().permissao) === "Administrador" ? (
              NavAdmin
            ) : (usuarioAutenticado() && parseJwt().permissao) == "Aluno" ? (
              NavComum
            ) : (
              NavDeslogado
            )}

            {/* <NavBar/> */}
          </nav>
        </div>
      </header>
    );
  }
}

//componente utilizando withRouter para poder utilizar o redirect do logout
export default withRouter(Cabecalho);
