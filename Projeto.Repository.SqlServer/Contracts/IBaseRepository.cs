using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.SqlServer.Contracts
{
    /// <summary>
    /// Contrato com crud para ser implementado no repository
    /// </summary>
    /// <typeparam name="T">Objeto Genérico passado por parametro</typeparam>
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Metodos do contrato para ser implementado
        /// </summary>
        /// <param name="obj">Tipo que recebe objeto generico T</param>
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
        List<T> Consultar();
        void ObterPorId(T obj);
    }
}
