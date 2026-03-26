using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDigital.Application.DTOs.CursoDTO
{
    public class CursoDTO
    {
        public int CursoId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre {2} e {1} caracteres.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "A descrição deve ter entre {2} e {1} caracteres.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, 100000, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Price { get; set; }
        [StringLength(500, MinimumLength = 10, ErrorMessage = "A descrição deve ter entre {2} e {1} caracteres.")]
        public string ImageUrl { get; set; } = string.Empty;
        [StringLength(500, MinimumLength = 10, ErrorMessage = "A descrição deve ter entre {2} e {1} caracteres.")]
        public string ImageThumbnailUrl { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int CategoriaId { get; set; }
    }
}
