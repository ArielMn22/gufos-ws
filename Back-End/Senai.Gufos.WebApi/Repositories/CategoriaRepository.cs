using Senai.Gufos.WebApi.Domains;
using Senai.Gufos.WebApi.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace Senai.Gufos.WebApi.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public List<Categorias> ListarTodos()
        {
            using (GufosContext ctx = new GufosContext())
            {
                // facilitar a nossa vida
                // select * from categorias;
                return ctx.Categorias.ToList();
            }
        }

        public void Cadastrar(Categorias categoria)
        {
            using (GufosContext ctx = new GufosContext())
            {
                // insert into categorias (nome) values (@nome);
                ctx.Categorias.Add(categoria);
                ctx.SaveChanges();
            }
        }

        // buscar por id
        public Categorias BuscarPorId(int id)
        {
            using (GufosContext ctx = new GufosContext())
            {
                return ctx.Categorias.FirstOrDefault(x => x.IdCategoria == id);
            }
        }

        // atualizar
        public void Atualizar(Categorias categoria)
        {
            using (GufosContext ctx = new GufosContext())
            {
                Categorias CategoriaBuscada = ctx.Categorias.FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);
                // update categorias set nome = @nome
                CategoriaBuscada.Nome = categoria.Nome;
                // insert - add, delete - remove, update - update
                ctx.Categorias.Update(CategoriaBuscada);
                // efetivar
                ctx.SaveChanges();
            }
        }

        // deletar
        public void DeletarPorId(int id)
        {
            using (GufosContext ctx = new GufosContext())
            {
                // encontrar o item
                // chave primaria da tabela
                Categorias Categoria = ctx.Categorias.Find(id);
                // remover do contexto
                ctx.Categorias.Remove(Categoria);
                // efetivar as mudanças no banco de dados
                ctx.SaveChanges();
            }
        }
    }
}
