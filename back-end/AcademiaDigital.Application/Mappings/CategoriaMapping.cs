using AcademiaDigital.Application.DTOs.CategoriaDTO;
using AcademiaDigital.Domain.Entities;

namespace AcademiaDigital.Application.Mappings;

public static class CategoriaMapping
{
    public static CategoriaDTO ToCategoriaDTO(this Categoria categoria)
    {
        if (categoria is null)
            throw new ArgumentNullException(nameof(categoria));

        return new CategoriaDTO 
        {
            CategoriaId = categoria.CategoriaId,
            Name = categoria.Name ?? string.Empty,
            Description = categoria.Description ?? string.Empty,
            Date = categoria.Date
        };
    }

    public static Categoria ToCategoria(this CategoriaCreateDTO dto)
    {
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));
        return new Categoria
        {
            Name = dto.Name,
            Description = dto.Description,
            Date = DateTime.UtcNow
        };
    }

    public static void UpdateCategoria(this Categoria categoria, CategoriaUpdateDTO dto)
    {
        if (categoria is null)
            throw new ArgumentNullException(nameof(categoria));
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        categoria.Name = dto.Name;
        categoria.Description = dto.Description;
    }

    public static IEnumerable<CategoriaDTO> ToCategoriaDTOList(this IEnumerable<Categoria> categorias)
    {
        if (categorias is null)
            throw new ArgumentNullException(nameof(categorias));
        return categorias.Select(ToCategoriaDTO).ToList();
    }
}
