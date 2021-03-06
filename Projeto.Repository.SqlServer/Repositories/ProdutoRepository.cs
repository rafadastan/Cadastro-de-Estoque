﻿using Dapper;
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
    /// 
    /// </summary>
    public class ProdutoRepository : IProdutoRepository
    {
        /// <summary>
        /// Variável de conexão com o banco de dados
        /// </summary>
        private string connectionString;

        public ProdutoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        /// <summary>
        /// Metodo que faz a alteração no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public void Alterar(Produto obj)
        {
            var query = "update produto set Nome = @Nome, Preco = @Preco, Quantidade = @Quantidade" +
                "where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        /// <summary>
        /// Lista os registro de produtos no banco
        /// </summary>
        /// <returns>retorna a consulta</returns>
        public List<Produto> Consultar()
        {
            var query = "select * from produto order by Nome";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query)
                    .ToList();
            }
        }

        public List<Produto> Consultar(string nome)
        {
            var query = "select * from produto where Nome like @Nome order by Nome";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query, new { Nome = "%" + nome + "%"})
                    .ToList();
            }
        }

        /// <summary>
        /// Metodo que faz a exclusão no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public void Excluir(Produto obj)
        {
            var query = "delete from produto where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        /// <summary>
        /// Metodo que faz a inserção no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public void Inserir(Produto obj)
        {
            var query = "insert into produto (Nome, Preco, Quantidade)" +
                "values (@Nome, @Preco, @Quantidade)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        /// <summary>
        /// Metodo que faz a uma busca por Id no banco de dados com dapper
        /// </summary>
        /// <param name="obj">variavel do tipo produto</param>
        public Produto ObterPorId(int id)
        {
            var query = "select * from produto where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query, new { IdProduto = id }).FirstOrDefault();
            }
        }
    }
}
