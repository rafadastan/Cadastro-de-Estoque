using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.SqlServer.Entities
{
    /// <summary>
    /// Classe da entity produto
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Atributos da classe
        /// </summary>
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdEstoque { get; set; }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public Produto()
        {
        }

        /// <summary>
        /// construtor com argumentos e sobrecarga
        /// </summary>
        /// <param name="idProduto"> classe produto e id do produto</param>
        /// <param name="nome">nome do produto</param>
        /// <param name="preco">preço do produto</param>
        /// <param name="quantidade">quantidade do produto</param>
        /// <param name="idEstoque">id do estoque referencia no banco de dados da classe</param>
        public Produto(int idProduto, string nome, decimal preco, int quantidade, int idEstoque)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            IdEstoque = idEstoque;
        }
    }
}
