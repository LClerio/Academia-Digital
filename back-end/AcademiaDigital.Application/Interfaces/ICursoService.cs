using AcademiaDigital.Application.DTOs.CursoDTO;

namespace AcademiaDigital.Application.Interfaces;

public interface ICursoService
{
    Task<IEnumerable<CursoDTO>> GetAllAsync();

    Task<CursoDTO?> GetByIdAsync(int id);

    Task<CursoDTO> CreateAsync(CursoCreateDTO dto);

    Task<bool> UpdateAsync(int id, CursoUpdateDTO dto);

    Task<bool> DeleteAsync(int id);
}
