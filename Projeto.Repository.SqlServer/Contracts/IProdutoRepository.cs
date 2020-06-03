using Projeto.Repository.SqlServer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.SqlServer.Contracts
{
    /// <summary>
    /// Implementa os métodos do IBaseRepository
    /// </summary>
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        List<Produto> Consultar(string nome);
    }
}
