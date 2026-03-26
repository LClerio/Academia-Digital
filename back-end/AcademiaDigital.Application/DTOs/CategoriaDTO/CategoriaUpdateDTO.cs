using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDigital.Application.DTOs.CategoriaDTO
{
    public class CategoriaUpdateDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O tamanho deve ter entre {2} e {1} caracteres")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O tamanho deve ter entre {2} e {1} caracteres")]
        public string Description { get; set; } = string.Empty;
    }
}
