
using AcademiaDigital.Application.DTOs.CategoriaDTO;

namespace AcademiaDigital.Application.Interfaces;

public interface ICategoriaService
{
    Task<IEnumerable<CategoriaDTO>> GetAllAsync();

    Task<CategoriaDTO?> GetByIdAsync(int id);

    Task<CategoriaDTO> CreateAsync(CategoriaCreateDTO dto);

    Task<bool> UpdateAsync(int id, CategoriaUpdateDTO dto);

    Task<bool> DeleteAsync(int id);
}
