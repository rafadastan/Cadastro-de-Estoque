using Dapper;
using Projeto.Repository.SqlServer.Contracts;
using Projeto.Repository.SqlServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto.Repository.SqlServer.Repositories
{
    /// <summary>
    /// Classe que implementa as alterações e consultas no banco de dados através do Dapper
    /// </summary>
    public class EstoqueRepository : IEstoqueRepository
    {
        /// <summary>
        /// Atributo de conexão com o banco de dados
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Método que alterar um registro do banco de dados
        /// </summary>
        /// <param name="obj">Parametro do tipo do objeto esperado</param>
        public void Alterar(Estoque obj)
        {
            var query = "update Estoque set Nome = @Nome, Descricao = @Descricao" +
                "where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        /// <summary>
        /// Lista de estoque
        /// </summary>
        /// <returns>Retorna a lista de estoque</returns>
        public List<Estoque> Consultar()
        {
            var query = "select * from Estoque";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Estoque>(query)
                    .ToList();
            }
        }

        /// <summary>
        /// Metodo que exclui registro do banco de dados
        /// </summary>
        /// <param name="obj">Valor do tipo do objeto estoque</param>
        public void Excluir(Estoque obj)
        {
            var query = "delete from Estoque where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        /// <summary>
        /// Insere registro no banco de dados
        /// </summary>
        /// <param name="obj">valor do parametro do banco de dados</param>
        public void Inserir(Estoque obj)
        {
            var query = "insert into Estoque (Nome, Descricao)" +
                "values (@Nome, @Descricao)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        /// <summary>
        /// Método de obter um registro do banco por id
        /// </summary>
        /// <param name="obj">Tipo recebido do objeto estoque</param>
        public Estoque ObterPorId(int id)
        {
            var query = "select * from Estoque where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Estoque>(query, new {IdEstoque = id }).FirstOrDefault();
            }
        }
    }
}
