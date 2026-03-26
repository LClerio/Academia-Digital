namespace AcademiaDigital.Domain.Entities;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }

    public ICollection<Curso>? Cursos { get; set; }
}
