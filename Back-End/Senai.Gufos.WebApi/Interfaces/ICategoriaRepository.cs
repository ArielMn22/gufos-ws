using System.Collections.Generic;
using Senai.Gufos.WebApi.Domains;

namespace Senai.Gufos.WebApi.Interfaces
{
    public interface ICategoriaRepository
    {
        /// <summary>
        /// Listar todas as categorias.
        /// </summary>
        /// <returns>Retorna uma lista de categorias. List<Categorias></returns>
         List<Categorias> ListarTodos();

        /// <summary>
        /// Cadastra uma categoria no sistema.
        /// </summary>
        /// <param name="categoria">Categoria item</param>
         void Cadastrar(Categorias categoria);

        /// <summary>
        /// Busca uma categoria por Id.
        /// </summary>
        /// <param name="idCategoria">Id da categoria.</param>
        /// <returns>Categoria item.</returns>
         Categorias BuscarPorId(int idCategoria);

        /// <summary>
        /// Deleta uma categoria por Id.
        /// </summary>
        /// <param name="idCategoria">Id da categoria.</param>
         void DeletarPorId(int idCategoria);

        /// <summary>
        /// Atualiza uma categoria já cadastrada no sistema.
        /// </summary>
        /// <param name="categoria">Categoria item.</param>
         void Atualizar(Categorias categoria);
    }
}