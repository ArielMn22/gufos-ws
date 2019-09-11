using System.Collections.Generic;
using Senai.Gufos.WebApi.Domains;

namespace Senai.Gufos.WebApi.Interfaces
{
    public interface IEventoRepository
    {
        /// <summary>
        /// Listar todos os eventos cadastrados.
        /// </summary>
        /// <returns>Uma lista de eventos. List<Eventos></returns>
        List<Eventos> ListarTodos();

        /// <summary>
        /// Cadastrar um evento.
        /// </summary>
        void Cadastrar(Eventos evento);
    }
}