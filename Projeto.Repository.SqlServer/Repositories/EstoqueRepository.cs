using Projeto.Repository.SqlServer.Contracts;
using Projeto.Repository.SqlServer.Entities;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista de estoque
        /// </summary>
        /// <returns>Retorna a lista de estoque</returns>
        public List<Estoque> Consultar()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que exclui registro do banco de dados
        /// </summary>
        /// <param name="obj">Valor do tipo do objeto estoque</param>
        public void Excluir(Estoque obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insere registro no banco de dados
        /// </summary>
        /// <param name="obj">valor do parametro do banco de dados</param>
        public void Inserir(Estoque obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método de obter um registro do banco por id
        /// </summary>
        /// <param name="obj">Tipo recebido do objeto estoque</param>
        public void ObterPorId(Estoque obj)
        {
            throw new NotImplementedException();
        }
    }
}
