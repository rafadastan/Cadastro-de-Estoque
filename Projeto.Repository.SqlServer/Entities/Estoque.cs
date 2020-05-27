using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.SqlServer.Entities
{
    /// <summary>
    /// Classe estoque mapeamento da entities
    /// </summary>
    public class Estoque
    {
        /// <summary>
        /// Atributos da classe estoque
        /// </summary>
        public int IdEstoque { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<Produto> produtos { get; set; }

        /// <summary>
        /// construtor default
        /// </summary>
        public Estoque()
        {
        }

        /// <summary>
        /// construtor com sobrecarga de parametros
        /// </summary>
        /// <param name="idEstoque">referencia o atributo da classe</param>
        /// <param name="nome">Nome de entrada da classe</param>
        /// <param name="dataCriacao"> Descrição da classe</param>
        /// <param name="produtos">Lista de produtos</param>
        public Estoque(int idEstoque, string nome, DateTime dataCriacao, List<Produto> produtos)
        {
            IdEstoque = idEstoque;
            Nome = nome;
            DataCriacao = dataCriacao;
            this.produtos = produtos;
        }
    }
}
