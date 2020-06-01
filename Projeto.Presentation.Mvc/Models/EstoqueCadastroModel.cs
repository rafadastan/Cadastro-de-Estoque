using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Models
{
    public class EstoqueCadastroModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage ="No máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        public string DataCriacao { get; set; }
    }
}
