using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
    }
}