using AcademiaDigital.Application.DTOs.CursoDTO;
using AcademiaDigital.Domain.Entities;

namespace AcademiaDigital.Application.Mappings;

public static class CursoMapping
{
    public static CursoDTO ToCursoDTO(this Curso curso)
    {
        if (curso is null)
            throw new ArgumentNullException(nameof(curso));

        return new CursoDTO
        {
            CursoId = curso.CursoId,
            Name = curso.Name ?? string.Empty,
            Description = curso.Description ?? string.Empty,
            Price = curso.Price,
            ImageUrl = curso.ImageUrl ?? string.Empty,
            ImageThumbnailUrl = curso.ImageThumbnailUrl ?? string.Empty,
            Date = curso.Date,
            CategoriaId = curso.CategoriaId
        };
    }


    public static Curso ToCurso(this CursoCreateDTO dto)
    {
        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        return new Curso
        {
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            ImageUrl = dto.ImageUrl,
            ImageThumbnailUrl = dto.ImageThumbnailUrl,
            CategoriaId = dto.CategoriaId,
            Date = DateTime.UtcNow
        };
    }

    public static void UpdateCurso(this Curso curso, CursoUpdateDTO dto)
    {
        if (curso is null)
            throw new ArgumentNullException(nameof(curso));

        if (dto is null)
            throw new ArgumentNullException(nameof(dto));

        curso.Name = dto.Name;
        curso.Description = dto.Description;
        curso.Price = dto.Price;
        curso.ImageUrl = dto.ImageUrl;
        curso.ImageThumbnailUrl = dto.ImageThumbnailUrl;
        curso.CategoriaId = dto.CategoriaId;
    }

    public static IEnumerable<CursoDTO> ToCursoDTOList(this IEnumerable<Curso> cursos)
    {
        if (cursos is null)
            throw new ArgumentNullException(nameof(cursos));

        return cursos.Select(ToCursoDTO).ToList();
    }
}
