using Projeto.Repository.SqlServer.Contracts;
using Projeto.Repository.SqlServer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.SqlServer.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class ProdutoRepository : IProdutoRepository
    {
        /// <summary>
        /// Variável de conexão com o banco de dados
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Metodo que faz a alteração no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public void Alterar(Produto obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista os registro de produtos no banco
        /// </summary>
        /// <returns>retorna a consulta</returns>
        public List<Produto> Consultar()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que faz a exclusão no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public void Excluir(Produto obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que faz a inserção no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public void Inserir(Produto obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que faz a uma busca por Id no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public void ObterPorId(Produto obj)
        {
            throw new NotImplementedException();
        }
    }
}
