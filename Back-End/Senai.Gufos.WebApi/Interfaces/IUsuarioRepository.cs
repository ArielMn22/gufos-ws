using Senai.Gufos.WebApi.Domains;
using Senai.Gufos.WebApi.ViewModels;

namespace Senai.Gufos.WebApi.Interfaces
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Busca um usuário por e-mail e sennha.
        /// </summary>
        /// <param name="login">LoginViewModel que contêm o e-mail e senha do usuário.</param>
        /// <returns>Caso consiga encontrar o usuário, retornará o usuário, caso contrário retornará 'null'.</returns>
        Usuarios BuscarPorEmaileSenha(LoginViewModel login);
    }
}