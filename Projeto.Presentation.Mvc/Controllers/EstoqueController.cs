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
    public class EstoqueController : Controller
    {
        public IActionResult Consulta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Consulta(EstoqueConsultaModel model, 
            [FromServices] EstoqueRepository estoqueRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Estoques = estoqueRepository.Consultar(model.Nome);
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = "Erro: " + e.Message;
                }
            }
            return View(model);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(EstoqueCadastroModel model,
            [FromServices] EstoqueRepository estoqueRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var estoque = new Estoque();
                    estoque.Nome = model.Nome;
                    estoque.DataCriacao = DateTime.Parse(model.DataCriacao);

                    estoqueRepository.Inserir(estoque);

                    TempData["MensagemSucesso"] = "Funcionário cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;
                }
            }
            return View();
        }

        public IActionResult Exclusao(int id, 
            [FromServices] EstoqueRepository estoqueRepository)
        {
            try
            {
                var estoque = estoqueRepository.ObterPorId(id);
                if (estoque != null)
                {
                    estoqueRepository.Excluir(estoque);
                    TempData["MensagemSucesso"] = "Estoque excluído com sucesso!";
                }
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = "Erro: " + e.Message;
            }

            return RedirectToAction("Consulta");
        }


    }
}