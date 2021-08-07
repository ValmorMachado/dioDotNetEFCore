using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DioDotNetEFCore.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Nome do produto")]
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório!")]
        public string Descricao { get; set; }
        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "A quantidade é obrigatória!")]
        [Range(1, 1000, ErrorMessage = "Cadastro máximo de 1000 produtos!")]
        public int Quantidade { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
