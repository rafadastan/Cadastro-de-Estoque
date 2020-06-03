using Projeto.Repository.SqlServer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Models
{
    public class EstoqueConsultaModel
    {
        [Required(ErrorMessage = "Digite o nome")]
        [MaxLength(150, ErrorMessage = "O máximo de caracteres é de {1}")]
        [MinLength(3, ErrorMessage = "O mínimo de caracteres é de {1}")]
        public string Nome { get; set; }

        public List<Estoque> Estoques { get; set; }
    }
}
