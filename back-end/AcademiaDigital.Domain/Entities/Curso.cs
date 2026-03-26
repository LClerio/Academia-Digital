namespace AcademiaDigital.Domain.Entities;

public class Curso
{
    public int CursoId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageThumbnailUrl { get; set; }
    public DateTime Date { get; set; }

    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }

}
