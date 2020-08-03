using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Models
{
    public class ProdutoCadastroModel
    {
        [Required(ErrorMessage ="Por favor, digite o nome do produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Por favor, digite o preço do produto")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Por favor, digite a quantidade do produto")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage ="Por favor, selecione um Estoque")]
        public int IdEstoque { get; set; }

        public List<SelectListItem> ListaDeEstoque { get; set; }

    }
}
