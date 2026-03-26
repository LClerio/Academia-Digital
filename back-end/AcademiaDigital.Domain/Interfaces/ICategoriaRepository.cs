using AcademiaDigital.Domain.Entities;

namespace AcademiaDigital.Domain.Interfaces;

public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> GetAllAsync();
    Task<Categoria> GetAsync(int id);
    Task CreateAsync(Categoria categoria);
    Task UpdateAsync(Categoria categoria);
    Task DeleteAsync(int id);
}
