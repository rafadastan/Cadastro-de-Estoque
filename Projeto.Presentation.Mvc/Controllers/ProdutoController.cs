using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.Mvc.Models;
using Projeto.Repository.SqlServer.Entities;
using Projeto.Repository.SqlServer.Repositories;

namespace Projeto.Presentation.Mvc.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Consulta()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoCadastroModel model,
            [FromServices] ProdutoRepository produtoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;
                    produto.IdEstoque = model.IdEstoque;

                    produtoRepository.Inserir(produto);

                    TempData["MensagemSucesso"] = "Produto Cadastrado com sucesso! ";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = "error" + e.Message;
                }
            }
            return View();
        }
    }
}