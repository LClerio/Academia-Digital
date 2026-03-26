using AcademiaDigital.Application.DTOs.CategoriaDTO;
using AcademiaDigital.Application.Interfaces;
using AcademiaDigital.Application.Mappings;
using AcademiaDigital.Domain.Interfaces;

namespace AcademiaDigital.Application.Services;

public class CategoriaService : ICategoriaService
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaService(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<IEnumerable<CategoriaDTO>> GetAllAsync()
    {
        var categorias = await _categoriaRepository.GetAllAsync();

        return categorias.ToCategoriaDTOList();
    }
    public async Task<CategoriaDTO?> GetByIdAsync(int id)
    {
        var categoria = await _categoriaRepository.GetAsync(id);

        if (categoria is null) return null;

        return categoria.ToCategoriaDTO();
    }

    public async Task<CategoriaDTO> CreateAsync(CategoriaCreateDTO dto)
    {
        var categoria = dto.ToCategoria();

        await _categoriaRepository.CreateAsync(categoria);

        return categoria.ToCategoriaDTO();
    }

    public async Task<bool> UpdateAsync(int id, CategoriaUpdateDTO dto)
    {
        var categoria = await _categoriaRepository.GetAsync(id);
        if (categoria is null) return false;

        categoria.UpdateCategoria(dto);

        await _categoriaRepository.UpdateAsync(categoria);

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var categoria = await _categoriaRepository.GetAsync(id);

        if (categoria is null) return false;

        await _categoriaRepository.DeleteAsync(categoria.CategoriaId);

        return true;
    }

}
