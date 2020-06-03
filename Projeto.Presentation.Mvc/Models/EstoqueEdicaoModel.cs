using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Models
{
    public class EstoqueEdicaoModel
    {
        public int IdEstoque { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        [MaxLength(150, ErrorMessage = "O Máximo é de {1} caracteres")]
        [MinLength(3, ErrorMessage ="O mínimo é de {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite a data de criação")]
        public string DataCriacao { get; set; }
    }
}
