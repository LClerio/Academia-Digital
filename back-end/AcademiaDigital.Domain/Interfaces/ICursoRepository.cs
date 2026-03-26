using AcademiaDigital.Domain.Entities;

namespace AcademiaDigital.Domain.Interfaces;

public interface ICursoRepository
{
    Task<IEnumerable<Curso>> GetAllAsync();
    Task<Curso> GetAsync(int id);
    Task CreateAsync(Curso curso);
    Task UpdateAsync(Curso curso);
    Task DeleteAsync(int id);
}
